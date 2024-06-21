namespace ListeSage.Divers
{
  partial class UFInputBox
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
      this.BarreMenu = new System.Windows.Forms.ToolStrip();
      this.BoutExit = new System.Windows.Forms.ToolStripButton();
      this.BoutValid = new System.Windows.Forms.ToolStripButton();
      this.Reponse = new System.Windows.Forms.TextBox();
      this.Question = new System.Windows.Forms.Label();
      this.BarreMenu.SuspendLayout();
      this.SuspendLayout();
      // 
      // BarreMenu
      // 
      this.BarreMenu.BackgroundImage = global::ListeSage.Properties.Resources.degrade2;
      this.BarreMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
      this.BarreMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BoutExit,
            this.BoutValid});
      this.BarreMenu.Location = new System.Drawing.Point(0, 0);
      this.BarreMenu.Name = "BarreMenu";
      this.BarreMenu.Size = new System.Drawing.Size(512, 39);
      this.BarreMenu.TabIndex = 2;
      this.BarreMenu.Text = "toolStrip1";
      // 
      // BoutExit
      // 
      this.BoutExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BoutExit.Image = global::ListeSage.Properties.Resources.quitter2;
      this.BoutExit.ImageTransparentColor = System.Drawing.Color.White;
      this.BoutExit.Name = "BoutExit";
      this.BoutExit.Size = new System.Drawing.Size(36, 36);
      this.BoutExit.Text = "Annuler le choix";
      this.BoutExit.Click += new System.EventHandler(this.BoutExit_Click);
      // 
      // BoutValid
      // 
      this.BoutValid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BoutValid.Image = global::ListeSage.Properties.Resources.valide;
      this.BoutValid.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BoutValid.Name = "BoutValid";
      this.BoutValid.Size = new System.Drawing.Size(36, 36);
      this.BoutValid.Text = "toolStripButton2";
      this.BoutValid.Click += new System.EventHandler(this.BoutValid_Click);
      // 
      // Reponse
      // 
      this.Reponse.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Reponse.Location = new System.Drawing.Point(45, 96);
      this.Reponse.Name = "Reponse";
      this.Reponse.Size = new System.Drawing.Size(410, 29);
      this.Reponse.TabIndex = 3;
      // 
      // Question
      // 
      this.Question.AutoSize = true;
      this.Question.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Question.Location = new System.Drawing.Point(41, 61);
      this.Question.Name = "Question";
      this.Question.Size = new System.Drawing.Size(86, 22);
      this.Question.TabIndex = 4;
      this.Question.Text = "Question";
      // 
      // UFInputBox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.ClientSize = new System.Drawing.Size(512, 164);
      this.Controls.Add(this.Question);
      this.Controls.Add(this.Reponse);
      this.Controls.Add(this.BarreMenu);
      this.Name = "UFInputBox";
      this.Text = "Entete";
      this.Controls.SetChildIndex(this.BarreMenu, 0);
      this.Controls.SetChildIndex(this.Reponse, 0);
      this.Controls.SetChildIndex(this.Question, 0);
      this.BarreMenu.ResumeLayout(false);
      this.BarreMenu.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip BarreMenu;
    private System.Windows.Forms.ToolStripButton BoutExit;
    private System.Windows.Forms.ToolStripButton BoutValid;
    public System.Windows.Forms.TextBox Reponse;
    public System.Windows.Forms.Label Question;

  }
}
