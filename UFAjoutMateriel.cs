using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

using System.Net;
using System.Collections.Specialized;

namespace EnvoiCommandeCRM
{
    public partial class UFAjoutMateriel : Form
    {
        public String lblNomUser;
        public String lblIdClient;
        public String lblClientSage;
        public String lblSocSage;
        public String lblIdUserCRM = "";
        
        public String lblRandomGuid = "";
        public string LibelleMateriel = "";
        //public Guid CodeMateriel;
        public Int32 CodeMateriel;
        public Boolean Validation = false;

        public MySqlConnection connMySQL;
        public MySqlCommand CommandCRM;
        public MySqlCommand ComInsert;

        public UFAjoutMateriel()
        {
            InitializeComponent();
        }

        private void UFAjoutMateriel_Load(object sender, EventArgs e)
        {
            try
            {
                /*if (oleConnectCRM.State != ConnectionState.Open)
                {
                    oleConnectCRM.ConnectionString = Properties.Settings.Default.CRMConnectionString;
                    oleConnectCRM.Open();
                }*/

                string ConnectionMySql = Properties.Settings.Default.MySQLConnectionString;//"server=localhost;user=root;database=world;port=3306;password=******";
                connMySQL = new MySqlConnection(ConnectionMySql);
                connMySQL.Open();

                CommandCRM = new MySqlCommand();
                CommandCRM.Connection = connMySQL;
                ComInsert = new MySqlCommand();
                ComInsert.Connection = connMySQL;

                lblNomUser = System.Environment.UserName;

                // Récup de l'utilisateur
                lblIdUserCRM = "1";
                string SQL = "SELECT id FROM vtiger_users WHERE user_name = '" + lblNomUser + "'";
                CommandCRM.CommandText = SQL;
                MySqlDataReader ReaderCRM = CommandCRM.ExecuteReader();
                if (ReaderCRM.Read())
                    lblIdUserCRM = ReaderCRM.GetInt32(0).ToString();
                ReaderCRM.Close();

                // Chargement Liste Type Matériel
                DSType.Tables[0].Clear();

                string chaineSQL = "SELECT cf_1089id AS Type, cf_1089 AS valeur FROM vtiger_cf_1089 ORDER BY cf_1089";
                //MySqlDataAdapter DACType = new MySqlDataAdapter();
                //DACType.SelectCommand.CommandText = chaineSQL;
                MySqlCommand commandType = new MySqlCommand(chaineSQL, connMySQL);
                MySqlDataAdapter DACType = new MySqlDataAdapter();
                DACType.SelectCommand = commandType;

                DACType.Fill(DSType.Tables[0]);
                DACType.TableMappings.Clear();
                DACType.TableMappings.Add(DSType.Tables[0].TableName, DSType.Tables[0].TableName);

                SType.DataSource = DSType.Tables[0];
                SType.DisplayMember = "valeur";
                SType.ValueMember = "Type";
                SType.SelectedIndex = -1;


                // Charge Liste Fabricant
                DSFabricant.Tables[0].Clear();

                string chaineSQL2 = "SELECT cf_1091id AS 'Fabricant', cf_1091 AS valeur FROM vtiger_cf_1091 ORDER BY cf_1091";
                //MySqlDataAdapter DACFabricant = new MySqlDataAdapter();
                //DACFabricant.SelectCommand.CommandText = chaineSQL2;
                MySqlCommand commandFabricant = new MySqlCommand(chaineSQL2, connMySQL);
                MySqlDataAdapter DACFabricant = new MySqlDataAdapter();
                DACFabricant.SelectCommand = commandFabricant;

                DACFabricant.Fill(DSFabricant.Tables[0]);
                DACFabricant.TableMappings.Clear();
                DACFabricant.TableMappings.Add(DSFabricant.Tables[0].TableName, DSFabricant.Tables[0].TableName);

                SFabricant.DataSource = DSFabricant.Tables[0];
                SFabricant.DisplayMember = "valeur";
                SFabricant.ValueMember = "Fabricant";
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
            //MySqlTransaction transaction;
            //transaction = connMySQL.BeginTransaction();

            string TypeMat = "";
            string FabricantMat = "";

            if (SType.Text != "")
                TypeMat = SType.GetItemText(SType.SelectedValue.ToString());
            if (SFabricant.Text != "")
                FabricantMat = SFabricant.GetItemText(SFabricant.SelectedValue.ToString());

            //CodeMateriel = Guid.NewGuid();
            //lblRandomGuid = CodeMateriel.ToString();
            LibelleMateriel = SType.Text + " - " + SFabricant.Text + " - " + SDesignation.Text;
            Guid Code_at_key = Guid.NewGuid();
            lblRandomGuid = Code_at_key.ToString();

            //-- Gestion de l'autoincrement
            int dateJ = DateTime.Today.Day;
            int dateM = DateTime.Today.Month;
            int dateA = DateTime.Today.Year;
            int dateH = DateTime.Now.Hour;
            int dateMn = DateTime.Now.Minute;
            int dateS = DateTime.Now.Second;

            string dateJour = dateA.ToString("0000") + "-" + dateM.ToString("00") + "-" + dateJ.ToString("00") + " " +
                dateH.ToString("00") + ":" + dateMn.ToString("00") + ":" + dateS.ToString("00");

            string PA_No = "";
            string SQL0 = "SELECT SUBSTRING(parcmateriel_no,3, length(parcmateriel_no) -2) as new_no FROM `vtiger_parcmateriel`  order by parcmaterielid desc limit 1";
            CommandCRM.CommandText = SQL0;
            Int32 num_mat = Int32.Parse(CommandCRM.ExecuteScalar().ToString());
            num_mat = num_mat + 1;
            PA_No = "PA" + num_mat.ToString();

            string SQL1 = "UPDATE vtiger_crmentity_seq SET id = id + 1; ";

            string SQL2 = "INSERT INTO vtiger_crmentity (crmid, smcreatorid, smownerid, modifiedby, setype, createdtime, modifiedtime, source, label) VALUES ( " +
                "(SELECT id FROM vtiger_crmentity_seq LIMIT 1), " + lblIdUserCRM + "," + lblIdUserCRM + "," + lblIdUserCRM + ",'ParcMateriel'," +
                "'" + dateJour + "','" + dateJour + "','SAGE','" + LibelleMateriel + "');";

            string chaineSQL1 = "INSERT INTO vtiger_parcmateriel (parcmaterielid, parcmateriel_no, cf_accounts_id, cf_societes_id, at_key, nomdumateriel) VALUES (" +
            "(SELECT id FROM vtiger_crmentity_seq LIMIT 1), " +
            "'" + PA_No + "'," +
            "'" + lblIdClient + "',0,'" + lblRandomGuid + "','" + LibelleMateriel + "');";

            string chaineSQL = "INSERT INTO vtiger_parcmaterielcf (parcmaterielid, cf_1089, cf_1091, cf_1093) VALUES ( " +
                "(SELECT id FROM vtiger_crmentity_seq LIMIT 1), ";
            //chaineSQL += TypeMat + "," + FabricantMat + "," + SDesignation.Text + ")";
            chaineSQL += "'" + SType.Text + "','" + SFabricant.Text + "','" + SDesignation.Text + "');";

            string SQL = SQL1 + SQL2 + chaineSQL1 + chaineSQL;
            ComInsert.CommandText = SQL;
            //ComInsert.Transaction = transaction;
/*
            if (ComInsert.ExecuteNonQuery() > 0)
            {
                LStatus.Text = "Création du matériel dans la CRM OK";
                transaction.Commit();
            }
            else
            {
                LStatus.Text = "Échec de la création du matériel dans la CRM";
                try
                {
                    transaction.Rollback();
                }
                catch (Exception ex2)
                { }
            }
*/
            // Envoi dans la CRM : création du materiel
            string url = Properties.Settings.Default.URL_Aditiger;
            url += "/apirest/post/ParcMateriel";
            string cleToken = Properties.Settings.Default.Cle_Token.Trim();

            using (var wb = new WebClient())
            {
                var data = new NameValueCollection();
                data["token"] = Commun.Commun.GetToken(cleToken);
                data["societes"] = lblSocSage;
                data["accounts"] = lblClientSage;
                data["users"] = System.Environment.UserName;
                data["origin"] = "SAGE";
                data["key"] = "";

                data["Designation"] = SDesignation.Text;
                data["Type"] = SType.Text;
                data["FabricantFournisseur"] = SFabricant.Text;
                data["NoSerie"] = "";
                try
                {
                    var response = wb.UploadValues(url, "POST", data);
                    string responseInString = Encoding.UTF8.GetString(response);
                    LStatus.Text = "Création du matériel dans la CRM OK";
                }
                catch (Exception ex2)
                {
                    LStatus.Text = "Échec de la création du matériel dans la CRM";
                }
            }

            Validation = true;           
        }

        private void BoutExit_Click(object sender, EventArgs e)
        {
            if (!Validation)
            {
                if (MessageBox.Show("Voulez-vous valider la saisie ?", "Quitter ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    ValidationSaisie();
            }

            //oleConnectCRM.Close();
            Close();
        }
    }
}
