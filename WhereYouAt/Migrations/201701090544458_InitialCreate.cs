namespace WhereYouAt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        StreetAddress = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.Int(nullable: false),
                        ArriveTime = c.DateTime(nullable: false),
                        DeliveryItem1 = c.String(),
                        DeliveryItem1Serial = c.Int(),
                        DeliveryItem2 = c.String(),
                        DeliveryItem2Serial = c.Int(),
                        DeliveryItem3 = c.String(),
                        DeliveryItem3Serial = c.Int(),
                        DeliveryItem4 = c.String(),
                        DeliveryItem4Serial = c.Int(),
                        DeliveryNotes = c.String(),
                        DepartTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Orders");
        }
    }
}
