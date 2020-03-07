namespace PrintPro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CatrigeExtradition")]
    public partial class CatrigeExtradition
    {
        [Key]
        public int ExtraditionID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataExtradition { get; set; }

        public int? CatrigeID { get; set; }

        public int? CatrigeStatusID { get; set; }

        public virtual Catrige Catrige { get; set; }

        public virtual CatrigeStatu CatrigeStatu { get; set; }
    }
}
