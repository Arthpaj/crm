namespace EnvoiCommandeCRM
{
  partial class UFStd
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UFStd));
        this.Status = new System.Windows.Forms.StatusStrip();
        this.Barre = new System.Windows.Forms.ToolStripProgressBar();
        this.LNbr = new System.Windows.Forms.ToolStripStatusLabel();
        this.LStatus = new System.Windows.Forms.ToolStripStatusLabel();
        this.Status.SuspendLayout();
        this.SuspendLayout();
        // 
        // Status
        // 
        this.Status.BackColor = System.Drawing.SystemColors.Control;
        this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Barre,
            this.LNbr,
            this.LStatus});
        this.Status.Location = new System.Drawing.Point(0, 489);
        this.Status.Name = "Status";
        this.Status.Size = new System.Drawing.Size(574, 22);
        this.Status.TabIndex = 0;
        this.Status.Text = "statusStrip1";
        // 
        // Barre
        // 
        this.Barre.Name = "Barre";
        this.Barre.Size = new System.Drawing.Size(300, 16);
        this.Barre.Visible = false;
        // 
        // LNbr
        // 
        this.LNbr.Name = "LNbr";
        this.LNbr.Size = new System.Drawing.Size(19, 17);
        this.LNbr.Text = "    ";
        // 
        // LStatus
        // 
        this.LStatus.BackColor = System.Drawing.SystemColors.Control;
        this.LStatus.Name = "LStatus";
        this.LStatus.Size = new System.Drawing.Size(85, 17);
        this.LStatus.Text = "                          ";
        // 
        // UFStd
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.Lavender;
        this.ClientSize = new System.Drawing.Size(574, 511);
        this.Controls.Add(this.Status);
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.Name = "UFStd";
        this.ShowInTaskbar = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Formulaire Standard";
        this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UFStd_KeyPress);
        this.Status.ResumeLayout(false);
        this.Status.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    public System.Windows.Forms.StatusStrip Status;
    public System.Windows.Forms.ToolStripStatusLabel LStatus;
    public System.Windows.Forms.ToolStripProgressBar Barre;
    public System.Windows.Forms.ToolStripStatusLabel LNbr;
  }
}