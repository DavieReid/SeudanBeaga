namespace SeudanBeaga.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactProps : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "Name", c => c.String(maxLength: 100));
            AddColumn("dbo.Contacts", "Phone", c => c.String(maxLength: 30));
            AddColumn("dbo.Contacts", "Email", c => c.String(maxLength: 255));
            AddColumn("dbo.Contacts", "HouseNum", c => c.String(maxLength: 10));
            AddColumn("dbo.Contacts", "Street", c => c.String(maxLength: 255));
            AddColumn("dbo.Contacts", "City", c => c.String(maxLength: 255));
            AddColumn("dbo.Contacts", "PostCode", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "PostCode");
            DropColumn("dbo.Contacts", "City");
            DropColumn("dbo.Contacts", "Street");
            DropColumn("dbo.Contacts", "HouseNum");
            DropColumn("dbo.Contacts", "Email");
            DropColumn("dbo.Contacts", "Phone");
            DropColumn("dbo.Contacts", "Name");
        }
    }
}
