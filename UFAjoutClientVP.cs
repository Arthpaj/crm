using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace EnvoiCommandeCRM
{
    public partial class UFAjoutClientVP : Form
    {
        public String lblNomVP;
        public String lblAdresse1="";
        public String lblAdresse2 = "";
        public String lblVille = "";
        public String lblCP = "";
        public String lblTel = "";

        public String NomVP;
        public String Adresse1VP = "";
        public String Adresse2VP = "";
        public String VilleVP = "";
        public String CPVP = "";
        public String TelVP = "";

        public Boolean Validation = false;

        public UFAjoutClientVP()
        {
            InitializeComponent();
        }

        private void UFAjoutClientVP_Load(object sender, EventArgs e)
        {
          try
          {
            if (oleConnect.State != ConnectionState.Open)
            {
                //oleConnect.ConnectionString = Commun.Connection.CString();
                oleConnect.ConnectionString = Properties.Settings.Default.VpTranferConnectionString;
                oleConnect.Open();
            }
            SNom.Text = lblNomVP;
            SAdresse1.Text = lblAdresse1;
            SAdresse2.Text = lblAdresse2;
            SCP.Text = lblCP;
            SVille.Text = lblVille;
            STelephone.Text = lblTel;

          }
          catch (Exception ex)
          {
              LStatus.Text = Commun.GestErreur.Ajoute(this.Name, ex);
          }
        }

        private void BoutExit_Click(object sender, EventArgs e)
        {
            if (!Validation)
            {
                if (MessageBox.Show("Voulez-vous valider la saisie ?", "Quitter ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    ValidationSaisie();
            }

            oleConnect.Close();
            Close();
        }

        private void BoutValid_Click(object sender, EventArgs e)
        {
            ValidationSaisie();
        }

        private void ValidationSaisie()
        {
            try
            {
                string chaineSQL1 =
                    "INSERT INTO ClientVersVP (Nom, CP, Ville, Tel, Adresse1, Adresse2) " +
                    "VALUES('" + SNom.Text.Replace("'", "''") + "','" + SCP.Text + "','" + SVille.Text.Replace("'", "''") + "','" + STelephone.Text + "','" +
                    SAdresse1.Text.Replace("'", "''") + "','" + SAdresse2.Text.Replace("'", "''") + "')";
                    
                oleComInsert.CommandText = chaineSQL1;
                oleComInsert.ExecuteNonQuery();

                NomVP = SNom.Text;
                CPVP = SCP.Text;
                VilleVP = SVille.Text;
                TelVP = STelephone.Text;
                Adresse1VP = SAdresse1.Text;
                Adresse2VP = SAdresse2.Text;
                Validation = true;

            }
            catch (Exception ex)
            {
                LStatus.Text = Commun.GestErreur.Ajoute(this.Name, ex);
            }

        }







    }
}
