using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentMigrator.Runner.Extensions;
using FluentMigrator;

namespace DatabaseProject.Migrations
{
    [Migration(9, "SQL")]
    public class SQL : Migration
    {
        public override void Up()
        {
            Execute.Sql("CREATE PROCEDURE sp_getdate AS BEGIN SELECT GETDATE() END");
            
            Execute.Script("Scripts\\up_script.sql");
            
            Execute.EmbeddedScript("up_script_embedded.sql");
        }

        public override void Down()
        {
            Execute.EmbeddedScript("down_script_embedded.sql");
            
            Execute.Script("Scripts\\down_script.sql");
            
            Execute.Sql("DROP PROCEDURE sp_getdate");            
        }
    }
}
