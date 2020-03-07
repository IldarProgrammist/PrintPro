namespace PrintPro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catrige")]
    public partial class Catrige
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Catrige()
        {
            CatrigeExtraditions = new HashSet<CatrigeExtradition>();
        }

        public int CatrigeID { get; set; }

        [StringLength(30)]
        public string SerialNamber { get; set; }

        public int? CatrigeModelID { get; set; }

        public int CatrigeStatusID { get; set; }

        public virtual CatrigeModel CatrigeModel { get; set; }

        public virtual CatrigeStatu CatrigeStatu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CatrigeExtradition> CatrigeExtraditions { get; set; }
    }
}
