namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiTietDonThuocs",
                c => new
                    {
                        idDonThuoc = c.String(nullable: false, maxLength: 128),
                        idDV = c.String(nullable: false, maxLength: 128),
                        idThuoc = c.String(maxLength: 128),
                        soLuong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.idDonThuoc, t.idDV })
                .ForeignKey("dbo.DichVuPhongKhams", t => t.idDV, cascadeDelete: true)
                .ForeignKey("dbo.DonThuocs", t => t.idDonThuoc, cascadeDelete: true)
                .ForeignKey("dbo.Thuocs", t => t.idThuoc)
                .Index(t => t.idDonThuoc)
                .Index(t => t.idDV)
                .Index(t => t.idThuoc);
            
            CreateTable(
                "dbo.DichVuPhongKhams",
                c => new
                    {
                        idDV = c.String(nullable: false, maxLength: 128),
                        tenDV = c.String(),
                        donGia = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.idDV);
            
            CreateTable(
                "dbo.DonThuocs",
                c => new
                    {
                        idPhieuKham = c.String(maxLength: 128),
                        idNhaSi = c.String(maxLength: 128),
                        idDonThuoc = c.String(nullable: false, maxLength: 128),
                        ngayLap = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.idDonThuoc)
                .ForeignKey("dbo.NhaSis", t => t.idNhaSi)
                .ForeignKey("dbo.PhieuKhams", t => t.idPhieuKham)
                .Index(t => t.idPhieuKham)
                .Index(t => t.idNhaSi);
            
            CreateTable(
                "dbo.NhaSis",
                c => new
                    {
                        idNhaSi = c.String(nullable: false, maxLength: 128),
                        tenNhaSi = c.String(),
                        soCMND = c.String(),
                        diaChi = c.String(),
                        gioiTinh = c.Boolean(nullable: false),
                        ngaySinh = c.DateTime(nullable: false),
                        soDienThoai = c.String(),
                    })
                .PrimaryKey(t => t.idNhaSi);
            
            CreateTable(
                "dbo.PhieuKhams",
                c => new
                    {
                        idPhieuKham = c.String(nullable: false, maxLength: 128),
                        ngayDKKham = c.DateTime(nullable: false),
                        moTa = c.String(),
                        ghiChu = c.String(),
                        tinhTrang = c.Boolean(nullable: false),
                        idNV = c.String(maxLength: 128),
                        idKH = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.idPhieuKham)
                .ForeignKey("dbo.KhachHangs", t => t.idKH)
                .ForeignKey("dbo.LeTans", t => t.idNV)
                .Index(t => t.idNV)
                .Index(t => t.idKH);
            
            CreateTable(
                "dbo.Thuocs",
                c => new
                    {
                        idThuoc = c.String(nullable: false, maxLength: 128),
                        donThuoc = c.String(),
                        donGia = c.Double(nullable: false),
                        moTa = c.String(),
                    })
                .PrimaryKey(t => t.idThuoc);
            
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        idKH = c.String(nullable: false, maxLength: 128),
                        tenKH = c.String(),
                        diaChi = c.String(),
                        soCMND = c.String(),
                        ngaySinh = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.idKH);
            
            CreateTable(
                "dbo.LeTans",
                c => new
                    {
                        idNV = c.String(nullable: false, maxLength: 128),
                        tenNV = c.String(),
                        diaChi = c.String(),
                        ngaySinh = c.DateTime(nullable: false),
                        gioiTinh = c.Boolean(nullable: false),
                        soDienThoai = c.String(),
                    })
                .PrimaryKey(t => t.idNV);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PhieuKhams", "idNV", "dbo.LeTans");
            DropForeignKey("dbo.PhieuKhams", "idKH", "dbo.KhachHangs");
            DropForeignKey("dbo.ChiTietDonThuocs", "idThuoc", "dbo.Thuocs");
            DropForeignKey("dbo.ChiTietDonThuocs", "idDonThuoc", "dbo.DonThuocs");
            DropForeignKey("dbo.DonThuocs", "idPhieuKham", "dbo.PhieuKhams");
            DropForeignKey("dbo.DonThuocs", "idNhaSi", "dbo.NhaSis");
            DropForeignKey("dbo.ChiTietDonThuocs", "idDV", "dbo.DichVuPhongKhams");
            DropIndex("dbo.PhieuKhams", new[] { "idKH" });
            DropIndex("dbo.PhieuKhams", new[] { "idNV" });
            DropIndex("dbo.DonThuocs", new[] { "idNhaSi" });
            DropIndex("dbo.DonThuocs", new[] { "idPhieuKham" });
            DropIndex("dbo.ChiTietDonThuocs", new[] { "idThuoc" });
            DropIndex("dbo.ChiTietDonThuocs", new[] { "idDV" });
            DropIndex("dbo.ChiTietDonThuocs", new[] { "idDonThuoc" });
            DropTable("dbo.LeTans");
            DropTable("dbo.KhachHangs");
            DropTable("dbo.Thuocs");
            DropTable("dbo.PhieuKhams");
            DropTable("dbo.NhaSis");
            DropTable("dbo.DonThuocs");
            DropTable("dbo.DichVuPhongKhams");
            DropTable("dbo.ChiTietDonThuocs");
        }
    }
}
