namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteMoviesAndUpdateModels : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Movies");
        }
        
        public override void Down()
        {
        }
    }
}
