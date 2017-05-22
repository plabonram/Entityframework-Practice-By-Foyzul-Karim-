namespace ZooApp.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSomeDataToAnimal : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into animals values('Cow','Grash','Everywhere',2)");
        }
        
        public override void Down()
        {
        }
    }
}
