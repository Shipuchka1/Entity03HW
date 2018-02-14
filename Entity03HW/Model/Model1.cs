namespace Entity03HW.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }
        public virtual DbSet<Equipment> Equipments { get; set; }
        public virtual DbSet<newEquipment> newEquipments { get; set; }
        public virtual DbSet<TableEquipmentHistory> TableEquipmentHistories { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<TablesModel> TablesModels { get; set; }
        public virtual DbSet<Model> Models { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manufacturer>()
                .HasMany(e => e.newEquipments)
                .WithRequired(e => e.Manufacturer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Manufacturer>()
                .HasMany(e => e.Equipments)
                .WithRequired(e => e.Manufacturer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TablesModel>()
                .HasMany(e => e.newEquipments)
                .WithRequired(e => e.TablesModel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Model>()
                .HasMany(e => e.Equipments)
                .WithRequired(e => e.Model)
                .WillCascadeOnDelete(false);
        }
    }
}
