namespace ProjectScreen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Pmam = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            CreateTable(
               "dbo.Users",
               c => new
               {
                   Id = c.Int(nullable: false, identity: true),
                   UserName=c.String(nullable:false),
                   Password=c.String(nullable:false),
                   RegDate=c.String(nullable:false),
                   Email=c.String(nullable:false),
               })
               .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Projects");
        }
    }
}
