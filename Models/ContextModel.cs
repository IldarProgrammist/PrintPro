namespace PrintPro.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContextModel : DbContext
    {
        public ContextModel()
            : base("name=ContextModel")
        {
        }

        public virtual DbSet<Catrige> Catriges { get; set; }
        public virtual DbSet<CatrigeExtradition> CatrigeExtraditions { get; set; }
        public virtual DbSet<CatrigeModel> CatrigeModels { get; set; }
        public virtual DbSet<CatrigeStatu> CatrigeStatus { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Printer> Printers { get; set; }
        public virtual DbSet<PrinterFirm> PrinterFirms { get; set; }
        public virtual DbSet<PrinterLocation> PrinterLocations { get; set; }
        public virtual DbSet<PrinterModel> PrinterModels { get; set; }
        public virtual DbSet<PrinterStatu> PrinterStatus { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatrigeStatu>()
                .HasMany(e => e.Catriges)
                .WithRequired(e => e.CatrigeStatu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PrinterFirm>()
                .HasMany(e => e.PrinterModels)
                .WithOptional(e => e.PrinterFirm)
                .HasForeignKey(e => e.PrinterFirmID);

            modelBuilder.Entity<PrinterLocation>()
                .HasMany(e => e.Printers)
                .WithOptional(e => e.PrinterLocation)
                .HasForeignKey(e => e.PrinterLocarionID);
        }
    }
}
