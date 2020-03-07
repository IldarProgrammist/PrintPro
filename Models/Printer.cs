namespace PrintPro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Printer")]
    public partial class Printer
    {
        public int PrinterID { get; set; }

        [StringLength(30)]
        public string SerialNumber { get; set; }

        public int? PrinterLocarionID { get; set; }

        public int? PrinterStatusID { get; set; }

        public virtual PrinterLocation PrinterLocation { get; set; }

        public virtual PrinterStatu PrinterStatu { get; set; }
    }
}
