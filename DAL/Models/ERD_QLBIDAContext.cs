using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Models
{
    public partial class ERD_QLBIDAContext : DbContext
    {
        public ERD_QLBIDAContext()
        {
        }

        public ERD_QLBIDAContext(DbContextOptions<ERD_QLBIDAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BanBium> BanBiAs { get; set; } = null!;
        public virtual DbSet<ChucVu> ChucVus { get; set; } = null!;
        public virtual DbSet<DichVu> DichVus { get; set; } = null!;
        public virtual DbSet<DichVuDb> DichVuDbs { get; set; } = null!;
        public virtual DbSet<GayBium> GayBiAs { get; set; } = null!;
        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<HoaDonCt> HoaDonCts { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; } = null!;
        public virtual DbSet<LoaiDichVuDb> LoaiDichVuDbs { get; set; } = null!;
        public virtual DbSet<MemBerShip> MemBerShips { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<Partner> Partners { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=THANHTONG\\SQLEXPRESS01;Database=ERD_QLBIDA;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BanBium>(entity =>
            {
                entity.HasKey(e => e.IdbanBiA)
                    .HasName("PK__BanBiA__B5388939759FFAA1");

                entity.ToTable("BanBiA");

                entity.Property(e => e.IdbanBiA).HasColumnName("IDBanBiA");

                entity.Property(e => e.CapBanBiA).HasMaxLength(50);

                entity.Property(e => e.DonGia).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LoaiBanBiA).HasMaxLength(50);

                entity.Property(e => e.TenBanBiA).HasMaxLength(100);
            });

            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.HasKey(e => e.IdchucVu)
                    .HasName("PK__ChucVu__70FCCF652F8948F4");

                entity.ToTable("ChucVu");

                entity.HasIndex(e => e.TenChucVu, "UQ__ChucVu__A7E2123E93F52493")
                    .IsUnique();

                entity.Property(e => e.IdchucVu).HasColumnName("IDChucVu");

                entity.Property(e => e.TenChucVu).HasMaxLength(50);
            });

            modelBuilder.Entity<DichVu>(entity =>
            {
                entity.HasKey(e => e.IddichVu)
                    .HasName("PK__DichVu__C0C95928853B4303");

                entity.ToTable("DichVu");

                entity.Property(e => e.IddichVu).HasColumnName("IDDichVu");

                entity.Property(e => e.DonGia).HasColumnType("money");

                entity.Property(e => e.IdbanBiA).HasColumnName("IDBanBiA");

                entity.Property(e => e.IdgayBiA).HasColumnName("IDGayBiA");

                entity.Property(e => e.Idpartner).HasColumnName("IDPartner");

                entity.HasOne(d => d.IdbanBiANavigation)
                    .WithMany(p => p.DichVus)
                    .HasForeignKey(d => d.IdbanBiA)
                    .HasConstraintName("FK__DichVu__IDBanBiA__4D94879B");

                entity.HasOne(d => d.IdgayBiANavigation)
                    .WithMany(p => p.DichVus)
                    .HasForeignKey(d => d.IdgayBiA)
                    .HasConstraintName("FK__DichVu__IDGayBiA__4F7CD00D");

                entity.HasOne(d => d.IdpartnerNavigation)
                    .WithMany(p => p.DichVus)
                    .HasForeignKey(d => d.Idpartner)
                    .HasConstraintName("FK__DichVu__IDPartne__4E88ABD4");
            });

            modelBuilder.Entity<DichVuDb>(entity =>
            {
                entity.HasKey(e => e.IddichVuDb)
                    .HasName("PK__DichVuDB__64ECF545101EA04B");

                entity.ToTable("DichVuDB");

                entity.Property(e => e.IddichVuDb).HasColumnName("IDDichVuDB");

                entity.Property(e => e.DonGia).HasColumnType("money");

                entity.Property(e => e.IdloaiDichVu).HasColumnName("IDLoaiDichVu");

                entity.Property(e => e.MoTa).HasColumnType("text");

                entity.Property(e => e.TenDichVuDb)
                    .HasMaxLength(100)
                    .HasColumnName("TenDichVuDB");

                entity.HasOne(d => d.IdloaiDichVuNavigation)
                    .WithMany(p => p.DichVuDbs)
                    .HasForeignKey(d => d.IdloaiDichVu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DichVuDB__IDLoai__5441852A");
            });

            modelBuilder.Entity<GayBium>(entity =>
            {
                entity.HasKey(e => e.IdgayBiA)
                    .HasName("PK__GayBiA__06BA0D8BABA9E163");

                entity.ToTable("GayBiA");

                entity.Property(e => e.IdgayBiA).HasColumnName("IDGayBiA");

                entity.Property(e => e.DonGia).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LoaiGayBiA).HasMaxLength(50);

                entity.Property(e => e.TenGayBiA).HasMaxLength(100);
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.IdhoaDon)
                    .HasName("PK__HoaDon__5B896F49D4C4FF3F");

                entity.ToTable("HoaDon");

                entity.Property(e => e.IdhoaDon).HasColumnName("IDHoaDon");

                entity.Property(e => e.IdkhachHang).HasColumnName("IDKhachHang");

                entity.Property(e => e.IdkhuyenMai).HasColumnName("IDKhuyenMai");

                entity.Property(e => e.NgayTao).HasColumnType("date");

                entity.Property(e => e.TongTien).HasColumnType("money");

                entity.HasOne(d => d.IdkhachHangNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdkhachHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon__IDKhachH__44FF419A");

                entity.HasOne(d => d.IdkhuyenMaiNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdkhuyenMai)
                    .HasConstraintName("FK__HoaDon__IDKhuyen__440B1D61");
            });

            modelBuilder.Entity<HoaDonCt>(entity =>
            {
                entity.HasKey(e => e.IdhoaDonCt)
                    .HasName("PK__HoaDonCT__C9D2C4D7C51F2E87");

                entity.ToTable("HoaDonCT");

                entity.Property(e => e.IdhoaDonCt).HasColumnName("IDHoaDonCT");

                entity.Property(e => e.GhiChu).HasColumnType("text");

                entity.Property(e => e.IddichVu).HasColumnName("IDDichVu");

                entity.Property(e => e.IddichVuDb).HasColumnName("IDDichVuDB");

                entity.Property(e => e.IdhoaDon).HasColumnName("IDHoaDon");

                entity.Property(e => e.ThoiGianBatDau).HasColumnType("datetime");

                entity.Property(e => e.ThoiGianKetThuc).HasColumnType("datetime");

                entity.Property(e => e.TongTien).HasColumnType("money");

                entity.HasOne(d => d.IddichVuNavigation)
                    .WithMany(p => p.HoaDonCts)
                    .HasForeignKey(d => d.IddichVu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDonCT__IDDich__571DF1D5");

                entity.HasOne(d => d.IddichVuDbNavigation)
                    .WithMany(p => p.HoaDonCts)
                    .HasForeignKey(d => d.IddichVuDb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDonCT__IDDich__5812160E");

                entity.HasOne(d => d.IdhoaDonNavigation)
                    .WithMany(p => p.HoaDonCts)
                    .HasForeignKey(d => d.IdhoaDon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDonCT__IDHoaD__59063A47");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.IdkhachHang)
                    .HasName("PK__KhachHan__5A7167B5E32F2449");

                entity.ToTable("KhachHang");

                entity.Property(e => e.IdkhachHang).HasColumnName("IDKhachHang");

                entity.Property(e => e.DiaChi).HasMaxLength(100);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HoVaTen).HasMaxLength(50);

                entity.Property(e => e.IdmemBerShip).HasColumnName("IDMemBerShip");

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdmemBerShipNavigation)
                    .WithMany(p => p.KhachHangs)
                    .HasForeignKey(d => d.IdmemBerShip)
                    .HasConstraintName("FK__KhachHang__IDMem__3E52440B");
            });

            modelBuilder.Entity<KhuyenMai>(entity =>
            {
                entity.HasKey(e => e.IdkhuyenMai)
                    .HasName("PK__KhuyenMa__FFAC1400C54CA068");

                entity.ToTable("KhuyenMai");

                entity.HasIndex(e => e.TenKhuyenMai, "UQ__KhuyenMa__A956B87CB8D45DC6")
                    .IsUnique();

                entity.Property(e => e.IdkhuyenMai).HasColumnName("IDKhuyenMai");

                entity.Property(e => e.GhiChu).HasMaxLength(100);

                entity.Property(e => e.NgayHetHan).HasColumnType("date");

                entity.Property(e => e.NgayTao).HasColumnType("date");

                entity.Property(e => e.TenKhuyenMai).HasMaxLength(100);

                entity.Property(e => e.TrangThai).HasMaxLength(50);
            });

            modelBuilder.Entity<LoaiDichVuDb>(entity =>
            {
                entity.HasKey(e => e.IdloaiDichVuDb)
                    .HasName("PK__LoaiDich__3E0AA889690CAE7C");

                entity.ToTable("LoaiDichVuDB");

                entity.Property(e => e.IdloaiDichVuDb).HasColumnName("IDLoaiDichVuDB");

                entity.Property(e => e.MoTa).HasColumnType("text");

                entity.Property(e => e.TenLoaiDichVuDb)
                    .HasMaxLength(100)
                    .HasColumnName("TenLoaiDichVuDB");
            });

            modelBuilder.Entity<MemBerShip>(entity =>
            {
                entity.HasKey(e => e.IdmemBerShip)
                    .HasName("PK__MemBerSh__9A18A2434738875C");

                entity.ToTable("MemBerShip");

                entity.Property(e => e.IdmemBerShip).HasColumnName("IDMemBerShip");

                entity.Property(e => e.LoaiTheThanhVien).HasMaxLength(30);

                entity.Property(e => e.NgayGiaNhap).HasColumnType("date");

                entity.Property(e => e.NgayHetHan).HasColumnType("date");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.IdnhanVien)
                    .HasName("PK__NhanVien__7AC2D9F7F4B9FF3A");

                entity.ToTable("NhanVien");

                entity.Property(e => e.IdnhanVien).HasColumnName("IDNhanVien");

                entity.Property(e => e.DiaChi).HasMaxLength(100);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdchucVu).HasColumnName("IDChucVu");

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TenDangNhap)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrangThai).HasMaxLength(50);

                entity.HasOne(d => d.IdchucVuNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.IdchucVu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NhanVien__IDChuc__398D8EEE");
            });

            modelBuilder.Entity<Partner>(entity =>
            {
                entity.HasKey(e => e.Idpartner)
                    .HasName("PK__Partner__C86253DCE66B281E");

                entity.ToTable("Partner");

                entity.Property(e => e.Idpartner).HasColumnName("IDPartner");

                entity.Property(e => e.DonGia).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LoaiPartner).HasMaxLength(50);

                entity.Property(e => e.TenPatrner).HasMaxLength(100);

                entity.Property(e => e.TrangThai).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
