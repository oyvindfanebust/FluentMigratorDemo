using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentMigrator.Runner.Extensions;
using FluentMigrator;

namespace DatabaseProject.Migrations
{
    //SetExistingRowsTo - Extension for SQL Server

    [Migration(4, "Add not null column")]
    public class AddNotNullableColumnToCustomerTable : Migration
    {
        public override void Up()
        {
            Alter.Table("Customer").AddColumn("Title").AsString(20)
                .SetExistingRowsTo("Unknown").NotNullable();
        }

        public override void Down()
        {
            Delete.Column("Title").FromTable("Customer");
        }
    }
}
