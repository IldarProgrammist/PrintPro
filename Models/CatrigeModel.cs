namespace PrintPro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CatrigeModel")]
    public partial class CatrigeModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatrigeModel()
        {
            Catriges = new HashSet<Catrige>();
        }

        public int CatrigeModelID { get; set; }

        [StringLength(30)]
        public string CatrigeName { get; set; }

        public int? ColorID { get; set; }

        public int? PrinterModelID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Catrige> Catriges { get; set; }

        public virtual Color Color { get; set; }

        public virtual PrinterModel PrinterModel { get; set; }
    }
}
