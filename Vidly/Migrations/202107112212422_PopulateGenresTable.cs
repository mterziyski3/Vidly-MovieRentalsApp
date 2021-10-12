namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (TypeOfGenre) VALUES ('Romance')");
            Sql("INSERT INTO Genres (TypeOfGenre) VALUES ('Action')");
            Sql("INSERT INTO Genres (TypeOfGenre) VALUES ('Comedy')");
            Sql("INSERT INTO Genres (TypeOfGenre) VALUES ('Family')");
        }
        
        public override void Down()
        {
        }
    }
}
