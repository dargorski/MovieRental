namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddValuesToNameColumnInMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes set NAME = 'Pay as You Go' where Id = 1");
            Sql("UPDATE MembershipTypes set NAME = 'Monthly' where Id = 2");
            Sql("UPDATE MembershipTypes set NAME = 'Quarterly' where Id = 3");
            Sql("UPDATE MembershipTypes set NAME = 'Yearly' where Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
