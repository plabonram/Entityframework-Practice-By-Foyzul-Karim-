namespace EntityframeworkPracticeByFoyzulKarim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnimalClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Food = c.String(nullable: false, maxLength: 255),
                        Origin = c.String(nullable: false, maxLength: 255),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Animals");
        }
    }
}
