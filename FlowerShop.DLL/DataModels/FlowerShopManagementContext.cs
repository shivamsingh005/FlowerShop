using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FlowerShop.DLL.DataModels
{
    public partial class FlowerShopManagementContext : DbContext
    {
        public FlowerShopManagementContext(DbContextOptions<FlowerShopManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Flower> Flowers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-V52HAB6; Database=FlowerShopManagement; User Id=DESKTOP-V52HAB6\\Ram; Password=; Integrated Security=True; MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flower>(entity =>
            {
                entity.ToTable("Flower");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FlowerName).HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
