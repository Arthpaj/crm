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
    public partial class UFAjoutLogiciel : Form
    {
        public String lblNomUser;
        public String lblIdClient;
        public String lblClientSage;
        public String lblSocSage;
        public String lblIdUserCRM = "";

        public String lblRandomGuid = "";
        public string LibelleLogiciel = "";
        //public Guid CodeLogiciel;  //20191029
        public Int32 CodeLogiciel;
        public Boolean Validation = false;

        public MySqlConnection connMySQL;
        public MySqlCommand CommandCRM;
        public MySqlCommand ComInsert;

        public UFAjoutLogiciel()
        {
            InitializeComponent();
        }

        private void UFAjoutLogiciel_Load(object sender, EventArgs e)
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

                // Chargement Liste Type 
                DSType.Tables[0].Clear();

                string chaineSQL = "SELECT cf_1047id AS Type, cf_1047 AS valeur FROM vtiger_cf_1047 ORDER BY cf_1047";

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


                // Charge Liste Editeur
                DSEditeur.Tables[0].Clear();
             
                string chaineSQL2 = "SELECT cf_1045id AS Editeur, cf_1045 AS valeur FROM vtiger_cf_1045 ORDER BY cf_1045";
                //MySqlDataAdapter DACEditeur = new MySqlDataAdapter();
                //DACEditeur.SelectCommand.CommandText = chaineSQL2;
                MySqlCommand commandEditeur = new MySqlCommand(chaineSQL2, connMySQL);
                MySqlDataAdapter DACEditeur = new MySqlDataAdapter();
                DACEditeur.SelectCommand = commandEditeur;

                DACEditeur.Fill(DSEditeur.Tables[0]);
                DACEditeur.TableMappings.Clear();
                DACEditeur.TableMappings.Add(DSEditeur.Tables[0].TableName, DSEditeur.Tables[0].TableName);

                SEditeur.DataSource = DSEditeur.Tables[0];
                SEditeur.DisplayMember = "valeur";
                SEditeur.ValueMember = "Editeur";
                SEditeur.SelectedIndex = -1;

                // Charge Liste Gamme
                DSGamme.Tables[0].Clear();
                /*  //20191029
                string chaineSQL3 =
                    "SELECT DISTINCT StringMap_3.[Value] AS Gamme,StringMap_3.[AttributeValue] AS valeur "
                    + "FROM New_ParcGestionExtensionBase "
                    + "LEFT OUTER JOIN StringMap StringMap_3 ON New_ParcGestionExtensionBase.New_Gamme = StringMap_3.AttributeValue AND StringMap_3.AttributeName = 'New_Gamme' ORDER BY StringMap_3.[Value]";
                */
                string chaineSQL3 = "SELECT cf_1049id AS Gamme, cf_1049 AS valeur FROM vtiger_cf_1049 ORDER BY cf_1049";
                //MySqlDataAdapter DACGamme = new MySqlDataAdapter();
                //DACGamme.SelectCommand.CommandText = chaineSQL3;
                MySqlCommand commandGamme = new MySqlCommand(chaineSQL3, connMySQL);
                MySqlDataAdapter DACGamme = new MySqlDataAdapter();
                DACGamme.SelectCommand = commandGamme;

                DACGamme.Fill(DSGamme.Tables[0]);
                DACGamme.TableMappings.Clear();
                DACGamme.TableMappings.Add(DSGamme.Tables[0].TableName, DSGamme.Tables[0].TableName);

                SGamme.DataSource = DSGamme.Tables[0];
                SGamme.DisplayMember = "valeur";
                SGamme.ValueMember = "Gamme";
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

            //oleConnectCRM.Close();
            connMySQL.Close();
            Close();
        }

        private void BoutValid_Click(object sender, EventArgs e)
        {
            ValidationSaisie();
        }

        private void ValidationSaisie()
        {
            //MySqlTransaction transaction;
            //transaction = connMySQL.BeginTransaction();

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

                LibelleLogiciel = SType.Text + " - " + SEditeur.Text + " - " + SGamme.Text + " - " + SVersion.Text;
                //20191029
                string NomLogiciel = SType.Text + " - " + SEditeur.Text + " - " + SGamme.Text;
                Guid Code_at_key = Guid.NewGuid();
                lblRandomGuid = Code_at_key.ToString();

                CodeLogiciel = 0;
                string lblCodeLogiciel = CodeLogiciel.ToString();
                string no_CodeLogiciel = "PA" + CodeLogiciel.ToString();

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
                string SQL0 = "SELECT SUBSTRING(parclogiciel_no,3, length(parclogiciel_no) -2) as new_no FROM `vtiger_parclogiciel`  order by parclogicielid desc limit 1";
                CommandCRM.CommandText = SQL0;
                Int32 num_log = Int32.Parse(CommandCRM.ExecuteScalar().ToString());
                num_log = num_log + 1;
                PA_No = "PA" + num_log.ToString();

                string SQL1 = "UPDATE vtiger_crmentity_seq SET id = id + 1; ";

                string SQL2 = "INSERT INTO vtiger_crmentity (crmid, smcreatorid, smownerid, modifiedby, setype, createdtime, modifiedtime, source, label) VALUES ( " +
                    "(SELECT id FROM vtiger_crmentity_seq LIMIT 1), " + lblIdUserCRM + "," + lblIdUserCRM + "," + lblIdUserCRM + ",'ParcLogiciel'," +
                    "'" + dateJour + "','" + dateJour + "','SAGE','" + NomLogiciel + "');";

                string chaineSQL1 = "INSERT INTO vtiger_parclogiciel (parclogicielid, parclogiciel_no, cf_accounts_id, cf_societes_id, at_key, nom) VALUES (" +
                "(SELECT id FROM vtiger_crmentity_seq LIMIT 1), " +
                "'" + PA_No + "'," +
                "'" + lblIdClient + "',0,'" + lblRandomGuid + "','" + NomLogiciel + "');";

                string chaineSQL = "INSERT INTO vtiger_parclogicielcf (parclogicielid, cf_1041, cf_1043, cf_1045, cf_1047, cf_1049, cf_1055) VALUES ( " +
                    "(SELECT id FROM vtiger_crmentity_seq LIMIT 1), " +
                    "'1','0',";
                chaineSQL += "'" + SEditeur.Text + "','" + SType.Text + "','" + SGamme.Text + "','" + SVersion.Text + "');";

                string SQL = SQL1 + SQL2 + chaineSQL1 + chaineSQL;
                ComInsert.CommandText = SQL;
                //ComInsert.Transaction = transaction;
                /*
                                if (ComInsert.ExecuteNonQuery() > 0)
                                {
                                    LStatus.Text = "Création du logiciel dans la CRM OK";
                                    transaction.Commit();
                                }
                                else
                                {
                                    LStatus.Text = "Échec de la création du logiciel dans la CRM";
                                    try
                                    {
                                        transaction.Rollback();
                                    }
                                    catch (Exception ex2)
                                    { }
                                }
                */
                // Envoi dans la CRM : création du logiciel
                string url = Properties.Settings.Default.URL_Aditiger;
                url += "/apirest/post/ParcLogiciel";
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

                    data["Type"] = SType.Text;
                    data["Editeur"] = SEditeur.Text;
                    data["Gamme"] = SGamme.Text;
                    data["Version"] = SVersion.Text;
                    try
                    {
                        var response = wb.UploadValues(url, "POST", data);
                        string responseInString = Encoding.UTF8.GetString(response);
                        LStatus.Text = "Création du logiciel dans la CRM OK";
                    }
                    catch (Exception ex2)
                    {
                        LStatus.Text = "Échec de la création du logiciel dans la CRM";
                    }
                }
                Validation = true;
            }
            catch (Exception ex)
            {
                LStatus.Text = Commun.GestErreur.Ajoute(this.Name, ex);
                try
                {
                    //transaction.Rollback();
                }
                catch (Exception ex2)
                { }
            }

        }


    }
}
