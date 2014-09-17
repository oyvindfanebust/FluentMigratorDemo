using FluentMigrator.Runner.Announcers;
using FluentMigrator.Runner.Initialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestApplication
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMigrate_Click(object sender, EventArgs e)
        {
            var task = rbUp.Checked ? "migrate" : "migrate:down";
            Execute(task);
        }

        private void btnRollback_Click(object sender, EventArgs e)
        {
            var task = "rollback";
            Execute(task);
        }

        private void Execute(string task)
        {
            tbAnnouncer.Clear();

            var version = (int)numVersion.Value;
            var steps = (int)numSteps.Value;
            var tags = new List<string>();
            var profile = tbProfile.Text;
            foreach (var item in lbTags.SelectedItems)
            {
                tags.Add(item.ToString());
            }

            var announcer = new TextWriterAnnouncer(new TextBoxStreamWriter(tbAnnouncer));
            announcer.Heading("Migrate database");

            var runnerContext = new RunnerContext(announcer)
            {
                Database = "SqlServer2008",
                Connection = ConfigurationManager.ConnectionStrings["FluentMigrator"].ConnectionString,

                Target = "DatabaseProject.dll",
                PreviewOnly = false,
                Namespace = "DatabaseProject",
                NestedNamespaces = true,
                Task = task,
                Version = version,
                Steps = steps,
                Tags = tags,
                //WorkingDirectory = "C:\\temp",
                Profile = profile,
                Timeout = 30,
                TransactionPerSession = true
            };

            var executor = new TaskExecutor(runnerContext);


            try
            {
                executor.Execute();
            }
            catch (Exception ex)
            {
                tbAnnouncer.AppendText("Exception: " + ex.Message);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbAnnouncer.Clear();

            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FluentMigrator"].ConnectionString))
            {
                var sql = File.ReadAllText("reset.sql");

                string sqlBatch = string.Empty;
                SqlCommand cmd = new SqlCommand(string.Empty, conn);
                conn.Open();
                sql += "\nGO";

                foreach (string line in sql.Split(new string[2] { "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (line.ToUpperInvariant().Trim() == "GO")
                    {
                        if (!string.IsNullOrEmpty(sqlBatch))
                        {
                            cmd.CommandText = sqlBatch;
                            cmd.ExecuteNonQuery();
                        }
                        sqlBatch = string.Empty;
                    }
                    else
                    {
                        sqlBatch += line + "\n";
                    }
                }

                conn.Close();
            }

            tbAnnouncer.AppendText("Database nullstilt" + Environment.NewLine);
        }
    }
}
