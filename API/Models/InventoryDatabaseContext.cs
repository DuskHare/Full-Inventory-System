using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace API.Models
{
    public partial class InventoryDatabaseContext : DbContext
    {
        public InventoryDatabaseContext()
        {
        }

        public InventoryDatabaseContext(DbContextOptions<InventoryDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CustomerTable> CustomerTable { get; set; }
        public virtual DbSet<ItemTable> ItemTable { get; set; }
        public virtual DbSet<SupplierTable> SupplierTable { get; set; }
        public virtual DbSet<UserTable> UserTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=SHAVEEN\\MSSQLSERVER01;Database=InventoryDatabase;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerTable>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.Property(e => e.CustomerAddress).HasMaxLength(50);

                entity.Property(e => e.CustomerEmail).HasMaxLength(50);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerTelephone).HasMaxLength(50);
            });

            modelBuilder.Entity<ItemTable>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SupplierTable>(entity =>
            {
                entity.HasKey(e => e.SupplierId);

                entity.Property(e => e.SupplierAddress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SupplierEmail)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SupplierName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SupplierTelephone)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserTable>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}
