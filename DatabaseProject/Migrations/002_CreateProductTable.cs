using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentMigrator.Runner.Extensions;
using FluentMigrator;
using DatabaseProject.Model;

namespace DatabaseProject.Migrations
{
    //AutoReverse migration, FluentMigrator genererer automatisk Down()

    [Migration(2, "Create Product table")]
    public class CreateProductTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Product")
                .WithColumn("Id").AsInt32().PrimaryKey("PK_Product").Identity(1, 1)
                .WithColumn("Name").AsString(20).NotNullable()
                .WithColumn("Created").AsDateTime().NotNullable().WithDefault(SystemMethods.CurrentDateTime)
                .WithColumn("Modified").AsDateTime().Nullable();

            Insert.IntoTable("Product").WithIdentityInsert().Row(new Product() { Id = 1, Name = "Product1", Created = new DateTime(2014, 01, 01) });
            Insert.IntoTable("Product").WithIdentityInsert().Row(new Product() { Id = 2, Name = "Product2", Created = new DateTime(2014, 01, 01) });
        }
    }
}
