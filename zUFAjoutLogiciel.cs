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
    public partial class UFAjoutLogiciel : Form
    {
        public String lblNomUser;
        public String lblIdClient;
        public String lblIdUserCRM = "";
        //public String lblIdProprio = "";
        public String lblRandomGuid = "";
        public string LibelleLogiciel = "";
        public Guid CodeLogiciel;
        public Boolean Validation = false;

        public UFAjoutLogiciel()
        {
            InitializeComponent();
        }

        private void UFAjoutLogiciel_Load(object sender, EventArgs e)
        {
          try
          {
            if (oleConnectCRM.State != ConnectionState.Open)
            {
                oleConnectCRM.ConnectionString = Properties.Settings.Default.CRMConnectionString;
                oleConnectCRM.Open();
            }

            lblNomUser = System.Environment.UserName;
            CodeLogiciel = Guid.NewGuid();
            lblRandomGuid = CodeLogiciel.ToString();

            // Récup GUID de l'utilisateur
            string SQL = "SELECT SystemUserId FROM SystemUserBase WHERE DomainName= '" + "GROUPEADINFO\\" + lblNomUser + "'";
            oleCommandCRM.CommandText = SQL;
            OleDbDataReader ReaderCRM = oleCommandCRM.ExecuteReader();
            if (ReaderCRM.Read())
                lblIdUserCRM = ReaderCRM.GetGuid(0).ToString();
            ReaderCRM.Close();

            // Chargement Liste Type 
            DSType.Tables[0].Clear();
            string chaineSQL =
                "SELECT DISTINCT StringMap_2.[Value] AS Type,StringMap_2.[AttributeValue] AS valeur "
                + " FROM New_ParcGestionExtensionBase "
                + " LEFT OUTER JOIN StringMap StringMap_2 ON New_ParcGestionExtensionBase.New_TypeG = StringMap_2.AttributeValue AND StringMap_2.AttributeName = 'New_TypeG' "
                + " ORDER BY StringMap_2.[Value]";
            oleDACType.SelectCommand.CommandText = chaineSQL;
            oleDACType.Fill(DSType.Tables[0]);
            oleDACType.TableMappings.Clear();
            oleDACType.TableMappings.Add(DSType.Tables[0].TableName, DSType.Tables[0].TableName);

            SType.DataSource = DSType.Tables[0];
            SType.DisplayMember = "Type";
            SType.ValueMember = "valeur";
            SType.SelectedIndex = -1;


            // Charge Liste Editeur
            DSEditeur.Tables[0].Clear();
            string chaineSQL2 =
                "SELECT DISTINCT StringMap_1.[Value] AS Editeur,StringMap_1.[AttributeValue] AS valeur "
                + "FROM New_ParcGestionExtensionBase "
                + "LEFT OUTER JOIN StringMap StringMap_1 ON New_ParcGestionExtensionBase.New_editeur = StringMap_1.AttributeValue AND StringMap_1.AttributeName = 'New_editeur' ORDER BY StringMap_1.[Value]";
            oleDACEditeur.SelectCommand.CommandText = chaineSQL2;
            oleDACEditeur.Fill(DSEditeur.Tables[0]);
            oleDACEditeur.TableMappings.Clear();
            oleDACEditeur.TableMappings.Add(DSEditeur.Tables[0].TableName, DSEditeur.Tables[0].TableName);

            SEditeur.DataSource = DSEditeur.Tables[0];
            SEditeur.DisplayMember = "Editeur";
            SEditeur.ValueMember = "valeur";
            SEditeur.SelectedIndex = -1;

            // Charge Liste Gamme
            DSGamme.Tables[0].Clear();
            string chaineSQL3 =
                "SELECT DISTINCT StringMap_3.[Value] AS Gamme,StringMap_3.[AttributeValue] AS valeur "
                + "FROM New_ParcGestionExtensionBase "
                + "LEFT OUTER JOIN StringMap StringMap_3 ON New_ParcGestionExtensionBase.New_Gamme = StringMap_3.AttributeValue AND StringMap_3.AttributeName = 'New_Gamme' ORDER BY StringMap_3.[Value]";
            oleDACGamme.SelectCommand.CommandText = chaineSQL3;
            oleDACGamme.Fill(DSGamme.Tables[0]);
            oleDACGamme.TableMappings.Clear();
            oleDACGamme.TableMappings.Add(DSGamme.Tables[0].TableName, DSGamme.Tables[0].TableName);

            SGamme.DataSource = DSGamme.Tables[0];
            SGamme.DisplayMember = "Gamme";
            SGamme.ValueMember = "valeur";
            SGamme.SelectedIndex = -1;

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

            oleConnectCRM.Close();
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
            string TypeLog = "";
            string EditeurLog = "";
            string GammeLog = "";

            if (SType.Text != "")
               TypeLog = SType.GetItemText(SType.SelectedValue.ToString());
            if (SEditeur.Text != "")
               EditeurLog = SEditeur.GetItemText(SEditeur.SelectedValue.ToString());
            if (SGamme.Text != "")
               GammeLog = SGamme.GetItemText(SGamme.SelectedValue.ToString());

            string chaineSQL1 =
                     "insert into New_ParcGestionBase "
                       + "(CreatedBy,DeletionStateCode,ModifiedBy,New_ParcGestionId,OwningBusinessUnit,StateCode,StatusCode,OwningUser) "
                       + "values ( '" + lblIdUserCRM + "',0,'" + lblIdUserCRM + "','" + lblRandomGuid + "','75a98c87-c39c-db11-8e28-001195222097',0,1,'" + lblIdUserCRM + "')";
           
            oleComInsert.CommandText = chaineSQL1;
            oleComInsert.ExecuteNonQuery();

            string chaineSQL = "insert into New_ParcGestionExtensionBase ";
            chaineSQL = chaineSQL + "(new_gestionid,New_ParcGestionId,New_Version";
            if (SEditeur.Text != "")
            { chaineSQL = chaineSQL + ",New_editeur"; }
            if (SType.Text != "")
            { chaineSQL = chaineSQL + ",New_TypeG"; }
            if (SGamme.Text != "")
            { chaineSQL = chaineSQL + ",New_Gamme"; }
            chaineSQL = chaineSQL + ") ";

            chaineSQL = chaineSQL + "values ( '" + lblIdClient + "' ";
            chaineSQL = chaineSQL + ",'" + lblRandomGuid + "' ";
            chaineSQL = chaineSQL + ",'" + SVersion.Text + "' ";
            if (SEditeur.Text != "")
            { chaineSQL = chaineSQL + "," + EditeurLog; }
            if (SType.Text != "")
            { chaineSQL = chaineSQL + "," + TypeLog; }
            if (SGamme.Text != "")
            { chaineSQL = chaineSQL + "," + GammeLog; }
            chaineSQL = chaineSQL + ")";

            oleComInsert.CommandText = chaineSQL;
           oleComInsert.ExecuteNonQuery();

            LibelleLogiciel = SType.Text + " - " + SEditeur.Text + " - " + SGamme.Text + " - " + SVersion.Text;
            Validation = true;
          }
          catch (Exception ex)
          {
              LStatus.Text = Commun.GestErreur.Ajoute(this.Name, ex);
          }

        }
    }
}
