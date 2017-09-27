namespace One_To_Many.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class b4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Singh.Standards", "Description", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("Singh.Standards", "Description", c => c.String());
        }
    }
}
