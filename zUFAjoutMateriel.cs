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
    public partial class UFAjoutMateriel : Form
    {
        public String lblNomUser;
        public String lblIdClient;
        public String lblIdUserCRM = "";
        //public String lblIdProprio = "";
        public String lblRandomGuid = "";
        public string LibelleMateriel = "";
        public Guid CodeMateriel;
        public Boolean Validation = false;

        public UFAjoutMateriel()
        {
            InitializeComponent();
        }

        private void UFAjoutMateriel_Load(object sender, EventArgs e)
        {
            try
            {
                if (oleConnectCRM.State != ConnectionState.Open)
                {
                    oleConnectCRM.ConnectionString = Properties.Settings.Default.CRMConnectionString;
                    oleConnectCRM.Open();
                }

                lblNomUser = System.Environment.UserName;
                CodeMateriel = Guid.NewGuid();
                lblRandomGuid = CodeMateriel.ToString();

                // Récup GUID de l'utilisateur
                string SQL = "SELECT SystemUserId FROM SystemUserBase WHERE DomainName= '" + "GROUPEADINFO\\" + lblNomUser + "'";
                oleCommandCRM.CommandText = SQL;
                OleDbDataReader ReaderCRM = oleCommandCRM.ExecuteReader();
                if (ReaderCRM.Read())
                    lblIdUserCRM = ReaderCRM.GetGuid(0).ToString();
                ReaderCRM.Close();

                // Chargement Liste Type Matériel
                DSType.Tables[0].Clear();
                string chaineSQL =
                  "SELECT DISTINCT StringMap_2.[Value] AS Type,StringMap_2.[AttributeValue] AS valeur "
                   + "FROM New_ParcRseauExtensionBase "
                   + "LEFT OUTER JOIN StringMap StringMap_2 "
                   + "ON New_ParcRseauExtensionBase.New_Type = StringMap_2.AttributeValue AND StringMap_2.AttributeName = 'New_Type' ORDER BY StringMap_2.[Value]";
                oleDACType.SelectCommand.CommandText = chaineSQL;
                oleDACType.Fill(DSType.Tables[0]);
                oleDACType.TableMappings.Clear();
                oleDACType.TableMappings.Add(DSType.Tables[0].TableName, DSType.Tables[0].TableName);

                SType.DataSource = DSType.Tables[0];
                SType.DisplayMember = "Type";
                SType.ValueMember = "valeur";
                SType.SelectedIndex = -1;


                // Charge Liste Fabricant
                DSFabricant.Tables[0].Clear();
                string chaineSQL2 =
                    "SELECT DISTINCT StringMap_1.[Value] AS 'Fabricant',StringMap_1.[AttributeValue] AS valeur "
                    + "FROM New_ParcRseauExtensionBase LEFT OUTER JOIN StringMap StringMap_1 "
                    + "ON New_ParcRseauExtensionBase.New_Marque = StringMap_1.AttributeValue AND StringMap_1.AttributeName = 'New_Marque' ORDER BY StringMap_1.[Value]";
                oleDACFabricant.SelectCommand.CommandText = chaineSQL2;
                oleDACFabricant.Fill(DSFabricant.Tables[0]);
                oleDACFabricant.TableMappings.Clear();
                oleDACFabricant.TableMappings.Add(DSFabricant.Tables[0].TableName, DSFabricant.Tables[0].TableName);

                SFabricant.DataSource = DSFabricant.Tables[0];
                SFabricant.DisplayMember = "Fabricant";
                SFabricant.ValueMember = "valeur";
                SFabricant.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                LStatus.Text = Commun.GestErreur.Ajoute(this.Name, ex);
            }

        }

        private void BoutValid_Click(object sender, EventArgs e)
        {
            ValidationSaisie();
        }

        private void ValidationSaisie()
        {
            string TypeMat = "";
            string FabricantMat = "";

            if (SType.Text != "")
                TypeMat = SType.GetItemText(SType.SelectedValue.ToString());
            if (SFabricant.Text != "")
                FabricantMat = SFabricant.GetItemText(SFabricant.SelectedValue.ToString());

            string chaineSQL1 =
      "insert into New_ParcRseauBase "
        + "(CreatedBy,DeletionStateCode,ModifiedBy,New_ParcRseauId,OwningBusinessUnit,StateCode,StatusCode,OwningUser)"
        + "values ( '" + lblIdUserCRM + "',0,'" + lblIdUserCRM + "','" + lblRandomGuid + "','75a98c87-c39c-db11-8e28-001195222097',0,1,'" + lblIdUserCRM + "')";

            oleComInsert.CommandText = chaineSQL1;
            oleComInsert.ExecuteNonQuery();

            string chaineSQL = "insert into New_ParcRseauExtensionBase ";
            chaineSQL = chaineSQL + "(New_rseauid,New_ParcRseauId,New_designation ";
            if (SType.Text != "")
            { chaineSQL = chaineSQL + ",New_Type "; }
            if (SFabricant.Text != "")
            { chaineSQL = chaineSQL + ",New_Marque"; }
            chaineSQL = chaineSQL + ")";

            chaineSQL = chaineSQL + "values ( '" + lblIdClient + "','" + lblRandomGuid + "','" + SDesignation.Text + "' ";
            if (SType.Text != "")
            { chaineSQL = chaineSQL + "," + TypeMat; }
            if (SFabricant.Text != "")
            { chaineSQL = chaineSQL + "," + FabricantMat; }
            chaineSQL = chaineSQL + " )";

            oleComInsert.CommandText = chaineSQL;
            oleComInsert.ExecuteNonQuery();

            LibelleMateriel = SType.Text + " - " + SFabricant.Text + " - " + SDesignation.Text;
            Validation = true;           
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
    }
}
