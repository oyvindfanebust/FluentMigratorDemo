using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentMigrator.Runner.Extensions;
using FluentMigrator;

namespace DatabaseProject.Migrations
{
    [Migration(10, "Embedded SQL scripts with naming convension")]
    public class AutoMigratingSQL : AutoScriptMigration
    {
         
    }
}
