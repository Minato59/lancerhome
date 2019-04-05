namespace lancerhome.database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initailized : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Class1",
                c => new
                    {
                        iD = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.iD);
            
            CreateTable(
                "dbo.products",
                c => new
                    {
                        iD = c.Int(nullable: false, identity: true),
                        prize = c.Decimal(nullable: false, precision: 18, scale: 2),
                        name = c.String(),
                        Description = c.String(),
                        category_iD = c.Int(),
                    })
                .PrimaryKey(t => t.iD)
                .ForeignKey("dbo.Class1", t => t.category_iD)
                .Index(t => t.category_iD);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.products", "category_iD", "dbo.Class1");
            DropIndex("dbo.products", new[] { "category_iD" });
            DropTable("dbo.products");
            DropTable("dbo.Class1");
        }
    }
}
