using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace EnvoiCommandeCRM.Standard
{
  public partial class UFStdData : EnvoiCommandeCRM.UFStd
  {
    public UFStdData()
    {
      InitializeComponent();
    }

    public String NomTable;

    public virtual void Quitter_Click(object sender, EventArgs e)
    {
    
      DGVDefaut.EndEdit();
      BSource.EndEdit();
      /*if (DSStd.Tables[0].GetChanges() != null)
      {
        if (MessageBox.Show("Voulez-vous enregistrer les modifications ?", "Quitter ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
        {
          try
          {
            oleDAC.Update(DSStd.Tables[0]);
            DSStd.AcceptChanges();
          }
          catch (Exception ex)
          {
            LStatus.Text = Commun.GestErreur.Ajoute(this.Name, ex);
          }
        }
      }
      
      Close();*/
    }

    private void Recherche_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == 13)
      {
        BSource.RemoveFilter();
        try
        {
          BSource.Filter = ComboRech.SelectedValue + " LIKE '%" + Recherche.Text + "%'";
        }
        catch
        {
          BSource.Filter = ComboRech.SelectedValue + " = " + Recherche.Text;
        }
      }    
    }

    private void UFStdData_Load(object sender, EventArgs e)
    {
        DGVDefaut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        DGVDefaut.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

      /*
     try
     {
       oleConnect.ConnectionString = Commun.Connection.CString();
       oleConnect.Open();

       BarreMenu.Items["Apercu"].Visible = false;
       DSStd.Reset();
      
       oleDAC.Fill(DSStd);
       oleDAC.TableMappings.Clear();
       oleDAC.TableMappings.Add(DSStd.Tables[0].TableName, DSStd.Tables[0].TableName);
       BSource.DataMember = DSStd.Tables[0].TableName;
       DGVDefaut.DataSource = BSource;
       String req = "SELECT LACHAMP,LALIBELLE,LARECHERCHE,LALISTABLE,LAFORMAT FROM LANGUE WHERE LATABLE = '" + NomTable + "' ORDER BY LALISTABLE";
       oleCommandLib.CommandText = req;
       OleDbDataReader Reader = oleCommandLib.ExecuteReader();
       Int16 I = 0;
       Int16 C = 0;
       if (Reader.Read())
       {
         this.Text = Reader.GetString(1);
       }
       while (Reader.Read())
       {
         oleDAC.TableMappings[0].ColumnMappings.Add(Reader.GetString(0), Reader.GetString(0));
         for (Int16 T = 0; T <= DGVDefaut.Columns.Count - 1; T++)
         {
           if (DGVDefaut.Columns[T].DataPropertyName == Reader.GetString(0))
           {
             C = T;
           }
         }
         if (Reader.GetString(4) != "")
         {
           DGVDefaut.Columns[C].DefaultCellStyle.Format = Reader.GetString(4);
         }
         DGVDefaut.Columns[C].DisplayIndex = I;
         DGVDefaut.Columns[C].HeaderText = Reader.GetString(1);
         if (Reader.GetInt32(3) == 0)
         {
           DGVDefaut.Columns[C].Visible = false;
         }
         I++;
       }
       Reader.Close();
       DGVDefaut.AllowUserToAddRows = true;
       DSStd.Tables.Add("Recherche");
       oleDAR.Fill(DSStd.Tables["Recherche"]);
       ComboRech.DataSource = DSStd.Tables["Recherche"];
       ComboRech.DisplayMember = "LALIBELLE";
       ComboRech.ValueMember = "LACHAMP";
        
     }
     catch (Exception ex)
     {
       LStatus.Text = Commun.GestErreur.Ajoute(this.Name, ex);
     }
       */
    }

    private void DGVDefaut_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
      MessageBox.Show("Mauvais format de chaine saisi");
    }

    public virtual void Valide_Click(object sender, EventArgs e)
    {
      DGVDefaut.EndEdit();
      BSource.EndEdit();
      /*
      if (DSStd.Tables[0].GetChanges() != null)
      {
        try
        {
          oleDAC.Update(DSStd.Tables[0]);
          DSStd.AcceptChanges();
        }
        catch (Exception ex)
        {
          LStatus.Text = Commun.GestErreur.Ajoute(this.Name, ex);
        }
      }
      */ 
    }

    private void UFStdData_FormClosed(object sender, FormClosedEventArgs e)
    {
      oleConnect.Close();
    }

    private void DGVDefaut_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
    {
           
    }

    private void DGVDefaut_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
    {
        if (MessageBox.Show("Voulez-vous supprimer la ligne ?", "Suppression ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
        {
        e.Cancel = true;
        }

    }

    public virtual void Apercu_Click(object sender, EventArgs e)
    {

    }

    
  }
}
