namespace PrintPro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrinterFirm")]
    public partial class PrinterFirm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PrinterFirm()
        {
            PrinterModels = new HashSet<PrinterModel>();
        }

        [Key]
        public int PritnerFirmID { get; set; }

        [StringLength(20)]
        public string PrinterFirmName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrinterModel> PrinterModels { get; set; }
    }
}
