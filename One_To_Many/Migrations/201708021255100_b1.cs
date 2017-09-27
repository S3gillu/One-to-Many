namespace One_To_Many.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class b1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Singh.Standards",
                c => new
                    {
                        StandardId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.StandardId);
            
            CreateTable(
                "Singh.Stuus",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        StudentName = c.String(),
                        StandardId = c.Int(nullable: false),
                        Standard_StandardId = c.Int(),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("Singh.Standards", t => t.StandardId, cascadeDelete: true)
                .ForeignKey("Singh.Standards", t => t.Standard_StandardId)
                .Index(t => t.StandardId)
                .Index(t => t.Standard_StandardId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Singh.Stuus", "Standard_StandardId", "Singh.Standards");
            DropForeignKey("Singh.Stuus", "StandardId", "Singh.Standards");
            DropIndex("Singh.Stuus", new[] { "Standard_StandardId" });
            DropIndex("Singh.Stuus", new[] { "StandardId" });
            DropTable("Singh.Stuus");
            DropTable("Singh.Standards");
        }
    }
}
