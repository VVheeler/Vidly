namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6f3cd780-1913-458b-9b35-1b41cf8b391b', N'guest@vidly.com', 0, N'AC2zBHW7EuKh88tjauAZgwepLj41OrkNWVFuSYNFgeAIXwF4wmRq5HZSbiLQ6N+9Cw==', N'23521828-c37a-459e-928e-2d5d17bf2ae6', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'af914558-6f2c-4939-9013-8cec5ff6745f', N'admin@vidly.com', 0, N'AAhy36ZsGh0G2FT37z/QLz+XiWXsqwsQoJqL8SOLei7Zbk7n9nYyW7mUA1nCL6QGJg==', N'd3ccfd89-23a9-4ce6-b175-3c56eeefeae8', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e7e74470-e5d3-4cfc-b307-38ab0e9aad9e', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'af914558-6f2c-4939-9013-8cec5ff6745f', N'e7e74470-e5d3-4cfc-b307-38ab0e9aad9e')
");
        }
        
        public override void Down()
        {
        }
    }
}
