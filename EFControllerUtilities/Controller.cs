using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;

namespace EFControllerUtilities
{
    /// <summary>
    /// Controller class is implements a repository pattern. Methods all
    /// use a unit of work, creating a context, performing CRUD operations,
    /// then disposing of the context.
    /// C is the DbContext type, E is the entity type within the DbContext.
    /// </summary>
    /// <typeparam name="C">DbContext type</typeparam>
    /// <typeparam name="E">Entity type</typeparam>
    public static class Controller<C, E> where E : class where C : DbContext, new()
    {
        /// <summary>
        /// Enable logging of sql statements to output window. Defaults to true.
        /// </summary>
        public static bool DataBaseLogging { get; set; } = true;

        /// <summary>
        /// Creates a context of type C with database logging optionally enabled.
        /// This should probably be private. It is used internally by most
        /// methods in this class.
        /// </summary>
        /// <returns></returns>
        public static C SetContext()
        {

            C context = new C();

            // set up database log to write to output window in VS
            EnableDatabaseLogging(context);

            return context;

        }

        /// <summary>
        /// Enable the tracing of SQL statements in the Output window
        /// only if property <paramref name="DataBaseLogging"/> is set to true
        /// </summary>
        /// <param name="context"></param>
        public static void EnableDatabaseLogging(C context)
        {
            if (context == null || DataBaseLogging == false)
                return;

            Debug.WriteLine($"EnableDatabaseLogging() for {context.Database.Connection.Database}");

            // set up database log to write to output window in VS
            context.Database.Log = (s => Debug.Write(s));
            context.SaveChanges();
        }

        /// <summary>
        /// Gets all entities from a context of a particular type <typeparamref name="E"/>.
        /// This is a list generated from a DbSet in a context.
        /// List can be filtered by filter function.
        /// </summary>
        /// <param name="filter">Filter to be inserted in where clause to limit the entities returned</param>
        /// <returns>List of entities</returns>
        public static IEnumerable<E> GetEntities(Func<E, bool> filter = null)
        {
            IEnumerable<E> result;

            using (var context = SetContext())
            {
                // the only issue with this scheme is that generic Set loads the entire table
                // from the db, instead of using the Where clause. Doesn't know how 
                // to do this at compile time, so just loads everything then filters in memory.

                // if we use the actual strongly typed entity class, we get the correct query
                // with a where clause. bad side effect of generics here.

                DbSet<E> dbSet = context.Set<E>();

                if (filter == null)
                    result = dbSet.ToList();
                else
                {
                    result = dbSet.Where(filter).ToList();
                }
            }
            Debug.WriteLine($"GetEntities<{typeof(E)}>(filter)");
            return result;
        }

        /// <summary>
        /// Gets all entities from a context of a particular type <typeparamref name="E"/>.
        /// This is a list generated from a DbSet in a context.
        /// List can be filtered by filter function.
        /// <para>
        /// This method forces a read from the database with AsNoTracking(). Other methods
        /// above may simply provide something from a cache. This guarantees the cache to
        /// be invalid, and a read is forced.
        /// </para>
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public static List<E> GetEntitiesNoTracking(Func<E, bool> filter = null)
        {
            List<E> result;

            using (var context = SetContext())
            {

                DbSet<E> dbSet = context.Set<E>();

                if (filter == null)
                    result = dbSet.AsNoTracking().ToList();
                else
                {
                    result = dbSet.AsNoTracking().Where(filter).ToList();
                }
            }
            Debug.WriteLine($"GetEntitiesNoTracking<{typeof(E)}>(filter)");
            return result;
        }

        /// <summary>
        /// Gets a list of entities, along with the results of a query that
        /// includes the navigation properties.
        /// </summary>
        /// <param name="navProperties"></param>
        /// <returns></returns>
        public static List<E> GetEntitiesWithIncluded(params string[] navProperties)
        {
            List<E> result;

            using (var context = SetContext())
            {
                IQueryable<E> query = context.Set<E>();

                foreach (string navProperty in navProperties)
                {
                    query = query.Include(navProperty);
                }

                result = query.ToList<E>();
            }
            Debug.WriteLine($"GetEntitiesWithIncluded<{typeof(E)}>(filter)");
            return result;
        }

        /// <summary>
        /// Determines if any entity satisfies the predicate
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public static bool AnyExists(Func<E, bool> predicate)
        {
            if (predicate == null)
                return false;
            bool result;

            using (var context = SetContext())
            {
                DbSet<E> dbSet = context.Set<E>();
                result = dbSet.Any(predicate);
            }
            Debug.WriteLine($"AnyExists<{typeof(E)}>(predicate)");
            return result;
        }

        /// <summary>
        /// Given primary keys, delete an entity from the context
        /// <para>
        /// Make sure any dependencies (navigation properties) are removed from parents before
        /// this is called.
        /// </para>
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>false if unable to delete entity</returns>
        public static bool DeleteEntity(params object[] keys)
        {
            bool result = false;
            //using (var context = new C())
            using (var context = SetContext())
            {
                DbSet<E> dbSet = context.Set<E>();
                E entity = dbSet.Find(keys);
                result = DeleteEntity(context, entity);
            }
            Debug.WriteLine($"DeleteEntity<{typeof(E)}>(params keys[])");
            return result;
        }

        /// <summary>
        /// Deletes an entity from the context.
        /// WARNING: the entity MUST exist, and should be the result of Find().
        /// <para>
        /// Make sure any dependencies (navigation properties) are removed from parents before
        /// this is called.
        /// </para>
        /// </summary>
        /// <param name="entity">entity that exists in the context</param>
        /// <returns>false if unable to delete entity</returns>
        public static bool DeleteEntity(E entity)
        {
            bool result = false;
            Debug.WriteLine($"DeleteEntity<{typeof(E)}>({entity})");
            using (var context = SetContext())
            {
                result = DeleteEntity(context, entity);
            }
            return result;
        }

