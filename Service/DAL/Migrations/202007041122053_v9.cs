namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v9 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ChiTietDonThuocs", "cachDungThuoc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ChiTietDonThuocs", "cachDungThuoc", c => c.String());
        }
    }
}
