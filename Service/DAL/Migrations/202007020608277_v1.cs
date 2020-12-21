namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NhaSis", "passWord", c => c.String());
            AddColumn("dbo.LeTans", "passWord", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.LeTans", "passWord");
            DropColumn("dbo.NhaSis", "passWord");
        }
    }
}
