namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PhieuKhams", "ghiChu");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PhieuKhams", "ghiChu", c => c.String());
        }
    }
}