        /// <summary>
        /// Removes an existing entity from a context. If entity does not exist in the context,
        /// and exception is caught and the method returns an error indication.
        /// 
        /// </summary>
        /// <param name="context">database context</param>
        /// <param name="entity">entity to be deleted</param>
        /// <returns>false if entity cannot be removed</returns>
        private static bool DeleteEntity(C context, E entity)
        {
            bool result = false;

            if (entity == null || context == null)
            {
                return result;
            }

            Debug.WriteLine($"\tDeleteEntity<{typeof(E)}>({typeof(C)}, [{entity}])");

            try
            {
                DbEntityEntry<E> entry = context.Entry<E>(entity);
                context.Entry<E>(entity).State = EntityState.Deleted;

                context.SaveChanges();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Update an entity in a context. Sets the entity state to Modified,
        /// then saves changes. If an exception is generated from SaveChanges(),
        /// the method returns false.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>false if an error occurs in the update</returns>
        public static bool UpdateEntity(E entity)
        {
            bool result = false;

            if (entity == null)
                return false;

            Debug.WriteLine($"UpdateEntity<{typeof(E)}>({entity})");

            using (var context = SetContext())
            {
                if (context.Entry(entity) == null)
                    return result;

                try
                {
                    context.Entry(entity).State = EntityState.Modified;
                    context.SaveChanges();
                    result = true;
                }
                catch (Exception)
                {
                    result = false;
                }
            }

            return result;
        }

        /// <summary>
        /// Finds an entity in the context that corresponds to the primary keys.
        /// Returns null if nothing found.
        /// </summary>
        /// <param name="keys">Primary keys</param>
        /// <returns>null if entity not found</returns>
        public static E FindEntity(params object[] keys)
        {
            E result = null;

            Debug.WriteLine($"FindEntity<{typeof(E)}>(params keys[])");

            if (keys == null || keys.Length == 0)
                return result;

            using (var context = SetContext())
            {
                DbSet<E> dbSet = context.Set<E>();
                result = dbSet.Find(keys); // queries the db
            }

            Debug.WriteLine($"\tFindEntity<{typeof(E)}>(params keys[]) returns {result}");
            return result;
        }

        /// <summary>
        /// Add an entity to the context. Returns null if unsuccessful, or the
        /// entity if added, including an updated key if db generated.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static E AddEntity(E entity)
        {
            if (entity == null)
                return null;
            E result = null;

            Debug.WriteLine($"AddEntity<{typeof(E)}>({entity})");

            using (var context = SetContext())
            {
                DbSet<E> dbSet = context.Set<E>();
                result = dbSet.Add(entity);

                try
                {
                    context.SaveChanges();
                    Debug.WriteLine("AddEntity() result: " + result);
                }
                catch (Exception)
                {
                    result = null;
                }
            }

            Debug.WriteLine($"\tAddEntity<{typeof(E)}>({entity}) returns {result}");

            return result;
        }

        /// <summary>
        /// Add a collection of entitites to the context. Returns null
        /// if unable to complete.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static IEnumerable<E> AddEntities(IEnumerable<E> entities)
        {
            IEnumerable<E> result = null;

            Debug.WriteLine($"AddEntities<{typeof(E)}>(entities)");

            using (var context = SetContext())
            {
                DbSet<E> dbSet = context.Set<E>();
                result = dbSet.AddRange(entities);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    result = null;
                }
            }
            return result;
        }

        /// <summary>
        /// Sets a binding list with a custom event handler rather than the simple builtin one for Controller.
        /// </summary>
        /// <param name="entities"></param>
        /// <param name="eventHandler"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        static public BindingList<E> SetBindingList(DbSet<E> entities, ListChangedEventHandler eventHandler, Func<E, bool> filter = null)
        {
            BindingList<E> bindingList = SetBindingList(entities, filter);

            Debug.WriteLine($"SetBindingList(<{typeof(E)}>(DbSet, handler, filter)");

            bindingList.ListChanged += eventHandler;

            return bindingList;
        }

        /// <summary>
        /// Sets a binding list from an external DbSet.
        /// </summary>
        /// <param name="entities"></param>
        /// <param name="eventHandler"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        static public BindingList<E> SetBindingList(DbSet<E> entities, Func<E, bool> filter = null)
        {
            entities.Load();
            BindingList<E> bindingList;

            if (filter != null)
            {
                List<E> list = entities.Local.Where(filter).ToList();
                bindingList = new BindingList<E>(list);
            }
            else bindingList = entities.Local.ToBindingList<E>();

            Debug.WriteLine($"SetBindingList(<{typeof(E)}>(DbSet, filter)");

            return bindingList;
        }

        /// <summary>
        /// Generate a BindingList from a list of entities generated internally.
        /// List can be filtered by filter function
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public static BindingList<E> SetBindingList(Func<E, bool> filter = null)
        {

            Debug.WriteLine($"SetBindingList<{typeof(E)}>(filter)");

            return new BindingList<E>(GetEntities(filter) as IList<E>);
        }

        /// <summary>
        /// Generates an ObservableCollection from a list of entities.
        /// Useful for ASP.NET and WPF.
        /// List of navigation properties are included in the objects.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public static ObservableCollection<E> SetObservableCollection(params string[] navProperties)
        {
            Debug.WriteLine($"SetObservableCollection<{typeof(E)}>(navProperties)");

            return new ObservableCollection<E>(GetEntitiesWithIncluded(navProperties));
        }

    }
}
