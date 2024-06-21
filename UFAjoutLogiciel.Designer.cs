namespace EnvoiCommandeCRM
{
    partial class UFAjoutLogiciel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UFAjoutLogiciel));
            this.oleConnectCRM = new System.Data.OleDb.OleDbConnection();
            this.BarreMenu = new System.Windows.Forms.ToolStrip();
            this.BoutExit = new System.Windows.Forms.ToolStripButton();
            this.BoutValid = new System.Windows.Forms.ToolStripButton();
            this.oleCommandCRM = new System.Data.OleDb.OleDbCommand();
            this.oleComInsert = new System.Data.OleDb.OleDbCommand();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.LStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.Barre = new System.Windows.Forms.ToolStripProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SType = new System.Windows.Forms.ComboBox();
            this.SEditeur = new System.Windows.Forms.ComboBox();
            this.SGamme = new System.Windows.Forms.ComboBox();
            this.SVersion = new System.Windows.Forms.TextBox();
            this.oleDACType = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbCommand4 = new System.Data.OleDb.OleDbCommand();
            this.DSType = new System.Data.DataSet();
            this.Ligne = new System.Data.DataTable();
            this.DSEditeur = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.oleDACEditeur = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbCommand6 = new System.Data.OleDb.OleDbCommand();
            this.oleDbCommand7 = new System.Data.OleDb.OleDbCommand();
            this.oleDbCommand8 = new System.Data.OleDb.OleDbCommand();
            this.oleDACGamme = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbCommand9 = new System.Data.OleDb.OleDbCommand();
            this.oleDbCommand10 = new System.Data.OleDb.OleDbCommand();
            this.oleDbCommand11 = new System.Data.OleDb.OleDbCommand();
            this.oleDbCommand12 = new System.Data.OleDb.OleDbCommand();
            this.DSGamme = new System.Data.DataSet();
            this.dataTable2 = new System.Data.DataTable();
            this.BarreMenu.SuspendLayout();
            this.Status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ligne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSEditeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSGamme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
            this.SuspendLayout();
            // 
            // oleConnectCRM
            // 
            this.oleConnectCRM.ConnectionString = "Provider=SQLNCLI10;Data Source=SRV-TSE;Integrated Security=SSPI;Initial Catalog=g" +
                "roupeadinfo_MSCRM;Packet Size=4096;MARS Connection=True";
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
            this.BarreMenu.Size = new System.Drawing.Size(751, 39);
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
            this.BoutValid.Text = "Validation dans la CRM";
            this.BoutValid.Click += new System.EventHandler(this.BoutValid_Click);
            // 
            // oleCommandCRM
            // 
            this.oleCommandCRM.Connection = this.oleConnectCRM;
            // 
            // oleComInsert
            // 
            this.oleComInsert.Connection = this.oleConnectCRM;
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LStatus,
            this.Barre});
            this.Status.Location = new System.Drawing.Point(0, 251);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(751, 22);
            this.Status.TabIndex = 6;
            this.Status.Text = "statusStrip1";
            // 
            // LStatus
            // 
            this.LStatus.AutoSize = false;
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(350, 17);
            // 
            // Barre
            // 
            this.Barre.AutoSize = false;
            this.Barre.Name = "Barre";
            this.Barre.Size = new System.Drawing.Size(300, 16);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Editeur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gamme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Version";
            // 
            // SType
            // 
            this.SType.FormattingEnabled = true;
            this.SType.Location = new System.Drawing.Point(154, 70);
            this.SType.Name = "SType";
            this.SType.Size = new System.Drawing.Size(434, 21);
            this.SType.TabIndex = 11;
            // 
            // SEditeur
            // 
            this.SEditeur.FormattingEnabled = true;
            this.SEditeur.Location = new System.Drawing.Point(155, 105);
            this.SEditeur.Name = "SEditeur";
            this.SEditeur.Size = new System.Drawing.Size(434, 21);
            this.SEditeur.TabIndex = 12;
            // 
            // SGamme
            // 
            this.SGamme.FormattingEnabled = true;
            this.SGamme.Location = new System.Drawing.Point(155, 139);
            this.SGamme.Name = "SGamme";
            this.SGamme.Size = new System.Drawing.Size(434, 21);
            this.SGamme.TabIndex = 13;
            // 
            // SVersion
            // 
            this.SVersion.Location = new System.Drawing.Point(154, 177);
            this.SVersion.Name = "SVersion";
            this.SVersion.Size = new System.Drawing.Size(229, 20);
            this.SVersion.TabIndex = 14;
            // 
            // oleDACType
            // 
            this.oleDACType.DeleteCommand = this.oleDbCommand1;
            this.oleDACType.InsertCommand = this.oleDbCommand2;
            this.oleDACType.SelectCommand = this.oleDbCommand3;
            this.oleDACType.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "", new System.Data.Common.DataColumnMapping[0])});
            this.oleDACType.UpdateCommand = this.oleDbCommand4;
            // 
            // oleDbCommand3
            // 
            this.oleDbCommand3.Connection = this.oleConnectCRM;
            // 
            // DSType
            // 
            this.DSType.DataSetName = "DataSetType";
            this.DSType.Tables.AddRange(new System.Data.DataTable[] {
            this.Ligne});
            // 
            // Ligne
            // 
            this.Ligne.TableName = "Ligne";
            // 
            // DSEditeur
            // 
            this.DSEditeur.DataSetName = "DataSetEditeur";
            this.DSEditeur.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.TableName = "Ligne";
            // 
            // oleDACEditeur
            // 
            this.oleDACEditeur.DeleteCommand = this.oleDbCommand5;
            this.oleDACEditeur.InsertCommand = this.oleDbCommand6;
            this.oleDACEditeur.SelectCommand = this.oleDbCommand7;
            this.oleDACEditeur.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "", new System.Data.Common.DataColumnMapping[0])});
            this.oleDACEditeur.UpdateCommand = this.oleDbCommand8;
            // 
            // oleDbCommand7
            // 
            this.oleDbCommand7.Connection = this.oleConnectCRM;
            // 
            // oleDACGamme
            // 
            this.oleDACGamme.DeleteCommand = this.oleDbCommand9;
            this.oleDACGamme.InsertCommand = this.oleDbCommand10;
            this.oleDACGamme.SelectCommand = this.oleDbCommand11;
            this.oleDACGamme.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "", new System.Data.Common.DataColumnMapping[0])});
            this.oleDACGamme.UpdateCommand = this.oleDbCommand12;
            // 
            // oleDbCommand11
            // 
            this.oleDbCommand11.Connection = this.oleConnectCRM;
            // 
            // DSGamme
            // 
            this.DSGamme.DataSetName = "DataSetGamme";
            this.DSGamme.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable2});
            // 
            // dataTable2
            // 
            this.dataTable2.TableName = "Ligne";
            // 
            // UFAjoutLogiciel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(751, 273);
            this.Controls.Add(this.SVersion);
            this.Controls.Add(this.SGamme);
            this.Controls.Add(this.SEditeur);
            this.Controls.Add(this.SType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarreMenu);
            this.Controls.Add(this.Status);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UFAjoutLogiciel";
            this.Text = "Ajout d\'un logiciel";
            this.Load += new System.EventHandler(this.UFAjoutLogiciel_Load);
            this.BarreMenu.ResumeLayout(false);
            this.BarreMenu.PerformLayout();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ligne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSEditeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSGamme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.OleDb.OleDbConnection oleConnectCRM;
        private System.Windows.Forms.ToolStrip BarreMenu;
        private System.Windows.Forms.ToolStripButton BoutExit;
        private System.Windows.Forms.ToolStripButton BoutValid;
        private System.Data.OleDb.OleDbCommand oleCommandCRM;
        private System.Data.OleDb.OleDbCommand oleComInsert;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel LStatus;
        private System.Windows.Forms.ToolStripProgressBar Barre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SType;
        private System.Windows.Forms.ComboBox SEditeur;
        private System.Windows.Forms.ComboBox SGamme;
        private System.Windows.Forms.TextBox SVersion;
        private System.Data.OleDb.OleDbDataAdapter oleDACType;
        private System.Data.OleDb.OleDbCommand oleDbCommand1;
        private System.Data.OleDb.OleDbCommand oleDbCommand2;
        private System.Data.OleDb.OleDbCommand oleDbCommand3;
        private System.Data.OleDb.OleDbCommand oleDbCommand4;
        public System.Data.DataSet DSType;
        private System.Data.DataTable Ligne;
        public System.Data.DataSet DSEditeur;
        private System.Data.DataTable dataTable1;
        private System.Data.OleDb.OleDbDataAdapter oleDACEditeur;
        private System.Data.OleDb.OleDbCommand oleDbCommand5;
        private System.Data.OleDb.OleDbCommand oleDbCommand6;
        private System.Data.OleDb.OleDbCommand oleDbCommand7;
        private System.Data.OleDb.OleDbCommand oleDbCommand8;
        private System.Data.OleDb.OleDbDataAdapter oleDACGamme;
        private System.Data.OleDb.OleDbCommand oleDbCommand9;
        private System.Data.OleDb.OleDbCommand oleDbCommand10;
        private System.Data.OleDb.OleDbCommand oleDbCommand11;
        private System.Data.OleDb.OleDbCommand oleDbCommand12;
        public System.Data.DataSet DSGamme;
        private System.Data.DataTable dataTable2;
    }
}