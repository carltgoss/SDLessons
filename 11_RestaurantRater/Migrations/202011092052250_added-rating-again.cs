namespace _11_RestaurantRater.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedratingagain : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Ratings", name: "RetaurantId", newName: "RestaurantId");
            RenameIndex(table: "dbo.Ratings", name: "IX_RetaurantId", newName: "IX_RestaurantId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Ratings", name: "IX_RestaurantId", newName: "IX_RetaurantId");
            RenameColumn(table: "dbo.Ratings", name: "RestaurantId", newName: "RetaurantId");
        }
    }
}
