using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace EnvoiCommandeCRM
{
  public partial class UFStdDataComplexe : Form
  {
    public UFStdDataComplexe()
    {
      InitializeComponent();
    }

    public virtual void UFStdDataComplexe_Load(object sender, EventArgs e)
    {
        DGVDefaut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        DGVDefaut.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

      try
      {
        oleConnect.ConnectionString = Commun.Connection.CString();
        oleConnect.Open();

        TRef.ReadOnly = true;
      }
      catch (Exception ex)
      {
        LStatus.Text = Commun.GestErreur.Ajoute(this.Name, ex);
      }
    }

    private void Recherche_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == 13)
      {
        BSource.RemoveFilter();
        BSource.Filter = ComboRech.SelectedValue + " LIKE '%" + Recherche.Text + "%'";
      }  
    }

    private void UFStdDataComplexe_FormClosed(object sender, FormClosedEventArgs e)
    {
      oleConnect.Close();
    }

    private void Supprimer_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Voulez-vous supprimer la ligne ?", "Suppression ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
      {
        try
        {
          BSource.RemoveCurrent();
          TRef.ReadOnly = true;
        }
        catch (Exception ex)
        {
          LStatus.Text = Commun.GestErreur.Ajoute(this.Name, ex);
        }
      }
    }

    private void Nouveau_Click(object sender, EventArgs e)
    {
      try
      {
        BSource.AddNew();
        TRef.ReadOnly = false;
        TRef.Focus();
      }
      catch (Exception ex)
      {
        LStatus.Text = Commun.GestErreur.Ajoute(this.Name, ex);
      }
    }

    private void TRef_Leave(object sender, EventArgs e)
    {

    }

    private void Recherche_Leave(object sender, EventArgs e)
    {
      try
      {
        BSource.RemoveFilter();
        BSource.Filter = ComboRech.SelectedValue + " LIKE '%" + Recherche.Text + "%'";
      }
      catch { }
    }

    public virtual void Valide_Click(object sender, EventArgs e)
    {

    }

    public virtual void quitter_Click(object sender, EventArgs e)
    {

    }

    public virtual void Apercu_Click(object sender, EventArgs e)
    {

    }

    private void DGVDefaut_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
    {
        if (MessageBox.Show("Voulez-vous supprimer la ligne ?", "Suppression ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
        {
            e.Cancel = true;
        }
    }

   
  }
}
