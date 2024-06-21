namespace EnvoiCommandeCRM.Standard
{
  partial class UFStdData
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UFStdData));
        this.Recherche = new System.Windows.Forms.TextBox();
        this.ComboRech = new System.Windows.Forms.ComboBox();
        this.DGVDefaut = new System.Windows.Forms.DataGridView();
        this.DSStd = new System.Data.DataSet();
        this.BSource = new System.Windows.Forms.BindingSource(this.components);
        this.oleConnect = new System.Data.OleDb.OleDbConnection();
        this.oleCommandLib = new System.Data.OleDb.OleDbCommand();
        this.BarreMenu = new System.Windows.Forms.ToolStrip();
        this.Quitter = new System.Windows.Forms.ToolStripButton();
        this.Valide = new System.Windows.Forms.ToolStripButton();
        this.Apercu = new System.Windows.Forms.ToolStripButton();
        ((System.ComponentModel.ISupportInitialize)(this.DGVDefaut)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.DSStd)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.BSource)).BeginInit();
        this.BarreMenu.SuspendLayout();
        this.SuspendLayout();
        // 
        // Recherche
        // 
        this.Recherche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.Recherche.BackColor = System.Drawing.Color.Lavender;
        this.Recherche.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Recherche.Location = new System.Drawing.Point(446, 22);
        this.Recherche.Name = "Recherche";
        this.Recherche.Size = new System.Drawing.Size(128, 20);
        this.Recherche.TabIndex = 7;
        this.Recherche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Recherche_KeyPress);
        // 
        // ComboRech
        // 
        this.ComboRech.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.ComboRech.BackColor = System.Drawing.Color.Lavender;
        this.ComboRech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.ComboRech.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.ComboRech.FormattingEnabled = true;
        this.ComboRech.Location = new System.Drawing.Point(446, 0);
        this.ComboRech.Name = "ComboRech";
        this.ComboRech.Size = new System.Drawing.Size(128, 22);
        this.ComboRech.TabIndex = 6;
        // 
        // DGVDefaut
        // 
        this.DGVDefaut.AllowUserToResizeRows = false;
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
        this.DGVDefaut.Size = new System.Drawing.Size(574, 450);
        this.DGVDefaut.TabIndex = 8;
        this.DGVDefaut.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DGVDefaut_DataError);
        this.DGVDefaut.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DGVDefaut_RowsRemoved);
        this.DGVDefaut.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DGVDefaut_UserDeletingRow);
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
        // oleConnect
        // 
        this.oleConnect.ConnectionString = "Provider=SQLNCLI11;Data Source=srv1-sql2008;Integrated Security=SSPI;Initial Cata" +
            "log=Adinfo_Sage;Packet Size=4096;MARS Connection=True";
        // 
        // oleCommandLib
        // 
        this.oleCommandLib.Connection = this.oleConnect;
        // 
        // BarreMenu
        // 
        this.BarreMenu.AutoSize = false;
        this.BarreMenu.BackgroundImage = global::EnvoiCommandeCRM.Properties.Resources.degrade2;
        this.BarreMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
        this.BarreMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Quitter,
            this.Valide,
            this.Apercu});
        this.BarreMenu.Location = new System.Drawing.Point(0, 0);
        this.BarreMenu.Name = "BarreMenu";
        this.BarreMenu.Size = new System.Drawing.Size(574, 39);
        this.BarreMenu.TabIndex = 1;
        this.BarreMenu.Text = "toolStrip1";
        // 
        // Quitter
        // 
        this.Quitter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.Quitter.Image = global::EnvoiCommandeCRM.Properties.Resources.quitter2;
        this.Quitter.ImageTransparentColor = System.Drawing.Color.White;
        this.Quitter.Name = "Quitter";
        this.Quitter.Size = new System.Drawing.Size(36, 36);
        this.Quitter.Text = "Quitter";
        this.Quitter.ToolTipText = "Quitter";
        this.Quitter.Click += new System.EventHandler(this.Quitter_Click);
        // 
        // Valide
        // 
        this.Valide.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.Valide.Image = global::EnvoiCommandeCRM.Properties.Resources.valide;
        this.Valide.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.Valide.Name = "Valide";
        this.Valide.Size = new System.Drawing.Size(36, 36);
        this.Valide.Text = "Valider";
        this.Valide.ToolTipText = "Valider";
        this.Valide.Click += new System.EventHandler(this.Valide_Click);
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
        // UFStdData
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.ClientSize = new System.Drawing.Size(574, 511);
        this.Controls.Add(this.Recherche);
        this.Controls.Add(this.ComboRech);
        this.Controls.Add(this.DGVDefaut);
        this.Controls.Add(this.BarreMenu);
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.Name = "UFStdData";
        this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UFStdData_FormClosed);
        this.Load += new System.EventHandler(this.UFStdData_Load);
        this.Controls.SetChildIndex(this.BarreMenu, 0);
        this.Controls.SetChildIndex(this.DGVDefaut, 0);
        this.Controls.SetChildIndex(this.ComboRech, 0);
        this.Controls.SetChildIndex(this.Recherche, 0);
        ((System.ComponentModel.ISupportInitialize)(this.DGVDefaut)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.DSStd)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.BSource)).EndInit();
        this.BarreMenu.ResumeLayout(false);
        this.BarreMenu.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    public System.Windows.Forms.TextBox Recherche;
    public System.Windows.Forms.ComboBox ComboRech;
    public System.Windows.Forms.DataGridView DGVDefaut;
    public System.Data.DataSet DSStd;
    public System.Windows.Forms.BindingSource BSource;
    public System.Data.OleDb.OleDbConnection oleConnect;
    public System.Data.OleDb.OleDbCommand oleCommandLib;
    private System.Windows.Forms.ToolStripButton Quitter;
    private System.Windows.Forms.ToolStripButton Valide;
    protected System.Windows.Forms.ToolStripButton Apercu;
    public System.Windows.Forms.ToolStrip BarreMenu;
  }
}
