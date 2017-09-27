namespace One_To_Many.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class b2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Singh.Stuus", "StudentName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("Singh.Stuus", "StudentName", c => c.String());
        }
    }
}
