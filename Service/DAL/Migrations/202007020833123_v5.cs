namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NhaSis", "useName", c => c.String());
            AddColumn("dbo.LeTans", "useName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.LeTans", "useName");
            DropColumn("dbo.NhaSis", "useName");
        }
    }
}
