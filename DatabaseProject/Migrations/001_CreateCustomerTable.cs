using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentMigrator.Runner.Extensions;
using FluentMigrator;
using DatabaseProject.Model;

namespace DatabaseProject.Migrations
{
    //Standard Migration, med Up og Down

    [Migration(1, "Create Customer table")]
    public class CreateCustomerTable : Migration
    {
        public override void Up()
        {
            Create.Table("Customer")
                .WithColumn("Id").AsInt32().PrimaryKey("PK_Customer").Identity(1, 1)
                .WithColumn("Name").AsString(255).NotNullable()
                .WithColumn("Created").AsDateTime().NotNullable()
                    .WithDefault(SystemMethods.CurrentDateTime)
                .WithColumn("Modified").AsDateTime().Nullable();

            Insert.IntoTable("Customer").WithIdentityInsert()
                .Row(new Customer() { 
                    Id = 1, 
                    Name = "Customer", 
                    Created = new DateTime(2014, 01, 01)
                });
        }

        public override void Down()
        {
            Delete.Table("Customer");
        }
    }
}
