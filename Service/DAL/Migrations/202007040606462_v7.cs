namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ChiTietDonThuocs", "cachDungThuoc", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ChiTietDonThuocs", "cachDungThuoc");
        }
    }
}
