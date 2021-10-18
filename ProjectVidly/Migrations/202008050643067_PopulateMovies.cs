namespace ProjectVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            //Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES (1, 'Princess Mononoke', 6, 8/4/2020, 12/19/1997, 2)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Pulp Fiction', 1, 8/5/2020, 10/14/1994, 4)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Predator 2', 2, 8/5/2020, 11/21/1990, 3)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('The Terminator', 1, 8/5/2020, 8/26/1984,6)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('The Hangover', 5, 8/5/2020, 11/6/2009, 5)");
        }
        
        public override void Down()
        {
        }
    }
}
