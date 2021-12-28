using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QlyHocBa.DAL
{
    public partial class HocBaModel : DbContext
    {
        public HocBaModel()
            : base("name=HocBaModel")
        {
        }

        public virtual DbSet<DiemThi> DiemThis { get; set; }
        public virtual DbSet<HocSinh> HocSinhs { get; set; }
        public virtual DbSet<KetQua> KetQuas { get; set; }
        public virtual DbSet<LopHoc> LopHocs { get; set; }
        public virtual DbSet<MonHoc> MonHocs { get; set; }
        public virtual DbSet<NamHoc> NamHocs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiemThi>()
                .Property(e => e.MonHocID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DiemThi>()
                .Property(e => e.NamHocID)
                .IsFixedLength();

            modelBuilder.Entity<HocSinh>()
                .HasMany(e => e.DiemThis)
                .WithRequired(e => e.HocSinh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HocSinh>()
                .HasMany(e => e.KetQuas)
                .WithRequired(e => e.HocSinh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KetQua>()
                .Property(e => e.NamHocID)
                .IsFixedLength();

            modelBuilder.Entity<LopHoc>()
                .HasMany(e => e.KetQuas)
                .WithRequired(e => e.LopHoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonHoc>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MonHoc>()
                .HasMany(e => e.DiemThis)
                .WithRequired(e => e.MonHoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NamHoc>()
                .Property(e => e.ID)
                .IsFixedLength();

            modelBuilder.Entity<NamHoc>()
                .HasMany(e => e.DiemThis)
                .WithRequired(e => e.NamHoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NamHoc>()
                .HasMany(e => e.KetQuas)
                .WithRequired(e => e.NamHoc)
                .WillCascadeOnDelete(false);
        }
    }
}
