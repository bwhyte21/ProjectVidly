namespace ProjectVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'28f374f2-f566-4754-94c7-426fa9ea404a', N'guest@vidly.com', 0, N'AHOUrhOEImZpo3EM9LCzA0AlUNdYELDYb5rb9gEWRmCTwji9gWFgO6d+ybuVcBxFCQ==', N'91fc541e-0d29-4916-9346-30f918c4d020', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd88522fe-b137-43c6-94b9-0460e3523b79', N'admin@vidly.com', 0, N'ANIZbHqPrxxKqkY8dEdnNkXJ7f4PfnK2sBcGAla9nITc/G2ggRWnLz7wZB8Qxr7kaw==', N'd6ee20ed-04db-48ba-8a37-d93d420763e3', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'bc0ae509-2d09-401d-8154-3ee9d4cc340a', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd88522fe-b137-43c6-94b9-0460e3523b79', N'bc0ae509-2d09-401d-8154-3ee9d4cc340a')

");
        }

        public override void Down() { }
    }
}