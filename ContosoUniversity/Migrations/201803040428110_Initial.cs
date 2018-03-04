namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "email", c => c.String(maxLength: 50));
            AddColumn("dbo.Person", "gpa", c => c.String());
            AddColumn("dbo.Person", "CreditsEarned", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "CreditsEarned");
            DropColumn("dbo.Person", "gpa");
            DropColumn("dbo.Person", "email");
        }
    }
}
