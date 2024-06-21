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
    public partial class UFAjoutContact : Form
    {
        public String lblNomUser;
        public String lblIdClient;
        public String lblIdUserCRM="";
        public String lblIdProprio = "";
        public string LibelleContact = "";
        public Guid CodeContact;
        public Boolean Validation = false;

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

            if (oleConnectCRM.State != ConnectionState.Open)
            {
                oleConnectCRM.ConnectionString = Properties.Settings.Default.CRMConnectionString;
                oleConnectCRM.Open();
            }

            lblNomUser = System.Environment.UserName;
            // Récup GUID de l'utilisateur
            string SQL = "SELECT SystemUserId FROM SystemUserBase WHERE DomainName= '" + "GROUPEADINFO\\" + lblNomUser + "'";
            oleCommandCRM.CommandText = SQL;
            OleDbDataReader ReaderCRM = oleCommandCRM.ExecuteReader();
            if (ReaderCRM.Read())
                lblIdUserCRM = ReaderCRM.GetGuid(0).ToString();
            ReaderCRM.Close();

            // Récup Proprio
            SQL = "SELECT OwningUser FROM AccountBase WHERE AccountId= '" + lblIdClient + "'";
            oleCommandCRM.CommandText = SQL;
            ReaderCRM = oleCommandCRM.ExecuteReader();
            if (ReaderCRM.Read())
                lblIdProprio = ReaderCRM.GetGuid(0).ToString();
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
                CodeContact = Guid.NewGuid();
                string lblAutoGuid = CodeContact.ToString();
                string idclient = lblAutoGuid;
                string chaineSQL1 =
                    "INSERT INTO ContactBase (ContactId,PreferredContactMethodCode,DeletionStateCode,OwningUser,AccountId,ParticipatesInWorkflow,JobTitle,FirstName," +
                    "LastName,FullName,EMailAddress1,DoNotPhone,DoNotFax,DoNotEMail,DoNotPostalMail,DoNotBulkEMail," +
                    "CreditOnHold,CreatedBy,ModifiedBy,MobilePhone,Telephone1,StateCode,StatusCode,DoNotSendMM,Merged,OwningBusinessUnit) " +
                    "VALUES('" + lblAutoGuid + "',1,0,'" + lblIdUserCRM + "','" + lblIdClient + "'," +
                    "0,'" + SFonction.Text + "','" + SPrenom.Text + "','" + SNom.Text + "','" + SPrenom.Text + " " + SNom.Text + "','" + SEmail.Text + "'," +
                    "0,0,0,0,0,0,'" + lblIdUserCRM + "','" + lblIdUserCRM + "','" + STelephone.Text + "','" + SPortable.Text + "',0,1,0,0,'75a98c87-c39c-db11-8e28-001195222097') ";
                oleComInsert.CommandText = chaineSQL1;
                oleComInsert.ExecuteNonQuery();

                string chaineSQL2 =
                     "INSERT INTO ContactExtensionBase (ContactId,New_Titre)" +
                     "VALUES('" + lblAutoGuid + "'," + SCivilite.SelectedValue + ") ";
                oleComInsert.CommandText = chaineSQL2;
                oleComInsert.ExecuteNonQuery();

                string chaineSQL3 =
            "insert into PrincipalObjectAccess(PrincipalId,ObjectId,ObjectTypeCode,PrincipalTypeCode,AccessRightsMask,ChangedOn,InheritedAccessRightsMask) " +
            "values ('" + lblIdProprio + "','" + lblAutoGuid + "',2,8,0,getutcdate(),135069719)";
                oleComInsert.CommandText = chaineSQL3;
                oleComInsert.ExecuteNonQuery();
                /*
                            string lblAutoGuid2 = Guid.NewGuid().ToString();
                            string chaineSQL4 =
                                   "insert into CustomerAddressBase( CustomerAddressId,AddressNumber,ParentId,ObjectTypeCode,CreatedOn,ModifiedOn,DeletionStateCode)" +
                                   " values ('" + lblAutoGuid2 + "',1,'" + lblIdUserCRM + "',2,getutcdate(),getutcdate(),0)";
                            oleComInsert.CommandText = chaineSQL4;
                            oleComInsert.ExecuteNonQuery();

                            string lblAutoGuid3 = Guid.NewGuid().ToString();
                            string chaineSQL5 =
                                   "insert into CustomerAddressBase( CustomerAddressId,AddressNumber,ParentId,ObjectTypeCode,CreatedOn,ModifiedOn,DeletionStateCode)" +
                                   " values ('" + lblAutoGuid3 + "',2,'" + lblIdUserCRM + "',2,getutcdate(),getutcdate(),0)";
                            oleComInsert.CommandText = chaineSQL5;
                            oleComInsert.ExecuteNonQuery();

                            string referencingid = idclient;
                            Guid referencingidGuid = new Guid(referencingid);
                            string referencedid = lblIdClient;
                            Guid referencedidGuid = new Guid(referencedid);
                            OleDbCommand com2 = new OleDbCommand("p_GrantInheritedAccess", oleConnectCRM);
                            com2.CommandType = CommandType.StoredProcedure;
                            com2.Parameters.Add("@ReferencingObjectId", SqlDbType.UniqueIdentifier).Value = referencingidGuid;
                            com2.Parameters.Add("@ReferencingObjectTypeCode", SqlDbType.Int).Value = 2;
                            com2.Parameters.Add("@ReferencedObjectId", SqlDbType.UniqueIdentifier).Value = referencedidGuid;
                            com2.Parameters.Add("@ReferencedObjectTypeCode", SqlDbType.Int).Value = 1;
                            com2.ExecuteNonQuery();
                */
                LibelleContact = SPrenom.Text + " " + SNom.Text;
                Validation = true;

            }
            catch (Exception ex)
            {
                LStatus.Text = Commun.GestErreur.Ajoute(this.Name, ex);
            }

        }


    }
}
