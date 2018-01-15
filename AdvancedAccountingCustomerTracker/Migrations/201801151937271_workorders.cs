namespace AdvancedAccountingCustomerTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class workorders : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accountants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WorkOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountantId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        Summary = c.String(nullable: false, maxLength: 255),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accountants", t => t.AccountantId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.AccountantId)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkOrders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.WorkOrders", "AccountantId", "dbo.Accountants");
            DropIndex("dbo.WorkOrders", new[] { "CustomerId" });
            DropIndex("dbo.WorkOrders", new[] { "AccountantId" });
            DropTable("dbo.WorkOrders");
            DropTable("dbo.Accountants");
        }
    }
}
