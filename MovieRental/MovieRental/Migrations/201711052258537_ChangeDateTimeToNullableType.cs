namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDateTimeToNullableType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "AddToStockDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "AddToStockDate", c => c.DateTime(nullable: false));
        }
    }
}
