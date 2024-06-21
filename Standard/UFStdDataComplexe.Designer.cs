namespace EnvoiCommandeCRM
{
  partial class UFStdDataComplexe
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UFStdDataComplexe));
        this.Recherche = new System.Windows.Forms.TextBox();
        this.ComboRech = new System.Windows.Forms.ComboBox();
        this.oleConnect = new System.Data.OleDb.OleDbConnection();
        this.DSStd = new System.Data.DataSet();
        this.BSource = new System.Windows.Forms.BindingSource(this.components);
        this.Status = new System.Windows.Forms.StatusStrip();
        this.Barre = new System.Windows.Forms.ToolStripProgressBar();
        this.LStatus = new System.Windows.Forms.ToolStripStatusLabel();
        this.oleCommandLib = new System.Data.OleDb.OleDbCommand();
        this.menu = new System.Windows.Forms.ToolStrip();
        this.quitter = new System.Windows.Forms.ToolStripButton();
        this.sep = new System.Windows.Forms.ToolStripSeparator();
        this.Valide = new System.Windows.Forms.ToolStripButton();
        this.Nouveau = new System.Windows.Forms.ToolStripButton();
        this.Supprimer = new System.Windows.Forms.ToolStripButton();
        this.sep1 = new System.Windows.Forms.ToolStripSeparator();
        this.Importer = new System.Windows.Forms.ToolStripButton();
        this.Apercu = new System.Windows.Forms.ToolStripButton();
        this.DGVDefaut = new System.Windows.Forms.DataGridView();
        this.panel1 = new System.Windows.Forms.Panel();
        this.LRef = new System.Windows.Forms.Label();
        this.TRef = new System.Windows.Forms.TextBox();
        ((System.ComponentModel.ISupportInitialize)(this.DSStd)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.BSource)).BeginInit();
        this.Status.SuspendLayout();
        this.menu.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.DGVDefaut)).BeginInit();
        this.panel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // Recherche
        // 
        this.Recherche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.Recherche.BackColor = System.Drawing.Color.Lavender;
        this.Recherche.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Recherche.Location = new System.Drawing.Point(662, 22);
        this.Recherche.Name = "Recherche";
        this.Recherche.Size = new System.Drawing.Size(128, 20);
        this.Recherche.TabIndex = 8;
        this.Recherche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Recherche_KeyPress);
        this.Recherche.Leave += new System.EventHandler(this.Recherche_Leave);
        // 
        // ComboRech
        // 
        this.ComboRech.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.ComboRech.BackColor = System.Drawing.Color.Lavender;
        this.ComboRech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.ComboRech.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.ComboRech.FormattingEnabled = true;
        this.ComboRech.Location = new System.Drawing.Point(662, 0);
        this.ComboRech.Name = "ComboRech";
        this.ComboRech.Size = new System.Drawing.Size(128, 22);
        this.ComboRech.TabIndex = 7;
        // 
        // oleConnect
        // 
        this.oleConnect.ConnectionString = "Provider=SQLNCLI11;Data Source=SRV-TSE;Integrated Security=SSPI;Initial Catalog=T" +
            "RANSFERT_VP;Packet Size=4096;MARS Connection=True";
        // 
        // DSStd
        // 
        this.DSStd.DataSetName = "DataSetStd";
        // 
        // BSource
        // 
        this.BSource.AllowNew = true;
        this.BSource.DataSource = this.DSStd;
        this.BSource.Position = 0;
        // 
        // Status
        // 
        this.Status.BackColor = System.Drawing.SystemColors.Control;
        this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Barre,
            this.LStatus});
        this.Status.Location = new System.Drawing.Point(0, 379);
        this.Status.Name = "Status";
        this.Status.Size = new System.Drawing.Size(790, 22);
        this.Status.TabIndex = 11;
        this.Status.Text = "statusStrip1";
        // 
        // Barre
        // 
        this.Barre.Name = "Barre";
        this.Barre.Size = new System.Drawing.Size(300, 16);
        this.Barre.Visible = false;
        // 
        // LStatus
        // 
        this.LStatus.BackColor = System.Drawing.SystemColors.Control;
        this.LStatus.Name = "LStatus";
        this.LStatus.Size = new System.Drawing.Size(85, 17);
        this.LStatus.Text = "                          ";
        // 
        // oleCommandLib
        // 
        this.oleCommandLib.Connection = this.oleConnect;
        // 
        // menu
        // 
        this.menu.AutoSize = false;
        this.menu.BackColor = System.Drawing.Color.Lavender;
        this.menu.BackgroundImage = global::EnvoiCommandeCRM.Properties.Resources.degrade2;
        this.menu.ImageScalingSize = new System.Drawing.Size(32, 32);
        this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitter,
            this.sep,
            this.Valide,
            this.Nouveau,
            this.Supprimer,
            this.sep1,
            this.Importer,
            this.Apercu});
        this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
        this.menu.Location = new System.Drawing.Point(0, 0);
        this.menu.Name = "menu";
        this.menu.Size = new System.Drawing.Size(790, 39);
        this.menu.TabIndex = 5;
        // 
        // quitter
        // 
        this.quitter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.quitter.Image = global::EnvoiCommandeCRM.Properties.Resources.quitter2;
        this.quitter.ImageTransparentColor = System.Drawing.Color.White;
        this.quitter.Name = "quitter";
        this.quitter.Size = new System.Drawing.Size(36, 36);
        this.quitter.Text = "Quitter";
        this.quitter.ToolTipText = "Quitter";
        this.quitter.Click += new System.EventHandler(this.quitter_Click);
        // 
        // sep
        // 
        this.sep.Name = "sep";
        this.sep.Size = new System.Drawing.Size(6, 39);
        // 
        // Valide
        // 
        this.Valide.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.Valide.Image = global::EnvoiCommandeCRM.Properties.Resources.valide;
        this.Valide.ImageTransparentColor = System.Drawing.Color.White;
        this.Valide.Name = "Valide";
        this.Valide.Size = new System.Drawing.Size(36, 36);
        this.Valide.Text = "Valider";
        this.Valide.ToolTipText = "Valider";
        this.Valide.Click += new System.EventHandler(this.Valide_Click);
        // 
        // Nouveau
        // 
        this.Nouveau.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.Nouveau.Image = global::EnvoiCommandeCRM.Properties.Resources.new_document_32;
        this.Nouveau.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.Nouveau.Name = "Nouveau";
        this.Nouveau.Size = new System.Drawing.Size(36, 36);
        this.Nouveau.Text = "Nouveau";
        this.Nouveau.ToolTipText = "Nouveau";
        this.Nouveau.Click += new System.EventHandler(this.Nouveau_Click);
        // 
        // Supprimer
        // 
        this.Supprimer.BackColor = System.Drawing.Color.Lavender;
        this.Supprimer.BackgroundImage = global::EnvoiCommandeCRM.Properties.Resources.degrade2;
        this.Supprimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.Supprimer.Image = global::EnvoiCommandeCRM.Properties.Resources.delete_x_32;
        this.Supprimer.ImageTransparentColor = System.Drawing.Color.White;
        this.Supprimer.Name = "Supprimer";
        this.Supprimer.Size = new System.Drawing.Size(36, 36);
        this.Supprimer.Text = "Supprimer";
        this.Supprimer.ToolTipText = "Supprimer";
        this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
        // 
        // sep1
        // 
        this.sep1.Name = "sep1";
        this.sep1.Size = new System.Drawing.Size(6, 39);
        // 
        // Importer
        // 
        this.Importer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.Importer.ImageTransparentColor = System.Drawing.Color.White;
        this.Importer.Name = "Importer";
        this.Importer.Size = new System.Drawing.Size(23, 36);
        this.Importer.Text = "Importer";
        this.Importer.ToolTipText = "Importer";
        // 
        // Apercu
        // 
        this.Apercu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.Apercu.Image = global::EnvoiCommandeCRM.Properties.Resources.print_preview_32;
        this.Apercu.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.Apercu.Name = "Apercu";
        this.Apercu.Size = new System.Drawing.Size(36, 36);
        this.Apercu.Text = "Aperçu";
        this.Apercu.ToolTipText = "Aperçu";
        this.Apercu.Click += new System.EventHandler(this.Apercu_Click);
        // 
        // DGVDefaut
        // 
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
        this.DGVDefaut.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        this.DGVDefaut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        this.DGVDefaut.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
        this.DGVDefaut.BackgroundColor = System.Drawing.Color.AliceBlue;
        this.DGVDefaut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.DGVDefaut.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        this.DGVDefaut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        this.DGVDefaut.DefaultCellStyle = dataGridViewCellStyle3;
        this.DGVDefaut.Dock = System.Windows.Forms.DockStyle.Fill;
        this.DGVDefaut.GridColor = System.Drawing.Color.AliceBlue;
        this.DGVDefaut.Location = new System.Drawing.Point(0, 39);
        this.DGVDefaut.MultiSelect = false;
        this.DGVDefaut.Name = "DGVDefaut";
        this.DGVDefaut.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        this.DGVDefaut.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        this.DGVDefaut.RowHeadersVisible = false;
        this.DGVDefaut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.DGVDefaut.Size = new System.Drawing.Size(790, 308);
        this.DGVDefaut.TabIndex = 12;
        this.DGVDefaut.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DGVDefaut_UserDeletingRow);
        // 
        // panel1
        // 
        this.panel1.AutoSize = true;
        this.panel1.Controls.Add(this.LRef);
        this.panel1.Controls.Add(this.TRef);
        this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.panel1.Location = new System.Drawing.Point(0, 347);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(790, 32);
        this.panel1.TabIndex = 13;
        // 
        // LRef
        // 
        this.LRef.AutoSize = true;
        this.LRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.LRef.ForeColor = System.Drawing.Color.MidnightBlue;
        this.LRef.Location = new System.Drawing.Point(12, 10);
        this.LRef.Name = "LRef";
        this.LRef.Size = new System.Drawing.Size(77, 16);
        this.LRef.TabIndex = 11;
        this.LRef.Text = "Référence :";
        this.LRef.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // TRef
        // 
        this.TRef.Location = new System.Drawing.Point(95, 9);
        this.TRef.Name = "TRef";
        this.TRef.Size = new System.Drawing.Size(100, 20);
        this.TRef.TabIndex = 10;
        // 
        // UFStdDataComplexe
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(790, 401);
        this.Controls.Add(this.ComboRech);
        this.Controls.Add(this.Recherche);
        this.Controls.Add(this.DGVDefaut);
        this.Controls.Add(this.panel1);
        this.Controls.Add(this.Status);
        this.Controls.Add(this.menu);
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.Name = "UFStdDataComplexe";
        this.Text = "Formulaire Datas complexes";
        this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UFStdDataComplexe_FormClosed);
        this.Load += new System.EventHandler(this.UFStdDataComplexe_Load);
        ((System.ComponentModel.ISupportInitialize)(this.DSStd)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.BSource)).EndInit();
        this.Status.ResumeLayout(false);
        this.Status.PerformLayout();
        this.menu.ResumeLayout(false);
        this.menu.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.DGVDefaut)).EndInit();
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    public System.Windows.Forms.ToolStrip menu;
    public System.Windows.Forms.ToolStripButton quitter;
    private System.Windows.Forms.ToolStripSeparator sep;
    public System.Windows.Forms.ToolStripButton Valide;
    private System.Windows.Forms.ToolStripButton Nouveau;
    private System.Windows.Forms.ToolStripButton Supprimer;
    private System.Windows.Forms.ToolStripSeparator sep1;
    public System.Windows.Forms.ToolStripButton Importer;
    public System.Windows.Forms.ToolStripButton Apercu;
    public System.Windows.Forms.TextBox Recherche;
    public System.Windows.Forms.ComboBox ComboRech;
    public System.Data.OleDb.OleDbConnection oleConnect;
    public System.Data.DataSet DSStd;
    public System.Windows.Forms.BindingSource BSource;
    public System.Windows.Forms.StatusStrip Status;
    public System.Windows.Forms.ToolStripProgressBar Barre;
    public System.Windows.Forms.ToolStripStatusLabel LStatus;
    public System.Data.OleDb.OleDbCommand oleCommandLib;
    public System.Windows.Forms.DataGridView DGVDefaut;
    public System.Windows.Forms.Panel panel1;
    public System.Windows.Forms.Label LRef;
    public System.Windows.Forms.TextBox TRef;
  }
}