namespace PrintPro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrinterLocation")]
    public partial class PrinterLocation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PrinterLocation()
        {
            Printers = new HashSet<Printer>();
        }

        [Key]
        public int LocationID { get; set; }

        [StringLength(30)]
        public string Titul { get; set; }

        [StringLength(30)]
        public string Room { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Printer> Printers { get; set; }
    }
}
