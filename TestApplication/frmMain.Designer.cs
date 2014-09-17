namespace TestApplication
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbAnnouncer = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProfile = new System.Windows.Forms.TextBox();
            this.btnRollback = new System.Windows.Forms.Button();
            this.numSteps = new System.Windows.Forms.NumericUpDown();
            this.lblSteps = new System.Windows.Forms.Label();
            this.lbTags = new System.Windows.Forms.ListBox();
            this.rbDown = new System.Windows.Forms.RadioButton();
            this.rbUp = new System.Windows.Forms.RadioButton();
            this.numVersion = new System.Windows.Forms.NumericUpDown();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnMigrate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVersion)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAnnouncer
            // 
            this.tbAnnouncer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAnnouncer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnnouncer.Location = new System.Drawing.Point(145, 0);
            this.tbAnnouncer.Multiline = true;
            this.tbAnnouncer.Name = "tbAnnouncer";
            this.tbAnnouncer.Size = new System.Drawing.Size(796, 561);
            this.tbAnnouncer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbProfile);
            this.panel1.Controls.Add(this.btnRollback);
            this.panel1.Controls.Add(this.numSteps);
            this.panel1.Controls.Add(this.lblSteps);
            this.panel1.Controls.Add(this.lbTags);
            this.panel1.Controls.Add(this.rbDown);
            this.panel1.Controls.Add(this.rbUp);
            this.panel1.Controls.Add(this.numVersion);
            this.panel1.Controls.Add(this.lblVersion);
            this.panel1.Controls.Add(this.btnMigrate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 561);
            this.panel1.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(12, 517);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 32);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Profile";
            // 
            // tbProfile
            // 
            this.tbProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProfile.Location = new System.Drawing.Point(12, 457);
            this.tbProfile.Name = "tbProfile";
            this.tbProfile.Size = new System.Drawing.Size(120, 29);
            this.tbProfile.TabIndex = 11;
            // 
            // btnRollback
            // 
            this.btnRollback.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollback.Location = new System.Drawing.Point(13, 387);
            this.btnRollback.Name = "btnRollback";
            this.btnRollback.Size = new System.Drawing.Size(119, 36);
            this.btnRollback.TabIndex = 10;
            this.btnRollback.Text = "Rull tilbake";
            this.btnRollback.UseVisualStyleBackColor = true;
            this.btnRollback.Click += new System.EventHandler(this.btnRollback_Click);
            // 
            // numSteps
            // 
            this.numSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSteps.Location = new System.Drawing.Point(12, 352);
            this.numSteps.Name = "numSteps";
            this.numSteps.Size = new System.Drawing.Size(120, 29);
            this.numSteps.TabIndex = 9;
            this.numSteps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteps.Location = new System.Drawing.Point(8, 325);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(48, 24);
            this.lblSteps.TabIndex = 8;
            this.lblSteps.Text = "Steg";
            // 
            // lbTags
            // 
            this.lbTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTags.FormattingEnabled = true;
            this.lbTags.ItemHeight = 24;
            this.lbTags.Items.AddRange(new object[] {
            "DEV",
            "PROD",
            "INTERN",
            "EKSTERN"});
            this.lbTags.Location = new System.Drawing.Point(12, 173);
            this.lbTags.Name = "lbTags";
            this.lbTags.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbTags.Size = new System.Drawing.Size(120, 100);
            this.lbTags.TabIndex = 7;
            // 
            // rbDown
            // 
            this.rbDown.AutoSize = true;
            this.rbDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDown.Location = new System.Drawing.Point(13, 114);
            this.rbDown.Name = "rbDown";
            this.rbDown.Size = new System.Drawing.Size(119, 28);
            this.rbDown.TabIndex = 6;
            this.rbDown.Text = "Nedgrader";
            this.rbDown.UseVisualStyleBackColor = true;
            // 
            // rbUp
            // 
            this.rbUp.AutoSize = true;
            this.rbUp.Checked = true;
            this.rbUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUp.Location = new System.Drawing.Point(12, 80);
            this.rbUp.Name = "rbUp";
            this.rbUp.Size = new System.Drawing.Size(120, 28);
            this.rbUp.TabIndex = 5;
            this.rbUp.TabStop = true;
            this.rbUp.Text = "Oppgrader";
            this.rbUp.UseVisualStyleBackColor = true;
            // 
            // numVersion
            // 
            this.numVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numVersion.Location = new System.Drawing.Point(13, 35);
            this.numVersion.Name = "numVersion";
            this.numVersion.Size = new System.Drawing.Size(119, 29);
            this.numVersion.TabIndex = 4;
            this.numVersion.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(9, 8);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(75, 24);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Versjon";
            // 
            // btnMigrate
            // 
            this.btnMigrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMigrate.Location = new System.Drawing.Point(13, 279);
            this.btnMigrate.Name = "btnMigrate";
            this.btnMigrate.Size = new System.Drawing.Size(119, 36);
            this.btnMigrate.TabIndex = 0;
            this.btnMigrate.Text = "Kjør";
            this.btnMigrate.UseVisualStyleBackColor = true;
            this.btnMigrate.Click += new System.EventHandler(this.btnMigrate_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 561);
            this.Controls.Add(this.tbAnnouncer);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "FluentMigrator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVersion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAnnouncer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnMigrate;
        private System.Windows.Forms.NumericUpDown numVersion;
        private System.Windows.Forms.RadioButton rbDown;
        private System.Windows.Forms.RadioButton rbUp;
        private System.Windows.Forms.ListBox lbTags;
        private System.Windows.Forms.NumericUpDown numSteps;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Button btnRollback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProfile;
        private System.Windows.Forms.Button btnReset;
    }
}

