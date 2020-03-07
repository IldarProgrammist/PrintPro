namespace PrintPro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrinterModel")]
    public partial class PrinterModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PrinterModel()
        {
            CatrigeModels = new HashSet<CatrigeModel>();
        }

        public int PrinterModelID { get; set; }

        [StringLength(20)]
        public string PrinterModelName { get; set; }

        public int? PrinterFirmID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CatrigeModel> CatrigeModels { get; set; }

        public virtual PrinterFirm PrinterFirm { get; set; }
    }
}
