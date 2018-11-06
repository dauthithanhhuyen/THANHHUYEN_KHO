namespace InventoryManage.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyContext : DbContext
    {
        public MyContext()
            : base("name=MyContext")
        {
        }

        public virtual DbSet<BillExport> BillExports { get; set; }
        public virtual DbSet<BillImport> BillImports { get; set; }
        public virtual DbSet<Company> Companys { get; set; }
        public virtual DbSet<Custom> Customs { get; set; }
        public virtual DbSet<DetailExport> DetailExports { get; set; }
        public virtual DbSet<DetailImport> DetailImports { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Storekeeper> Storekeepers { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BillExport>()
                .Property(e => e.NameCustom)
                .IsUnicode(false);

            modelBuilder.Entity<BillExport>()
                .HasMany(e => e.DetailExports)
                .WithRequired(e => e.BillExport)
                .HasForeignKey(e => e.IDBill)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BillImport>()
                .Property(e => e.NameCustom)
                .IsUnicode(false);

            modelBuilder.Entity<BillImport>()
                .HasMany(e => e.DetailImports)
                .WithRequired(e => e.BillImport)
                .HasForeignKey(e => e.IDBill)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Ad)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.BillImports)
                .WithOptional(e => e.Company)
                .HasForeignKey(e => e.IDCompany);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.Company)
                .HasForeignKey(e => e.IdCom);

            modelBuilder.Entity<Custom>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Custom>()
                .Property(e => e.Ad)
                .IsUnicode(false);

            modelBuilder.Entity<Custom>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Custom>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Custom>()
                .HasMany(e => e.BillExports)
                .WithOptional(e => e.Custom)
                .HasForeignKey(e => e.IDCustom);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.DetailExports)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.IDProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.DetailImports)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.IDProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Storekeeper>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Storekeeper>()
                .Property(e => e.Ad)
                .IsUnicode(false);

            modelBuilder.Entity<Storekeeper>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Storekeeper>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Storekeeper>()
                .HasMany(e => e.BillExports)
                .WithOptional(e => e.Storekeeper)
                .HasForeignKey(e => e.IDStoreKeeper);

            modelBuilder.Entity<Storekeeper>()
                .HasMany(e => e.BillImports)
                .WithOptional(e => e.Storekeeper)
                .HasForeignKey(e => e.IDStoreKeeper);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Pass)
                .IsUnicode(false);
        }
    }
}
