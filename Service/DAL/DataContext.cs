using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.CodeFirst;

namespace DAL
{
    public class DataContext:DbContext
    {
        public DataContext() : base("QuanLyPhongNhaString")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ChiTietDonThuoc> chitietdonthuocs { get; set; }
        public DbSet<DichVuPhongKham> dichvus { get; set; }
        public DbSet<DonThuoc> donthuocs { get; set; }
        public DbSet<KhachHang> khachhangs { get; set; }
        public DbSet<LeTan> letans { get; set; }
        public DbSet<NhaSi> nhasis { get; set; }
        public DbSet<PhieuKham> phieukhams { get; set; }
        public DbSet<Thuoc> thuocs { get; set; }
    }
}
