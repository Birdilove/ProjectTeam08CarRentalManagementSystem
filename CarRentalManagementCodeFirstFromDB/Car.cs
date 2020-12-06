namespace CarRentalManagementCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Car()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int CarId { get; set; }

        public int TypeId { get; set; }

        public int MakeId { get; set; }

        [Required]
        [StringLength(50)]
        public string Color { get; set; }

        [Required]
        [StringLength(50)]
        public string Model { get; set; }

        public int Year { get; set; }

        public decimal Price { get; set; }

        public virtual CarMake CarMake { get; set; }

        public virtual CarType CarType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservations { get; set; }

        public override string ToString()
        {
            return Model;
        }
    }
}
