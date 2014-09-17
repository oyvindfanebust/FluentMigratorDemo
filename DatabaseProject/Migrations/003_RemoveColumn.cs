using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentMigrator.Runner.Extensions;
using FluentMigrator;

namespace DatabaseProject.Migrations
{
    //ForwardOnly - For eksempel hvis en kolonne slettes

    [Migration(3, "Remove Modified column from Product table")]
    public class RemoveModifiedColumnFromProductTable : ForwardOnlyMigration
    {
        public override void Up()
        {
            Delete.Column("Modified").FromTable("Product");
        }
    }
}
