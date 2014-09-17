using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentMigrator.Runner.Extensions;
using FluentMigrator;

namespace DatabaseProject.Migrations
{
    [Migration(5, "Only in DEV INTERN")]
    [Tags("DEV")]
    [Tags("INTERN")]
    public class OnlyInDevIntern : Migration
    {
        public override void Up()
        {
            Insert.IntoTable("Customer").Row(new { Name = "DEV INTERN customer", Title = "", Modified = new DateTime(2014, 01, 01) });
        }

        public override void Down()
        {
            Delete.FromTable("Customer").Row(new { Name = "DEV INTERN customer", Title = "" });
        }
    }

    [Migration(6, "Only in PROD INTERN")]
    [Tags("PROD")]
    [Tags("INTERN")]
    public class OnlyInProdIntern : Migration
    {
        public override void Up()
        {
            Insert.IntoTable("Customer").Row(new { Name = "PROD INTERN customer", Title = "", Modified = new DateTime(2014, 01, 01) });
        }

        public override void Down()
        {
            Delete.FromTable("Customer").Row(new { Name = "PROD INTERN customer", Title = "" });
        }
    }

    [Migration(7, "Only in DEV EKSTERN")]
    [Tags("DEV")]
    [Tags("EKSTERN")]
    public class OnlyInDevEkstern : Migration
    {
        public override void Up()
        {
            Insert.IntoTable("Customer").Row(new { Name = "DEV EKSTERN customer", Title = "", Modified = new DateTime(2014, 01, 01) });
        }

        public override void Down()
        {
            Delete.FromTable("Customer").Row(new { Name = "DEV EKSTERN customer", Title = "" });
        }
    }

    [Migration(8, "Only in PROD EKSTERN")]
    [Tags("PROD")]
    [Tags("EKSTERN")]
    public class OnlyInProdEkstern : Migration
    {
        public override void Up()
        {
            Insert.IntoTable("Customer").Row(new { Name = "PROD EKSTERN customer", Title = "", Modified = new DateTime(2014, 01, 01) });
        }

        public override void Down()
        {
            Delete.FromTable("Customer").Row(new { Name = "PROD EKSTERN customer", Title = "" });
        }
    }
}
