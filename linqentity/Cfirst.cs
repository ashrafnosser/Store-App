using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace linqentity
{
    public partial class Cfirst : DbContext
    {
        public Cfirst()
            : base("name=Cfirst")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<DismissalPermission> DismissalPermissions { get; set; }
        public virtual DbSet<store> stores { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<supplyPermession> supplyPermessions { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<transform> transforms { get; set; }
        public virtual DbSet<Variety> Varieties { get; set; }
        public virtual DbSet<Varieties_Dismissalpermessions> Varieties_Dismissalpermessions { get; set; }
        public virtual DbSet<Varieties_supplypermessions> Varieties_supplypermessions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DismissalPermission>()
                .Property(e => e.Storename)
                .IsUnicode(false);

            modelBuilder.Entity<DismissalPermission>()
                .Property(e => e.supplieName)
                .IsUnicode(false);

            modelBuilder.Entity<DismissalPermission>()
                .HasMany(e => e.Varieties_Dismissalpermessions)
                .WithRequired(e => e.DismissalPermission)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<store>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<store>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<store>()
                .Property(e => e.admnistrator)
                .IsUnicode(false);

            modelBuilder.Entity<supplyPermession>()
                .Property(e => e.Storename)
                .IsUnicode(false);

            modelBuilder.Entity<supplyPermession>()
                .Property(e => e.supplieName)
                .IsUnicode(false);

            modelBuilder.Entity<supplyPermession>()
                .HasMany(e => e.Varieties_supplypermessions)
                .WithRequired(e => e.supplyPermession)
                .HasForeignKey(e => e.SupplyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<transform>()
                .Property(e => e.sfrom)
                .IsUnicode(false);

            modelBuilder.Entity<transform>()
                .Property(e => e.sto)
                .IsUnicode(false);

            modelBuilder.Entity<transform>()
                .Property(e => e.supplier)
                .IsUnicode(false);

            modelBuilder.Entity<Variety>()
                .Property(e => e.vName)
                .IsUnicode(false);

            modelBuilder.Entity<Variety>()
                .Property(e => e.measruingUnit)
                .IsUnicode(false);
        }
    }
}
