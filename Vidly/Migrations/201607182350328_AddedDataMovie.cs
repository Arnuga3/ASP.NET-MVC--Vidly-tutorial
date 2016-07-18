namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDataMovie : DbMigration
    {
        public override void Up()
        {
            var date = DateTime.Now;

            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Hangover','Comedy','19980102',GETDATE(),5)");

        }

        public override void Down()
        {
        }
    }
}
