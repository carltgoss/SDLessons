namespace _11_RestaurantRater.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedrating : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FoodScore = c.Double(nullable: false),
                        EnvironmentScore = c.Double(nullable: false),
                        CleanlinessScore = c.Double(nullable: false),
                        RetaurantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Restaurants", t => t.RetaurantId, cascadeDelete: true)
                .Index(t => t.RetaurantId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ratings", "RetaurantId", "dbo.Restaurants");
            DropIndex("dbo.Ratings", new[] { "RetaurantId" });
            DropTable("dbo.Ratings");
        }
    }
}
