namespace CarRentalManagementCodeFirstFromDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CarRentalManagementEntities : DbContext
    {
        public CarRentalManagementEntities()
            : base("name=CarRentalManagementEntities")
        {
        }

        public virtual DbSet<CarMake> CarMakes { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<CarType> CarTypes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarMake>()
                .HasMany(e => e.Cars)
                .WithRequired(e => e.CarMake)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Car>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.Car)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CarType>()
                .HasMany(e => e.Cars)
                .WithRequired(e => e.CarType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);
        }
    }
}
