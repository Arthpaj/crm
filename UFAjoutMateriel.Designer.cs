namespace EnvoiCommandeCRM
{
    partial class UFAjoutMateriel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UFAjoutMateriel));
            this.DSType = new System.Data.DataSet();
            this.Ligne = new System.Data.DataTable();
            this.BarreMenu = new System.Windows.Forms.ToolStrip();
            this.BoutExit = new System.Windows.Forms.ToolStripButton();
            this.BoutValid = new System.Windows.Forms.ToolStripButton();
            this.oleDACType = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleConnectCRM = new System.Data.OleDb.OleDbConnection();
            this.oleDbCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDACFabricant = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbCommand6 = new System.Data.OleDb.OleDbCommand();
            this.oleDbCommand7 = new System.Data.OleDb.OleDbCommand();
            this.oleDbCommand8 = new System.Data.OleDb.OleDbCommand();
            this.oleComInsert = new System.Data.OleDb.OleDbCommand();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.LStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.Barre = new System.Windows.Forms.ToolStripProgressBar();
            this.oleCommandCRM = new System.Data.OleDb.OleDbCommand();
            this.DSFabricant = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.SDesignation = new System.Windows.Forms.TextBox();
            this.SFabricant = new System.Windows.Forms.ComboBox();
            this.SType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DSType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ligne)).BeginInit();
            this.BarreMenu.SuspendLayout();
            this.Status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSFabricant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.SuspendLayout();
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
            // BarreMenu
            // 
            this.BarreMenu.BackgroundImage = global::EnvoiCommandeCRM.Properties.Resources.degrade2;
            this.BarreMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.BarreMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BoutExit,
            this.BoutValid});
            this.BarreMenu.Location = new System.Drawing.Point(0, 0);
            this.BarreMenu.Name = "BarreMenu";
            this.BarreMenu.Size = new System.Drawing.Size(836, 39);
            this.BarreMenu.TabIndex = 7;
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
            // oleConnectCRM
            // 
            this.oleConnectCRM.ConnectionString = "Provider=SQLNCLI10;Data Source=SRV-TSE;Integrated Security=SSPI;Initial Catalog=g" +
                "roupeadinfo_MSCRM;Packet Size=4096;MARS Connection=True";
            // 
            // oleDACFabricant
            // 
            this.oleDACFabricant.DeleteCommand = this.oleDbCommand5;
            this.oleDACFabricant.InsertCommand = this.oleDbCommand6;
            this.oleDACFabricant.SelectCommand = this.oleDbCommand7;
            this.oleDACFabricant.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "", new System.Data.Common.DataColumnMapping[0])});
            this.oleDACFabricant.UpdateCommand = this.oleDbCommand8;
            // 
            // oleDbCommand7
            // 
            this.oleDbCommand7.Connection = this.oleConnectCRM;
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
            this.Status.Size = new System.Drawing.Size(836, 22);
            this.Status.TabIndex = 8;
            this.Status.Text = "statusStrip1";
            // 
            // LStatus
            // 
            this.LStatus.AutoSize = false;
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(400, 17);
            // 
            // Barre
            // 
            this.Barre.AutoSize = false;
            this.Barre.Name = "Barre";
            this.Barre.Size = new System.Drawing.Size(300, 16);
            // 
            // oleCommandCRM
            // 
            this.oleCommandCRM.Connection = this.oleConnectCRM;
            // 
            // DSFabricant
            // 
            this.DSFabricant.DataSetName = "DataSetFabricant";
            this.DSFabricant.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.TableName = "Ligne";
            // 
            // SDesignation
            // 
            this.SDesignation.AcceptsReturn = true;
            this.SDesignation.AcceptsTab = true;
            this.SDesignation.Location = new System.Drawing.Point(167, 140);
            this.SDesignation.Multiline = true;
            this.SDesignation.Name = "SDesignation";
            this.SDesignation.Size = new System.Drawing.Size(434, 91);
            this.SDesignation.TabIndex = 20;
            // 
            // SFabricant
            // 
            this.SFabricant.FormattingEnabled = true;
            this.SFabricant.Location = new System.Drawing.Point(167, 104);
            this.SFabricant.Name = "SFabricant";
            this.SFabricant.Size = new System.Drawing.Size(434, 21);
            this.SFabricant.TabIndex = 19;
            // 
            // SType
            // 
            this.SType.FormattingEnabled = true;
            this.SType.Location = new System.Drawing.Point(166, 69);
            this.SType.Name = "SType";
            this.SType.Size = new System.Drawing.Size(434, 21);
            this.SType.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Désignation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fabricant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Type";
            // 
            // UFAjoutMateriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(836, 273);
            this.Controls.Add(this.SDesignation);
            this.Controls.Add(this.SFabricant);
            this.Controls.Add(this.SType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarreMenu);
            this.Controls.Add(this.Status);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UFAjoutMateriel";
            this.Text = "Ajout de Matériel";
            this.Load += new System.EventHandler(this.UFAjoutMateriel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ligne)).EndInit();
            this.BarreMenu.ResumeLayout(false);
            this.BarreMenu.PerformLayout();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSFabricant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Data.DataSet DSType;
        private System.Data.DataTable Ligne;
        private System.Windows.Forms.ToolStrip BarreMenu;
        private System.Windows.Forms.ToolStripButton BoutExit;
        private System.Windows.Forms.ToolStripButton BoutValid;
        private System.Data.OleDb.OleDbDataAdapter oleDACType;
        private System.Data.OleDb.OleDbCommand oleDbCommand1;
        private System.Data.OleDb.OleDbCommand oleDbCommand2;
        private System.Data.OleDb.OleDbCommand oleDbCommand3;
        private System.Data.OleDb.OleDbConnection oleConnectCRM;
        private System.Data.OleDb.OleDbCommand oleDbCommand4;
        private System.Data.OleDb.OleDbDataAdapter oleDACFabricant;
        private System.Data.OleDb.OleDbCommand oleDbCommand5;
        private System.Data.OleDb.OleDbCommand oleDbCommand6;
        private System.Data.OleDb.OleDbCommand oleDbCommand7;
        private System.Data.OleDb.OleDbCommand oleDbCommand8;
        private System.Data.OleDb.OleDbCommand oleComInsert;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel LStatus;
        private System.Windows.Forms.ToolStripProgressBar Barre;
        private System.Data.OleDb.OleDbCommand oleCommandCRM;
        public System.Data.DataSet DSFabricant;
        private System.Data.DataTable dataTable1;
        private System.Windows.Forms.TextBox SDesignation;
        private System.Windows.Forms.ComboBox SFabricant;
        private System.Windows.Forms.ComboBox SType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}