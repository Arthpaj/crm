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
    public partial class UFAjoutContact : Form
    {
        public String lblNomUser;
        public String lblIdClient;
        public String lblClientSage;
        public String lblSocSage;
        public String lblIdUserCRM="";
        public String lblIdProprio = "";
        public string LibelleContact = "";
        //public Guid CodeContact;  //20191029
        public Int32 CodeContact;
        public Boolean Validation = false;

        public MySqlConnection connMySQL;
        public MySqlCommand CommandCRM;
        public MySqlCommand ComInsert;

        public UFAjoutContact()
        {
            InitializeComponent();
        }

        public class Choix_Titre
        {
            public string NameTitre { get; private set; }
            public Int16 ValueTitre { get; private set; }
            public Choix_Titre(string name, Int16 value)
            {
                NameTitre = name;
                ValueTitre = value;
            }

            private static readonly List<Choix_Titre> possibleChoixTitre = new List<Choix_Titre>
            {
                { new Choix_Titre("Mr", 1) },
                { new Choix_Titre("Mme", 2) },
                { new Choix_Titre("Mlle", 3) },
                { new Choix_Titre("Me", 4) },
                { new Choix_Titre("Dr", 5) }
            };

            public static List<Choix_Titre> GetChoixTitre()
            {
                return possibleChoixTitre;
            }
        }

        private void UFAjoutContact_Load(object sender, EventArgs e)
        {
          try
          {

            /* if (oleConnectCRM.State != ConnectionState.Open)
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

            // Remplissage de la liste des civilités
            SCivilite.DataSource = Choix_Titre.GetChoixTitre();
            SCivilite.DisplayMember = "NameTitre";
            SCivilite.ValueMember = "ValueTitre";

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
                string lib = SPrenom.Text.Replace("'", "''") + " " + SNom.Text.Replace("'", "''");
                //-- Gestion de l'autoincrement
                int dateJ = DateTime.Today.Day;
                int dateM = DateTime.Today.Month;
                int dateA = DateTime.Today.Year;
                int dateH = DateTime.Now.Hour;
                int dateMn = DateTime.Now.Minute;
                int dateS = DateTime.Now.Second;

                string dateJour = dateA.ToString("0000") + "-" + dateM.ToString("00") + "-" + dateJ.ToString("00") + " " +
                    dateH.ToString("00") + ":" + dateMn.ToString("00") + ":" + dateS.ToString("00");

                // Recherche no de contact CONxxxx
                string CON_No = "";
                string SQL0 = "SELECT SUBSTRING(contact_no,4, length(contact_no) -3) as new_no FROM `vtiger_contactdetails`  order by contactid desc limit 1";
                ComInsert.CommandText = SQL0;
                Int32 num_Contact = Int32.Parse(ComInsert.ExecuteScalar().ToString());
                num_Contact = num_Contact + 1;
                CON_No = "CON" + num_Contact.ToString();

                string SQL1 = "UPDATE vtiger_crmentity_seq SET id = id + 1; ";

                string SQL2 = "INSERT INTO vtiger_crmentity (crmid, smcreatorid, smownerid, modifiedby, setype, createdtime, modifiedtime, source, label) VALUES ( " +
                    "(SELECT id FROM vtiger_crmentity_seq LIMIT 1), " + lblIdUserCRM + "," + lblIdUserCRM + "," +lblIdUserCRM + ",'Contact'," + 
                    "'" + dateJour + "','" + dateJour + "','SAGE','" + lib + "');";

                string chaineSQL1 =
                    "INSERT INTO vtiger_contactdetails (contactid, contact_no, accountid, title, firstname, lastname, salutation, email, phone, mobile) " +
                    "VALUES( (SELECT id FROM vtiger_crmentity_seq LIMIT 1), " + "'" + CON_No + "'," +
                    "'" + lblIdClient + "','" + SFonction.Text.Replace("'", "''") + "','" +
                    SPrenom.Text.Replace("'", "''") + "','" + SNom.Text.Replace("'", "''") + "','" + SCivilite.Text + "', '" +
                    SEmail.Text + "','" + STelephone.Text + "','" + SPortable.Text + "'); ";

                string chaineSQL2 = "INSERT INTO vtiger_contactaddress (contactaddressid) " +
                    "VALUES( (SELECT id FROM vtiger_crmentity_seq LIMIT 1) ); ";
                
                string chaineSQL3 = "INSERT INTO vtiger_contactscf (contactid) " +
                    "VALUES( (SELECT id FROM vtiger_crmentity_seq LIMIT 1) ); ";
                
                string chaineSQL4 = "INSERT INTO vtiger_contactsubdetails (contactsubscriptionid) " +
                    "VALUES( (SELECT id FROM vtiger_crmentity_seq LIMIT 1) ); ";
                
                string SQL = SQL1 + SQL2 + chaineSQL1 + chaineSQL2 + chaineSQL3 + chaineSQL4;
                ComInsert.CommandText = SQL;
                //ComInsert.Transaction = transaction;
                /*
                                if (ComInsert.ExecuteNonQuery() > 0)
                                {
                                    LStatus.Text = "Création du contact dans la CRM OK";
                                    transaction.Commit();
                                }
                                else
                                {
                                    LStatus.Text = "Échec de la création du contact dans la CRM";
                                    try
                                    {
                                        transaction.Rollback();
                                    }
                                    catch (Exception ex2)
                                    { }
                                }
                */
                // Envoi dans la CRM : création du contact
                string url = Properties.Settings.Default.URL_Aditiger;
                url += "/apirest/post/Contacts";
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

                    data["civilite"] = SCivilite.Text;
                    data["Nom"] = SNom.Text;
                    data["prenom"] = SPrenom.Text;
                    data["telephone_ligne_directe"] = STelephone.Text;
                    data["Mobile"] = SPortable.Text;
                    data["Fonction"] = SFonction.Text;
                    data["Email"] = SEmail.Text;
                    try
                    {
                        var response = wb.UploadValues(url, "POST", data);
                        string responseInString = Encoding.UTF8.GetString(response);
                        LStatus.Text = "Création du contact dans la CRM OK";
                    }
                    catch (Exception ex2)
                    {
                        LStatus.Text = "Échec de la création du contact dans la CRM";
                    }
                }
                LibelleContact = SPrenom.Text + " " + SNom.Text;
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
