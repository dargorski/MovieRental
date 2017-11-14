namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2026e39d-1438-4307-bd74-c6dc656a4b46', N'admin@movierental.com', 0, N'AFoBOV0qo6D+DgabPTXydx8ynrBRnXXcaQ4DHSvVVLezUnNZKC/8r7ht/AyW+7rkXA==', N'1d795cd1-e291-47d0-ba8f-83d39e5de4a7', NULL, 0, 0, NULL, 1, 0, N'admin@movierental.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5e5b2b21-a959-4241-b27f-60cec2935091', N'guest@movierental.com', 0, N'AKzH7Mdf83kY4A80v8hWgbWedYjriHp9ctaU/ks0BwQnt/+B9DwEXWhdUiVU1uDDqA==', N'655bbee7-dc16-4d85-bf21-e56c1cb353de', NULL, 0, 0, NULL, 1, 0, N'guest@movierental.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'bb338126-f452-4f35-944a-7159571a0bbf', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2026e39d-1438-4307-bd74-c6dc656a4b46', N'bb338126-f452-4f35-944a-7159571a0bbf')
");
        }
        
        public override void Down()
        {
        }
    }
}
