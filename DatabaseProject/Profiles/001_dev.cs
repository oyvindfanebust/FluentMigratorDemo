using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseProject.Profiles
{
    [Profile("Development")]
    public class _001_dev : Migration
    {
        public override void Up()
        {
            Insert.IntoTable("Customer").Row(new
            {
                Name = "Profile Customer",

                Title = "title"
            });
        }

        public override void Down()
        {
            
        }
    }
}
