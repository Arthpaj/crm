namespace EnvoiCommandeCRM
{
    partial class UFAjoutContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UFAjoutContact));
            this.BarreMenu = new System.Windows.Forms.ToolStrip();
            this.BoutExit = new System.Windows.Forms.ToolStripButton();
            this.BoutValid = new System.Windows.Forms.ToolStripButton();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.LStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.Barre = new System.Windows.Forms.ToolStripProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SNom = new System.Windows.Forms.TextBox();
            this.SPrenom = new System.Windows.Forms.TextBox();
            this.SFonction = new System.Windows.Forms.TextBox();
            this.SPortable = new System.Windows.Forms.TextBox();
            this.STelephone = new System.Windows.Forms.TextBox();
            this.SEmail = new System.Windows.Forms.TextBox();
            this.oleCommandCRM = new System.Data.OleDb.OleDbCommand();
            this.oleConnectCRM = new System.Data.OleDb.OleDbConnection();
            this.oleComInsert = new System.Data.OleDb.OleDbCommand();
            this.SCivilite = new System.Windows.Forms.ComboBox();
            this.BarreMenu.SuspendLayout();
            this.Status.SuspendLayout();
            this.SuspendLayout();
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
            this.BarreMenu.Size = new System.Drawing.Size(788, 39);
            this.BarreMenu.TabIndex = 3;
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
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LStatus,
            this.Barre});
            this.Status.Location = new System.Drawing.Point(0, 251);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(788, 22);
            this.Status.TabIndex = 4;
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
            this.label1.Location = new System.Drawing.Point(48, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Civilité";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fonction";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Portable";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(513, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Téléphone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Email";
            // 
            // SNom
            // 
            this.SNom.Location = new System.Drawing.Point(312, 72);
            this.SNom.Name = "SNom";
            this.SNom.Size = new System.Drawing.Size(195, 20);
            this.SNom.TabIndex = 13;
            // 
            // SPrenom
            // 
            this.SPrenom.Location = new System.Drawing.Point(579, 72);
            this.SPrenom.Name = "SPrenom";
            this.SPrenom.Size = new System.Drawing.Size(174, 20);
            this.SPrenom.TabIndex = 14;
            // 
            // SFonction
            // 
            this.SFonction.Location = new System.Drawing.Point(102, 121);
            this.SFonction.Name = "SFonction";
            this.SFonction.Size = new System.Drawing.Size(151, 20);
            this.SFonction.TabIndex = 15;
            // 
            // SPortable
            // 
            this.SPortable.Location = new System.Drawing.Point(312, 121);
            this.SPortable.Name = "SPortable";
            this.SPortable.Size = new System.Drawing.Size(195, 20);
            this.SPortable.TabIndex = 16;
            // 
            // STelephone
            // 
            this.STelephone.Location = new System.Drawing.Point(579, 121);
            this.STelephone.Name = "STelephone";
            this.STelephone.Size = new System.Drawing.Size(174, 20);
            this.STelephone.TabIndex = 17;
            // 
            // SEmail
            // 
            this.SEmail.Location = new System.Drawing.Point(102, 166);
            this.SEmail.Name = "SEmail";
            this.SEmail.Size = new System.Drawing.Size(651, 20);
            this.SEmail.TabIndex = 18;
            // 
            // oleCommandCRM
            // 
            this.oleCommandCRM.Connection = this.oleConnectCRM;
            // 
            // oleConnectCRM
            // 
            this.oleConnectCRM.ConnectionString = "Provider=SQLNCLI10;Data Source=SRV-TSE;Integrated Security=SSPI;Initial Catalog=g" +
                "roupeadinfo_MSCRM;Packet Size=4096;MARS Connection=True";
            // 
            // oleComInsert
            // 
            this.oleComInsert.Connection = this.oleConnectCRM;
            // 
            // SCivilite
            // 
            this.SCivilite.FormattingEnabled = true;
            this.SCivilite.Location = new System.Drawing.Point(102, 69);
            this.SCivilite.Name = "SCivilite";
            this.SCivilite.Size = new System.Drawing.Size(151, 21);
            this.SCivilite.TabIndex = 19;
            // 
            // UFAjoutContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(788, 273);
            this.Controls.Add(this.SCivilite);
            this.Controls.Add(this.SEmail);
            this.Controls.Add(this.STelephone);
            this.Controls.Add(this.SPortable);
            this.Controls.Add(this.SFonction);
            this.Controls.Add(this.SPrenom);
            this.Controls.Add(this.SNom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.BarreMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UFAjoutContact";
            this.Text = "Ajout d\' un Contact";
            this.Load += new System.EventHandler(this.UFAjoutContact_Load);
            this.BarreMenu.ResumeLayout(false);
            this.BarreMenu.PerformLayout();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip BarreMenu;
        private System.Windows.Forms.ToolStripButton BoutExit;
        private System.Windows.Forms.ToolStripButton BoutValid;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SNom;
        private System.Windows.Forms.TextBox SPrenom;
        private System.Windows.Forms.TextBox SFonction;
        private System.Windows.Forms.TextBox SPortable;
        private System.Windows.Forms.TextBox STelephone;
        private System.Windows.Forms.TextBox SEmail;
        private System.Data.OleDb.OleDbCommand oleCommandCRM;
        private System.Data.OleDb.OleDbConnection oleConnectCRM;
        private System.Windows.Forms.ToolStripStatusLabel LStatus;
        private System.Windows.Forms.ToolStripProgressBar Barre;
        private System.Data.OleDb.OleDbCommand oleComInsert;
        private System.Windows.Forms.ComboBox SCivilite;
    }
}