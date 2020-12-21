namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Thuocs", "tenThuoc", c => c.Int(nullable: false));
            AddColumn("dbo.Thuocs", "donVi", c => c.String());
            AddColumn("dbo.KhachHangs", "soDienThoai", c => c.String());
            AddColumn("dbo.LeTans", "soCMND", c => c.String());
            DropColumn("dbo.Thuocs", "donThuoc");
            DropColumn("dbo.KhachHangs", "soCMND");
        }
        
        public override void Down()
        {
            AddColumn("dbo.KhachHangs", "soCMND", c => c.String());
            AddColumn("dbo.Thuocs", "donThuoc", c => c.Int(nullable: false));
            DropColumn("dbo.LeTans", "soCMND");
            DropColumn("dbo.KhachHangs", "soDienThoai");
            DropColumn("dbo.Thuocs", "donVi");
            DropColumn("dbo.Thuocs", "tenThuoc");
        }
    }
}
