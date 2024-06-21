namespace EnvoiCommandeCRM
{
    partial class UFAjoutSociete
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UFAjoutSociete));
            this.Status = new System.Windows.Forms.StatusStrip();
            this.LStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.Barre = new System.Windows.Forms.ToolStripProgressBar();
            this.BarreMenu = new System.Windows.Forms.ToolStrip();
            this.BoutExit = new System.Windows.Forms.ToolStripButton();
            this.BoutValid = new System.Windows.Forms.ToolStripButton();
            this.DGVSociete = new System.Windows.Forms.DataGridView();
            this.oleConnect = new System.Data.OleDb.OleDbConnection();
            this.oleCommandLib = new System.Data.OleDb.OleDbCommand();
            this.oleComInsert = new System.Data.OleDb.OleDbCommand();
            this.BSourceSoc = new System.Windows.Forms.BindingSource(this.components);
            this.DSSoc = new System.Data.DataSet();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDAC = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbCommand2 = new System.Data.OleDb.OleDbCommand();
            this.Status.SuspendLayout();
            this.BarreMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSociete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSourceSoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSSoc)).BeginInit();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LStatus,
            this.Barre});
            this.Status.Location = new System.Drawing.Point(0, 430);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(629, 22);
            this.Status.TabIndex = 6;
            this.Status.Text = "statusStrip1";
            // 
            // LStatus
            // 
            this.LStatus.AutoSize = false;
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(650, 17);
            // 
            // Barre
            // 
            this.Barre.AutoSize = false;
            this.Barre.Name = "Barre";
            this.Barre.Size = new System.Drawing.Size(100, 16);
            // 
            // BarreMenu
            // 
            this.BarreMenu.BackgroundImage = global::EnvoiCommandeCRM.Properties.Resources.degrade2;
            this.BarreMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.BarreMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BoutExit,
            this.BoutValid});
            this.BarreMenu.Location = new System.Drawing.Point(0, 0);
            this.BarreMenu.Name = "BarreMenu";
            this.BarreMenu.Size = new System.Drawing.Size(629, 39);
            this.BarreMenu.TabIndex = 5;
            this.BarreMenu.Text = "toolStrip1";
            // 
            // BoutExit
            // 
            this.BoutExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoutExit.Image = global::EnvoiCommandeCRM.Properties.Resources.quitter2;
            this.BoutExit.ImageTransparentColor = System.Drawing.Color.White;
            this.BoutExit.Name = "BoutExit";
            this.BoutExit.Size = new System.Drawing.Size(36, 36);
            this.BoutExit.Text = "Retour à la saisie";
            this.BoutExit.Click += new System.EventHandler(this.BoutExit_Click);
            // 
            // BoutValid
            // 
            this.BoutValid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoutValid.Image = global::EnvoiCommandeCRM.Properties.Resources.valide;
            this.BoutValid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoutValid.Name = "BoutValid";
            this.BoutValid.Size = new System.Drawing.Size(36, 36);
            this.BoutValid.Text = "Validation";
            this.BoutValid.Click += new System.EventHandler(this.BoutValid_Click);
            // 
            // DGVSociete
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.DGVSociete.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVSociete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGVSociete.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVSociete.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.DGVSociete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVSociete.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVSociete.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVSociete.ColumnHeadersHeight = 18;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVSociete.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVSociete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVSociete.GridColor = System.Drawing.Color.AliceBlue;
            this.DGVSociete.Location = new System.Drawing.Point(0, 39);
            this.DGVSociete.MultiSelect = false;
            this.DGVSociete.Name = "DGVSociete";
            this.DGVSociete.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVSociete.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVSociete.RowHeadersVisible = false;
            this.DGVSociete.RowTemplate.Height = 18;
            this.DGVSociete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSociete.Size = new System.Drawing.Size(629, 391);
            this.DGVSociete.TabIndex = 231;
            // 
            // oleConnect
            // 
            this.oleConnect.ConnectionString = "Provider=SQLNCLI10;Data Source=SRV-TSE;Integrated Security=SSPI;Initial Catalog=T" +
    "RANSFERT_VP;Packet Size=4096;MARS Connection=True";
            // 
            // oleCommandLib
            // 
            this.oleCommandLib.Connection = this.oleConnect;
            // 
            // oleComInsert
            // 
            this.oleComInsert.Connection = this.oleConnect;
            // 
            // BSourceSoc
            // 
            this.BSourceSoc.AllowNew = true;
            this.BSourceSoc.DataSource = this.DSSoc;
            this.BSourceSoc.Position = 0;
            // 
            // DSSoc
            // 
            this.DSSoc.DataSetName = "DataSetSoc";
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT     SONOM, SODOMAINE, SOTYPERDV\r\nFROM         dbo.SOCIETE\r\nORDER BY SONOM";
            this.oleDbSelectCommand2.Connection = this.oleConnect;
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO [SOCIETE] ([SONOM], [SODOMAINE], [SOTYPERDV]) VALUES (?, ?, ?)";
            this.oleDbInsertCommand2.Connection = this.oleConnect;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("SONOM", System.Data.OleDb.OleDbType.VarWChar, 0, "SONOM"),
            new System.Data.OleDb.OleDbParameter("SODOMAINE", System.Data.OleDb.OleDbType.SmallInt, 0, "SODOMAINE"),
            new System.Data.OleDb.OleDbParameter("SOTYPERDV", System.Data.OleDb.OleDbType.VarWChar, 0, "SOTYPERDV")});
            // 
            // oleDAC
            // 
            this.oleDAC.DeleteCommand = this.oleDbCommand1;
            this.oleDAC.InsertCommand = this.oleDbInsertCommand2;
            this.oleDAC.SelectCommand = this.oleDbSelectCommand2;
            this.oleDAC.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SOCIETE", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("SONOM", "SONOM"),
                        new System.Data.Common.DataColumnMapping("SODOMAINE", "SODOMAINE"),
                        new System.Data.Common.DataColumnMapping("SOTYPERDV", "SOTYPERDV")})});
            this.oleDAC.UpdateCommand = this.oleDbCommand2;
            // 
            // oleDbCommand1
            // 
            this.oleDbCommand1.CommandText = "DELETE FROM dbo.SOCIETE\r\nWHERE     (SONOM = ?)";
            this.oleDbCommand1.Connection = this.oleConnect;
            this.oleDbCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("SONOM", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SONOM", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbCommand2
            // 
            this.oleDbCommand2.CommandText = "UPDATE    dbo.SOCIETE\r\nSET              SONOM = ?, SODOMAINE = ?, SOTYPERDV = ?\r\n" +
    "WHERE     (SONOM = ?)";
            this.oleDbCommand2.Connection = this.oleConnect;
            this.oleDbCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("SONOM", System.Data.OleDb.OleDbType.VarWChar, 30, "SONOM"),
            new System.Data.OleDb.OleDbParameter("SODOMAINE", System.Data.OleDb.OleDbType.SmallInt, 2, "SODOMAINE"),
            new System.Data.OleDb.OleDbParameter("SOTYPERDV", System.Data.OleDb.OleDbType.VarWChar, 30, "SOTYPERDV"),
            new System.Data.OleDb.OleDbParameter("Original_SONOM", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SONOM", System.Data.DataRowVersion.Original, null)});
            // 
            // UFAjoutSociete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(629, 452);
            this.Controls.Add(this.DGVSociete);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.BarreMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UFAjoutSociete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout des Sociétés";
            this.Load += new System.EventHandler(this.UFAjoutSociete_Load);
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.BarreMenu.ResumeLayout(false);
            this.BarreMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSociete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSourceSoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSSoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel LStatus;
        private System.Windows.Forms.ToolStripProgressBar Barre;
        private System.Windows.Forms.ToolStrip BarreMenu;
        private System.Windows.Forms.ToolStripButton BoutExit;
        private System.Windows.Forms.ToolStripButton BoutValid;
        public System.Windows.Forms.DataGridView DGVSociete;
        private System.Data.OleDb.OleDbConnection oleConnect;
        private System.Data.OleDb.OleDbCommand oleCommandLib;
        private System.Data.OleDb.OleDbCommand oleComInsert;
        public System.Windows.Forms.BindingSource BSourceSoc;
        private System.Data.DataSet DSSoc;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
        private System.Data.OleDb.OleDbDataAdapter oleDAC;
        private System.Data.OleDb.OleDbCommand oleDbCommand1;
        private System.Data.OleDb.OleDbCommand oleDbCommand2;
    }
}