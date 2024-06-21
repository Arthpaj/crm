using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Threading;
using MySql.Data.MySqlClient;

using System.Net;
using System.Collections.Specialized;

namespace EnvoiCommandeCRM
{
    public partial class UFSaisie : Form
    {
        public String CheminSoc;
        //public String SocSage;
        public Int16 Soc;
        public string TxtSociete;
        public String User;
        public String Mdp;
        public String TypeDoc;
        public String NumDoc;
        public String DateDoc;
        public String CliDoc;
        public String RefDoc;
        public Boolean Envoi;
        public Object Numero = "";
        public Object DemCRMPrec = "";
        public String LibellePrec = "";
        public string Enumerateur = "";
        public Boolean Recherche = false;
        public Int32 DomaineOri;
        //public ComboBox TypeIncident = new ComboBox();
        public DataTable TableIncident = new DataTable();
        public DataSet DSIncident = new DataSet();
        public DataTable TablePole = new DataTable();
        public DataSet DSPole = new DataSet();

        DataGridViewComboBoxColumn comboxColonne_Domaine;
        DataGridViewComboBoxColumn comboxColonne_RDV;
        DataGridViewComboBoxColumn comboxColonne;

        public Int32 DomaineDefaut = 28;
        public String RDVDefaut = "";

        public Boolean Valide_Cde = false;
        public Object ClientCRMDebut = "";

        public MySqlConnection connMySQL;
        public MySqlCommand CommandCRM;
        public MySqlCommand CommandCRMCli;


        public UFSaisie()
        {
            InitializeComponent();
        }

        class ComboItem
        {
            public string Key { get; set; }
            public string Value { get; set; }
            public ComboItem(string key, string value)
            {
                Key = key; Value = value;
            }

            public override string ToString()
            {
                return Value;
            }
        }
        class ComboItemCRM
        {
            //public Guid Key { get; set; }
            public Int32 Key { get; set; }
            public string Value { get; set; }

            //public ComboItemCRM(Guid key, string value)
            public ComboItemCRM(Int32 key, string value)
            {
                Key = key; Value = value;
            }
            public override string ToString()
            {
                return Value;
            }
        }

        class ComboItemVP
        {
            public Int32 Key { get; set; }
            public string Value { get; set; }
            public ComboItemVP(Int32 key, string value)
            {
                Key = key; Value = value;
            }

            public override string ToString()
            {
                return Value;
            }
        }

        class ComboItemPole
        {
            public Int32 Key { get; set; }
            public string Value { get; set; }
            public ComboItemPole(Int32 key, string value)
            {
                Key = key; Value = value;
            }

            public override string ToString()
            {
                return Value;
            }
        }

        public class Choix_Domaine
        {
            public string NameDom { get; private set; }
            public Int32 ValueDom { get; private set; }
            public Choix_Domaine(string name, Int32 value)
            {
                NameDom = name;
                ValueDom = value;
            }

            private static readonly List<Choix_Domaine> possibleChoixDomaine = new List<Choix_Domaine>
            {
                /*
                { new Choix_Domaine("Gestion - Bureautique", 1) },
                { new Choix_Domaine("Matériel - Réseau", 2) },
                { new Choix_Domaine("Internet", 3) },
                { new Choix_Domaine("ERP", 4) },
                { new Choix_Domaine("Développement", 5) },
                { new Choix_Domaine("Externalisation", 6) }*/
                { new Choix_Domaine("Web", 7) },
                { new Choix_Domaine("Réseau", 18) },
                { new Choix_Domaine("Développement", 27) },
                { new Choix_Domaine("Gestion", 28) },
                { new Choix_Domaine("Externalisation", 29) },
                { new Choix_Domaine("ERP", 30) },
                { new Choix_Domaine("B.I.", 481052) },
                { new Choix_Domaine("Logistique", 481052) }
            };

            public static List<Choix_Domaine> GetChoixDomaine()
            {
                return possibleChoixDomaine;
            }
        }

        public class Choix_RDV
        {
            public string NameRDV { get; private set; }

            public Choix_RDV(string name)
            {
                NameRDV = name;
            }

            private static readonly List<Choix_RDV> possibleChoixRDV = new List<Choix_RDV>
            {
                { new Choix_RDV("1- Analyse") },
                { new Choix_RDV("2- Préparation") },
                { new Choix_RDV("3- Installation") },
                { new Choix_RDV("4- Paramétrage") },
                { new Choix_RDV("5- Formation") },
                { new Choix_RDV("6- Développement") },
                { new Choix_RDV("7- Contrôle trimestriel") },
                { new Choix_RDV("8- Reprise de données") }
            };

            public static List<Choix_RDV> GetChoixRDV()
            {
                return possibleChoixRDV;
            }
        }

        private void UFSaisie_Load(object sender, EventArgs e)
        {
            CheminSoc = "ERP73";

            Soc = 1;
            User = "";
            Mdp = "";
            TypeDoc = "2";
            NumDoc = "";
            DateDoc = "";
            CliDoc = "";
            RefDoc = "";
            Envoi = false;
            Valide_Cde = false;
            string Avancement = "";

            String[] arguments = Environment.GetCommandLineArgs();
            for (int i = 0; i < arguments.Length; ++i)
            {
                //MessageBox.Show(Convert.ToString(i));
                //MessageBox.Show(i + " : " +arguments[i]);
           
                switch (i)
                {
                    case 0:
                        CheminSoc = arguments[i];
                        break;
                    case 1:
                        switch (arguments[i].ToUpper())
                        {
                            case "ACLEA":
                                Soc = 121;
                                break;
                            case "GROUPEDIFFERENCE":
                                Soc = 111;
                                break;
                            case "BERTRAND INFORMATIQUE":
                                Soc = 112;
                                break;
                            case "AD MOBILE":
                                Soc = 131;
                                break;
                            case "MIADI":
                                Soc = 141;
                                break;
                            default:
                                Soc = 1;
                                break;
                        }
                        break;
                    case 2:
                        break;
                    case 3:
                        TypeDoc = arguments[i].ToUpper();
                        break;
                    case 4:
                        NumDoc = arguments[i].ToUpper();
                        break;
                    default:
                        break;
                }
                if (NumDoc != "")
                    Envoi = true;
            }

            try
            {
                Avancement = "Début";
                switch (Soc)
                {
                    case 111: 
                        TxtSociete = "DIFFERENCE INFORMATIQUE";
                        break;
                    case 112:
                        TxtSociete = "BERTRAND INFORMATIQUE";
                        break;
                    case 121:
                        TxtSociete = "ACLEA";
                        break;
                    case 131:
                        TxtSociete = "AD MOBILE";
                        break;
                    case 141:
                        TxtSociete = "MIADI";
                        break;
                    default:
                        break;
                }
                Text = TxtSociete + " - Envoi de la Commande dans l'intranet";
                SocieteSage.Text = TxtSociete;

                Avancement = "Connexion TransfertVP";
                if (oleConnect.State != ConnectionState.Open)
                {
                    //oleConnect.ConnectionString = Commun.Connection.CString();
                    oleConnect.ConnectionString = Properties.Settings.Default.VpTranferConnectionString;
                    oleConnect.Open();
                }
                /*if (oleConnectCRM.State != ConnectionState.Open)
                {
                    oleConnectCRM.ConnectionString = Properties.Settings.Default.CRMConnectionString;
                    oleConnectCRM.Open();
                }*/

                /*Avancement = "Connexion MySQL";
                string ConnectionMySql = Properties.Settings.Default.MySQLConnectionString;//"server=localhost;user=root;database=world;port=3306;password=******";
                connMySQL = new MySqlConnection(ConnectionMySql);
                connMySQL.Open();

                CommandCRM = new MySqlCommand();
                CommandCRMCli = new MySqlCommand();
                CommandCRM.Connection = connMySQL;
                CommandCRMCli.Connection = connMySQL;*/

                /*Avancement = "Connexion Divalto";
                if (oleConnectSage.State != ConnectionState.Open) //C'est la connexion à Divalto
                {
                    String ConnectionSage = Properties.Settings.Default.GrpDiffConnectionString;
                    if (ConnectionSage.IndexOf("Initial Catalog=") != -1)
                    {
                        int Debut = ConnectionSage.IndexOf("Initial Catalog=");
                        int Fin = ConnectionSage.IndexOf(";", Debut + 16);
                        string SocConnectionSage = ConnectionSage.Substring(0, Debut + 16) + CheminSage + ConnectionSage.Substring(Fin, ConnectionSage.Length - Fin);
                        ConnectionSage = SocConnectionSage;
                    }
                    oleConnectSage.ConnectionString = ConnectionSage;
                    //MessageBox.Show(ConnectionSage);
                    oleConnectSage.Open();
                }*/

                Avancement = "Connexion GroupeDiff";
                if (oleConnectVP.State != ConnectionState.Open)
                {
                    oleConnectVP.ConnectionString = Properties.Settings.Default.GrpDiffConnectionString;
                    oleConnectVP.Open();
                }


                // Recherche du Domaine et du TypeRDV par défaut de la société
                
                string SQL = "SELECT SODomaine,SOTypeRDV FROM Societe Where SONom='" + TxtSociete + "'";
                oleCommandLib.CommandText = SQL;
                OleDbDataReader Reader = oleCommandLib.ExecuteReader();
                if (Reader.Read())
                {
                    if (!Reader.IsDBNull(0))
                        DomaineDefaut = Reader.GetInt32(0);
                    if (!Reader.IsDBNull(1))
                        RDVDefaut = Reader.GetString(1);
                }
                Reader.Close();

                //MessageBox.Show(DomaineDefaut.ToString());

                #region Remplissage des listes
                
                // Remplissage Liste Domaine en-tête
                SDomaine.Items.Add(new ComboItem("1", "Gestion - Bureautique"));
                SDomaine.Items.Add(new ComboItem("2", "Matériel - Réseau"));
                SDomaine.Items.Add(new ComboItem("3", "Internet"));
                SDomaine.Items.Add(new ComboItem("4", "ERP"));
                SDomaine.Items.Add(new ComboItem("5", "Développement"));
                SDomaine.Items.Add(new ComboItem("6", "Externalisation"));
                SDomaine.SelectedText = "Gestion - Bureautique";

                // Remplissage Liste Domaine Ligne
                //DataGridViewComboBoxColumn comboxColonne_Domaine = (DataGridViewComboBoxColumn)DGVCRM.Columns[0];
                comboxColonne_Domaine = new DataGridViewComboBoxColumn();
                comboxColonne_Domaine.DataSource = Choix_Domaine.GetChoixDomaine();
                comboxColonne_Domaine.HeaderText = "Domaine";
                comboxColonne_Domaine.DisplayMember = "NameDom";
                comboxColonne_Domaine.ValueMember = "ValueDom";
                comboxColonne_Domaine.DataPropertyName = "Domaine";
                comboxColonne_Domaine.Name = "Domaine";
                
                SDomaine.Items.Clear();
                /*SQL = "SELECT polesid AS Code, nom As NomPole FROM vtiger_poles ORDER BY nom";
                MySqlCommand command_Pole = new MySqlCommand(SQL, connMySQL);
                MySqlDataReader ReaderPole = command_Pole.ExecuteReader();

                while (ReaderPole.Read())
                {
                    SDomaine.Items.Add(new ComboItemPole(Convert.ToInt32(ReaderPole["Code"]), Convert.ToString(ReaderPole["NomPole"])));
                }
                ReaderPole.Close();

                MySqlDataAdapter adapter_pole = new MySqlDataAdapter();
                adapter_pole.SelectCommand = command_Pole;

                adapter_pole.Fill(DSPole, "Table_Pole");
                adapter_pole.Fill(TablePole);*/
                
                // Remplissage Domaine
                comboxColonne_Domaine = new DataGridViewComboBoxColumn();
                comboxColonne_Domaine.HeaderText = "Domaine CRM";
                comboxColonne_Domaine.DataSource = TablePole;
                comboxColonne_Domaine.ValueMember = "Code";
                comboxColonne_Domaine.DisplayMember = "NomPole";

                comboxColonne_Domaine.DataPropertyName = "Domaine";
                comboxColonne_Domaine.Name = "Domaine";

                // Remplissage Liste Rendez-vous VP en-tête
                STypeRDV.Items.Add("1- Analyse");
                STypeRDV.Items.Add("2- Préparation");
                STypeRDV.Items.Add("3- Installation");
                STypeRDV.Items.Add("4- Paramétrage");
                STypeRDV.Items.Add("5- Formation");
                STypeRDV.Items.Add("6- Développement");
                STypeRDV.Items.Add("7- Contrôle trimestriel");
                STypeRDV.Items.Add("8- Reprise de données");
                STypeRDV.SelectedText = "1- Analyse";

                // Remplissage Liste Rendez-vous VP Ligne
                comboxColonne_RDV = new DataGridViewComboBoxColumn();
                comboxColonne_RDV.DataSource = Choix_RDV.GetChoixRDV();
                comboxColonne_RDV.HeaderText = "Type_RDV_VP";
                comboxColonne_RDV.DisplayMember = "NameRDV";
                comboxColonne_RDV.ValueMember = "NameRDV";
                comboxColonne_RDV.DataPropertyName = "Type_RDV";
                comboxColonne_RDV.Name = "Type_RDV";

                // Liste des types Demande
                /*
                SQL = "SELECT cf_1031id, cf_1031 FROM vtiger_cf_1031 WHERE presence=1 ORDER BY cf_1031";
                MySqlCommand command = new MySqlCommand(SQL, connMySQL);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                */
                /*SQL = "SELECT logicielId, logicielName, logicielType, logicielEditeur FROM TYPEDEMANDE";
                OleDbCommand command = new OleDbCommand(SQL, oleConnect);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = command;

                adapter.Fill(DSIncident, "TableType");
                adapter.Fill(TableIncident);*/

                // Remplissage Type Demande
                comboxColonne = new DataGridViewComboBoxColumn();
                comboxColonne.HeaderText = "Type_Demande_CRM";
                //comboxColonne.DataSource = TableIncident;
                //comboxColonne.ValueMember = "cf_1031id";
                //comboxColonne.DisplayMember = "cf_1031";
                //comboxColonne.ValueMember = "logicielId";
                //comboxColonne.DisplayMember = "logicielName";

                comboxColonne.DataPropertyName = "Type_Demande";
                comboxColonne.Name = "Type_Demande";
                #endregion

                Avancement = "Fin requête";
                //RAZAffichage();

                DGVSage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                DGVSage.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                DGVSage.RowTemplate.Height = 18;
                DSSage.Tables.Add("Ligne");

                DGVCRM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                DGVCRM.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                DGVCRM.RowTemplate.Height = 18;
                DSCRM.Tables.Add("Ligne");

                // Liste des clients VP
                ListeClientVP();


                // Liste des commandes existantes
                ListeCommandeAffiche();

                // Recherche de la commande sélectionnée dans la table CommandeSage
                /*if (NumDocSage != "")
                {
                    //AffichageCommande(NumDocSage,SocSage);
                    AffichageCommandeDivalto(NumDocSage, Societe);
                }
                else
                {
                    RemplissageListe(CliDocSage, "");
                }*/

                Recherche = true;
            }
            catch (Exception ex)
            {
                LStatus.Text = Commun.GestErreur.Ajoute(this.Name + " : " + Avancement, ex);
            }

        }

        private void ListeClientVP()
        {
            //dois-je récup des infos depuis VP ???
            //
            /*ListeVP.Items.Clear();
            string SQL = "SELECT ID,UID, Rub13, Rub14, Rub15, Rub16, Rub17, Rub18 FROM Eventresource6  WHERE Rub13 <>'' ORDER BY Rub13 ";
            oleCommandVP.CommandText = SQL;
            OleDbDataReader ReaderVP = oleCommandVP.ExecuteReader();

            while (ReaderVP.Read())
            {
                String Lib = Convert.ToString(ReaderVP["Rub13"]) + " / " + Convert.ToString(ReaderVP["Rub16"]) + " / " +
                             Convert.ToString(ReaderVP["Rub17"]);
                ListeVP.Items.Add(new ComboItemVP(Convert.ToInt32(ReaderVP["ID"]), Lib));
            }
            //MessageBox.Show("nb" + ListeVP.Items.Count.ToString());
            ReaderVP.Close();*/
            ListeVP.Items.Clear();
            string SQL = "SELECT CLI_ID, NOM, DOS FROM CLI WHERE DOS= " + Soc + " ORDER BY NOM"; //RUE, VIL, CPOSTAL
            //string SQL = "SELECT * FROM "
            oleCommandVP.CommandText = SQL;
            OleDbDataReader ReaderVP = oleCommandVP.ExecuteReader();

            while (ReaderVP.Read())
            {
                String Lib = Convert.ToString(ReaderVP["NOM"]) + " / " + Convert.ToString(ReaderVP["DOS"]);//+ " / " + Convert.ToString(ReaderVP["VIL"]) //+ " / " + Convert.ToString(ReaderVP["CPOSTAL"]);
                ListeVP.Items.Add(new ComboItemVP(Convert.ToInt32(ReaderVP["CLI_ID"]), Lib));
            }
            //MessageBox.Show("nb" + ListeVP.Items.Count.ToString());
            ReaderVP.Close();

        }

        
        private void ListeCommandeAffiche()
        {
            // Liste des commandes existantes
            ListeCommande.Items.Clear();
            string SQL = "SELECT CSType, CSPiece, CSDate, CSClient, CSDomaine from CommandeSage Where CSSociete= '" + TxtSociete + "'";
            oleCommandLib.CommandText = SQL;
            OleDbDataReader Reader = oleCommandLib.ExecuteReader();

            while (Reader.Read())
            {
                String Lib = Convert.ToString(Reader["CSPiece"]) + " - " + Convert.ToString(Reader["CSClient"]) + " - " +
                             Convert.ToDateTime(Reader["CSDate"]).ToString("dd/MM/yyyy") +
                              " - " + Convert.ToString(Reader["CSDomaine"]);
                ListeCommande.Items.Add(new ComboItem(Convert.ToString(Reader["CSPiece"]), Lib));
            }
            Reader.Close();
        }

        private void AffichageCommande(String NumeroCommande, Int32 DomaineCde)
        {
            Object InterlocuteurCRM = "";
            Object LogicielCRM = "";
            Object MaterielCRM = "";
            Int32 DomaineCRM = 1;
            Object TypeRDVCRM = "";
            Boolean EnvoiCRM = false;
            Valide_Cde = false;
            DemCRMPrec = "";
            LibellePrec = "";
            RAZAffichage();

            // Recherche de la commande sélectionnée dans la table CommandeSage
            if (NumeroCommande != "")
            {
                String SQL = "SELECT * from CommandeSage Where CSType =" + TypeDoc;
                SQL += " AND CSPiece ='" + NumeroCommande + "' AND CSSociete= '" + TxtSociete + "'";
                if (DomaineCde != 0)
                    SQL += " AND CSDomaine= " + DomaineCde;

                oleCommandLib.CommandText = SQL;
                OleDbDataReader Reader = oleCommandLib.ExecuteReader();
                if (Reader.Read())
                {
                    if (!Reader.IsDBNull(4))
                        CliDoc = Convert.ToString(Reader["CSClient"]);
                    if (!Reader.IsDBNull(3))
                        DateDoc = Convert.ToString(Convert.ToDateTime(Reader["CSDate"]));
                    if (!Reader.IsDBNull(5))
                        ClientCRMDebut = Convert.ToString(Reader["CSClientCRM"]); //Reader.GetGuid(5);
                    if (!Reader.IsDBNull(6))
                        InterlocuteurCRM = Convert.ToString(Reader["CSInterlocuteur"]); //Reader.GetGuid(6);
                    if (!Reader.IsDBNull(7))
                        LogicielCRM = Convert.ToString(Reader["CSLogiciel"]); //Reader.GetGuid(7);
                    if (!Reader.IsDBNull(8))
                        MaterielCRM = Convert.ToString(Reader["CSMateriel"]);// Reader.GetGuid(8);
                    if (!Reader.IsDBNull(10))
                        DomaineCRM = Convert.ToInt16(Reader["CSDomaine"]);
                    if (!Reader.IsDBNull(11))
                        TypeRDVCRM = Convert.ToString(Reader["CSTypeRDV"]);
                    if (!Reader.IsDBNull(9))
                        EnvoiCRM = Convert.ToBoolean(Reader["CSEnvoi"]);

                    DomaineOri = DomaineCRM;
                }
                Reader.Close();
            }

            Recherche = false;
            SCommande.Text = NumeroCommande;
            SDate.Text = DateDoc;
            SClientSage.Text = CliDoc;

            SEnvoi.Checked = EnvoiCRM;
            if (EnvoiCRM)
            {
                labelEnvoi.Text = "Commande envoyée dans l'intranet.";
                DGVCRM.Enabled = false;
                SClientCRM.Enabled = false;
                SInterlocuteur.Enabled = false;
                SLogiciel.Enabled = false;
                SMateriel.Enabled = false;
            }
            else
            {
                labelEnvoi.Text = "";
                DGVCRM.Enabled = true;
                SClientCRM.Enabled = true;
                SInterlocuteur.Enabled = true;
                SLogiciel.Enabled = true;
                SMateriel.Enabled = true;
            }

            //MessageBox.Show("ClientCRM Affichage 1 : " + ClientCRMDebut.ToString());
            RemplissageListe(CliDoc, ClientCRMDebut);
            Recherche = true;
            //MessageBox.Show("ClientCRM Affichage 2 : " + ClientCRMDebut.ToString());
            if (Convert.ToString(ClientCRMDebut) != "")
                RechercheInfoClient(ClientCRMDebut, InterlocuteurCRM, LogicielCRM, MaterielCRM);
            //RechercheInfoClientDivalto(ClientCRMDebut);

            // Domaine et Type de Rendez-vous
            //SDomaine.SelectedIndex = DomaineCRM - 1;
            STypeRDV.SelectedText = TypeRDVCRM.ToString();

            // Recherche dans Divalto de la Référence et du commentaire de l'entête
            string SQL1 = "SELECT PIREF as Description, '' as Reference, REPR_0001, PIDT as DateCde";
            SQL1 += " FROM ENT WHERE DOS=" + Soc + " AND TICOD='C' AND CE4=1 AND PICOD=" + (TypeDoc + 1).ToString() + " and PINO='" + NumeroCommande + "'";
            oleCommandVP.CommandText = SQL1;
            OleDbDataReader ReaderSage = oleCommandVP.ExecuteReader();
            if (ReaderSage.Read())
            {
                if (!ReaderSage.IsDBNull(0))
                    SReferenceSage.Text = Convert.ToString(ReaderSage["Reference"]);
                if (!ReaderSage.IsDBNull(1))
                    SCommentaireSage.Text = Convert.ToString(ReaderSage["Description"]);
                if (!ReaderSage.IsDBNull(2))
                    SInterlocuteurSage.Text = Convert.ToString(ReaderSage["Interlocuteur"]);
            }
            ReaderSage.Close();

            // Affichage de la commande à partir de Divalto
            DSSage.Tables["Ligne"].Clear();
            string SQL2 = "SELECT REF as ARTICLE, DES as Libelle, CDQTE as Quantite, MONT / CDQTE as PUNet, MONT as MontantHT, '' as Reference ";
            SQL2 += " FROM MOUV INNER JOIN ENT ON ENT.DOS=MOUV.DOS AND ENT.PICOD=MOUV.PICOD AND ENT.TICOD=MOUV.TICOD AND ENT.PINO=MOUV.CDNO ";
            SQL2 += " WHERE ENT.DOS=" + Soc + " AND ENT.PICOD=" + TypeDoc + " AND ENT.TICOD='C' AND ENT.CE4=1 AND CDQTE<>0 AND ENT.PINO='" + NumeroCommande + "' ";
            SQL2 += " AND REF between '61' and '65z' ";
            SQL2 += " Order by REF";
            oleDAC.SelectCommand.CommandText = SQL2;

            // oleDAC.Fill(DSSage.Tables["Ligne"]);
            oleDAC.TableMappings.Clear();
            /*oleDAC.TableMappings.Add(DSSage.Tables[0].TableName, DSSage.Tables[0].TableName);

            BSource.DataMember = DSSage.Tables[0].TableName;
            DGVSage.DataSource = BSource;
            */
            DGVSage.ClearSelection();
            DGVSage.Refresh();
            /*
            DGVSage.Columns[2].DefaultCellStyle.Format = "0.00\\";
            DGVSage.Columns[2].ValueType = System.Type.GetType("System.Decimal");
            DGVSage.Columns[3].DefaultCellStyle.Format = "0.00\\";
            DGVSage.Columns[3].ValueType = System.Type.GetType("System.Decimal");
            DGVSage.Columns[4].DefaultCellStyle.Format = "C";
            DGVSage.Columns[4].ValueType = System.Type.GetType("System.Decimal");

            DGVSage.Columns[0].Width = 120;
            DGVSage.Columns[1].Width = 400;
            DGVSage.Columns[2].Width = 80;
            DGVSage.Columns[3].Width = 80;
            DGVSage.Columns[4].Width = 100;
            DGVSage.Columns[5].Width = 120;*/

            // Affichage des lignes saisies
            DSCRM.Tables["Ligne"].Clear();
            SQL2 = "select  CSLDOMAINE AS Domaine, CSLTypeRDV as Type_RDV, CSLTypeCde as Type_Demande, [CSLLibelle] as Libelle, ";
            SQL2 += " CSLNbJours As NbrJours, CSLCommentaire as Commentaire, CSLIdentifiant as Identifiant ";
            SQL2 += " FROM CommandeSageLigne  Where CSLType =" + TypeDoc;
            SQL2 += " AND CSLPiece ='" + NumeroCommande + "' AND CSLSociete= '" + TxtSociete + "'";
            SQL2 += " Order by CSLLigne";
            oleDACCRM.SelectCommand.CommandText = SQL2;

            oleDACCRM.Fill(DSCRM.Tables["Ligne"]);
            oleDACCRM.TableMappings.Clear();
            oleDACCRM.TableMappings.Add(DSCRM.Tables[0].TableName, DSCRM.Tables[0].TableName);

            BSourceCRM.DataMember = DSCRM.Tables[0].TableName;
            DGVCRM.DataSource = BSourceCRM;
            DSCRM.Tables[0].Columns[0].DefaultValue = DomaineDefaut; ;
            DSCRM.Tables[0].Columns[1].DefaultValue = RDVDefaut;
            int i = DSCRM.Tables[0].Rows.Count;
            if (i != 0)
            {
                DataRow XTable = DSCRM.Tables[0].Rows[i - 1];
                LibellePrec = XTable.Field<string>(3);
                DemCRMPrec = XTable.Field<object>(2);
            }

            if (LibellePrec == "")
                DSCRM.Tables[0].Columns[3].DefaultValue = SCommentaireSage.Text;
            else
                DSCRM.Tables[0].Columns[3].DefaultValue = LibellePrec;
            if (DemCRMPrec != "")
                DSCRM.Tables[0].Columns[2].DefaultValue = DemCRMPrec;


            DGVCRM.ClearSelection();
            DGVCRM.Refresh();

             // Remplissage Liste Domaine
            /*DGVCRM.Columns.Remove("Domaine");
            DGVCRM.Columns.Insert(0, comboxColonne_Domaine);
            DGVCRM.Columns[0].Name = "Domaine";

            // Remplissage Liste TypeRDV
            DGVCRM.Columns.Remove("Type_RDV");
            DGVCRM.Columns.Insert(1, comboxColonne_RDV);
            DGVCRM.Columns[1].Name = "Type_RDV";

            // Remplissage TYpe Demande
            DGVCRM.Columns.Remove("Type_Demande");
            DGVCRM.Columns.Insert(2, comboxColonne);
            DGVCRM.Columns[2].Name = "Type_Demande";


            DGVCRM.Columns[6].Visible = false;

            /*
            ((DataGridViewComboBoxColumn)DGVCRM.Columns[0]).DataSource = DSIncident;
            ((DataGridViewComboBoxColumn)DGVCRM.Columns[0]).ValueMember = "New_logicielId";
            ((DataGridViewComboBoxColumn)DGVCRM.Columns[0]).DisplayMember = "New_Name";
            ((DataGridViewComboBoxColumn)DGVCRM.Columns[0]).DataPropertyName = "New_logicielId";
            ((DataGridViewComboBoxColumn)DGVCRM.Columns[0]).HeaderText = "Type";
            */

            //DGVCRM.Columns[4].DefaultCellStyle.Format = "N2";
            //DGVCRM.Columns[4].DefaultCellStyle.Format = "0.00\\";
            //DGVCRM.Columns[4].ValueType = System.Type.GetType("System.Decimal");
            /*
            DGVCRM.Columns[0].Width = 150;
            DGVCRM.Columns[1].Width = 150;

            DGVCRM.Columns[2].Width = 150;
            DGVCRM.Columns[3].Width = 190;
            DGVCRM.Columns[4].Width = 60;
            DGVCRM.Columns[5].Width = 200;*/

        }

        private void AffichageCommandeDivalto(String NumeroCommande, Int32 DomaineCde)
        {
            Object InterlocuteurCRM = "";
            Object LogicielCRM = "";
            Object MaterielCRM = "";
            Int32 DomaineCRM = 1;
            Object TypeRDVCRM = "";
            Boolean EnvoiCRM = false;
            Valide_Cde = false;
            DemCRMPrec = "";
            LibellePrec = "";
            RAZAffichage();

            // Recherche de la commande sélectionnée dans la table CommandeSage
            if (NumeroCommande != "")
            {
                String SQL = "SELECT * from CommandeSage Where CSType =" + TypeDoc;
                SQL += " AND CSPiece ='" + NumeroCommande + "' AND CSSociete= '" + TxtSociete + "'";
                if (DomaineCde != 0)
                    SQL += " AND CSDomaine= " + DomaineCde;

                oleCommandLib.CommandText = SQL;
                OleDbDataReader Reader = oleCommandLib.ExecuteReader();
                if (Reader.Read())
                {
                    if (!Reader.IsDBNull(4))
                        CliDoc = Convert.ToString(Reader["CSClient"]);
                    if (!Reader.IsDBNull(3))
                        DateDoc = Convert.ToString(Convert.ToDateTime(Reader["CSDate"]));
                    if (!Reader.IsDBNull(5))
                        ClientCRMDebut = Convert.ToString(Reader["CSClientCRM"]); //Reader.GetGuid(5);
                    if (!Reader.IsDBNull(6))
                        InterlocuteurCRM = Convert.ToString(Reader["CSInterlocuteur"]); //Reader.GetGuid(6);
                    if (!Reader.IsDBNull(7))
                        LogicielCRM = Convert.ToString(Reader["CSLogiciel"]); //Reader.GetGuid(7);
                    if (!Reader.IsDBNull(8))
                        MaterielCRM = Convert.ToString(Reader["CSMateriel"]);// Reader.GetGuid(8);
                    if (!Reader.IsDBNull(10))
                        DomaineCRM = Convert.ToInt16(Reader["CSDomaine"]);
                    if (!Reader.IsDBNull(11))
                        TypeRDVCRM = Convert.ToString(Reader["CSTypeRDV"]);
                    if (!Reader.IsDBNull(9))
                        EnvoiCRM = Convert.ToBoolean(Reader["CSEnvoi"]);

                    DomaineOri = DomaineCRM;
                }
                Reader.Close();
            }

            Recherche = false;
            SCommande.Text = NumeroCommande;
            SDate.Text = DateDoc;
            SClientSage.Text = CliDoc;

            SEnvoi.Checked = EnvoiCRM;
            if (EnvoiCRM)
            {
                labelEnvoi.Text = "Commande envoyée dans l'intranet.";
                DGVCRM.Enabled = false;
                SClientCRM.Enabled = false;
                SInterlocuteur.Enabled = false;
                SLogiciel.Enabled = false;
                SMateriel.Enabled = false;
            }
            else
            {
                labelEnvoi.Text = "";
                DGVCRM.Enabled = true;
                SClientCRM.Enabled = true;
                SInterlocuteur.Enabled = true;
                SLogiciel.Enabled = true;
                SMateriel.Enabled = true;
            }


            SDomaine.SelectedIndex = DomaineCRM - 1;
            STypeRDV.SelectedText = TypeRDVCRM.ToString();

            // Recherche dans Divalto de la Référence et du commentaire de l'entête
            string SQL1 = "SELECT PIREF as Description, '' as Reference, REPR_0001 as Interlocuteur, PIDT as DateCde, TIERS as Client";
            SQL1 += " FROM ENT WHERE DOS=" + Soc + " AND TICOD='C' AND CE4=1 AND PICOD=" + (TypeDoc).ToString() + " and PINO='" + NumeroCommande + "'"; //FP20180314
            oleCommandSage.CommandText = SQL1;
            OleDbDataReader ReaderSage = oleCommandSage.ExecuteReader();
            if (ReaderSage.Read())
            {
                if (!ReaderSage.IsDBNull(0))
                    SReferenceSage.Text = Convert.ToString(ReaderSage["Reference"]);
                if (!ReaderSage.IsDBNull(1))
                    SCommentaireSage.Text = Convert.ToString(ReaderSage["Description"]);
                if (!ReaderSage.IsDBNull(2))
                    SInterlocuteurSage.Text = Convert.ToString(ReaderSage["Interlocuteur"]);
                // TP 20150812
                if (!ReaderSage.IsDBNull(4) && SClientSage.Text == "")
                {
                    CliDoc = Convert.ToString(ReaderSage["Client"]).Trim();
                    SClientSage.Text = CliDoc;
                }
            }
            ReaderSage.Close();

            //CliDocSage = "CHUILGI";

            //MessageBox.Show("ClientCRM Affichage 1 : " + ClientCRMDebut.ToString());
            RemplissageListe(CliDoc, ClientCRMDebut);
            Recherche = true;
            //MessageBox.Show("ClientCRM Affichage 2 : " + ClientCRMDebut.ToString());
            if (Convert.ToString(ClientCRMDebut) != "")
                RechercheInfoClient(ClientCRMDebut, InterlocuteurCRM, LogicielCRM, MaterielCRM);

            // Domaine et Type de Rendez-vous

            // Affichage de la commande à partir de Divalto
            DSSage.Tables["Ligne"].Clear();
            string SQL2 = "SELECT REF as ARTICLE, DES as Libelle, CDQTE as Quantite, MONT / CDQTE as PUNet, MONT as MontantHT, '' as Reference ";
            SQL2 += " FROM MOUV INNER JOIN ENT ON ENT.DOS=MOUV.DOS AND ENT.PICOD=MOUV.PICOD AND ENT.TICOD=MOUV.TICOD AND ENT.PINO=MOUV.CDNO ";
            SQL2 += " WHERE ENT.DOS=" + Soc + " AND ENT.PICOD=" + TypeDoc + " AND ENT.TICOD='C' AND ENT.CE4=1 AND CDQTE<>0 AND ENT.PINO='" + NumeroCommande + "' ";
            SQL2 += " AND REF between '61' and '65z' ";
            SQL2 += " Order by REF";
            oleDAC.SelectCommand.CommandText = SQL2;

            oleDAC.Fill(DSSage.Tables["Ligne"]);
            oleDAC.TableMappings.Clear();
            oleDAC.TableMappings.Add(DSSage.Tables[0].TableName, DSSage.Tables[0].TableName);

            BSource.DataMember = DSSage.Tables[0].TableName;
            DGVSage.DataSource = BSource;

            DGVSage.ClearSelection();
            DGVSage.Refresh();

            DGVSage.Columns[2].DefaultCellStyle.Format = "0.00\\";
            DGVSage.Columns[2].ValueType = System.Type.GetType("System.Decimal");
            DGVSage.Columns[3].DefaultCellStyle.Format = "0.00\\";
            DGVSage.Columns[3].ValueType = System.Type.GetType("System.Decimal");
            DGVSage.Columns[4].DefaultCellStyle.Format = "C";
            DGVSage.Columns[4].ValueType = System.Type.GetType("System.Decimal");

            DGVSage.Columns[0].Width = 120;
            DGVSage.Columns[1].Width = 400;
            DGVSage.Columns[2].Width = 80;
            DGVSage.Columns[3].Width = 80;
            DGVSage.Columns[4].Width = 100;
            DGVSage.Columns[5].Width = 120;

            // Affichage des lignes saisies
            DSCRM.Tables["Ligne"].Clear();
            SQL2 = "select  CSLDOMAINE AS Domaine, CSLTypeRDV as Type_RDV, CSLTypeCde as Type_Demande, [CSLLibelle] as Libelle, ";
            SQL2 += " CSLNbJours As NbrJours, CSLCommentaire as Commentaire, CSLIdentifiant as Identifiant ";
            SQL2 += " FROM CommandeSageLigne  Where CSLType =" + TypeDoc;
            SQL2 += " AND CSLPiece ='" + NumeroCommande + "' AND CSLSociete= '" + TxtSociete + "'";
            SQL2 += " Order by CSLLigne";
            oleDACCRM.SelectCommand.CommandText = SQL2;

            oleDACCRM.Fill(DSCRM.Tables["Ligne"]);
            oleDACCRM.TableMappings.Clear();
            oleDACCRM.TableMappings.Add(DSCRM.Tables[0].TableName, DSCRM.Tables[0].TableName);

            BSourceCRM.DataMember = DSCRM.Tables[0].TableName;
            DGVCRM.DataSource = BSourceCRM;
            DSCRM.Tables[0].Columns[0].DefaultValue = DomaineDefaut; ;
            DSCRM.Tables[0].Columns[1].DefaultValue = RDVDefaut;
            int i = DSCRM.Tables[0].Rows.Count;
            if (i != 0)
            {
                DataRow XTable = DSCRM.Tables[0].Rows[i - 1];
                LibellePrec = XTable.Field<string>(3);
                DemCRMPrec = XTable.Field<object>(2);
            }

            if (LibellePrec == "")
                DSCRM.Tables[0].Columns[3].DefaultValue = SCommentaireSage.Text;
            else
                DSCRM.Tables[0].Columns[3].DefaultValue = LibellePrec;
            if (DemCRMPrec != "")
                DSCRM.Tables[0].Columns[2].DefaultValue = DemCRMPrec;


            DGVCRM.ClearSelection();
            DGVCRM.Refresh();
            
            // Remplissage Liste Domaine
            DGVCRM.Columns.Remove("Domaine");
            DGVCRM.Columns.Insert(0, comboxColonne_Domaine);
            DGVCRM.Columns[0].Name = "Domaine";

            // Remplissage Liste TypeRDV
            DGVCRM.Columns.Remove("Type_RDV");
            DGVCRM.Columns.Insert(1, comboxColonne_RDV);
            DGVCRM.Columns[1].Name = "Type_RDV";

            // Remplissage TYpe Demande
            DGVCRM.Columns.Remove("Type_Demande");
            DGVCRM.Columns.Insert(2, comboxColonne);
            DGVCRM.Columns[2].Name = "Type_Demande";

            DGVCRM.Columns[6].Visible = false;

            /*
            ((DataGridViewComboBoxColumn)DGVCRM.Columns[0]).DataSource = DSIncident;
            ((DataGridViewComboBoxColumn)DGVCRM.Columns[0]).ValueMember = "New_logicielId";
            ((DataGridViewComboBoxColumn)DGVCRM.Columns[0]).DisplayMember = "New_Name";
            ((DataGridViewComboBoxColumn)DGVCRM.Columns[0]).DataPropertyName = "New_logicielId";
            ((DataGridViewComboBoxColumn)DGVCRM.Columns[0]).HeaderText = "Type";
            */

            //DGVCRM.Columns[4].DefaultCellStyle.Format = "N2";
            //DGVCRM.Columns[4].DefaultCellStyle.Format = "0.00\\";
            //DGVCRM.Columns[4].ValueType = System.Type.GetType("System.Decimal");

            DGVCRM.Columns[0].Width = 150;
            DGVCRM.Columns[1].Width = 150;

            DGVCRM.Columns[2].Width = 150;
            DGVCRM.Columns[3].Width = 190;
            DGVCRM.Columns[4].Width = 60;
            DGVCRM.Columns[5].Width = 200;

        }

        private void RAZAffichage()
        {
            ListeCommande.Text = "";
            SCommande.Text = "";
            SClientSage.Text = "";
            SReferenceSage.Text = "";
            SCommentaireSage.Text = "";
            SInterlocuteurSage.Text = "";

            NomClient.Text = "";
            Adresse1.Text = "";
            Adresse2.Text = "";
            Adresse3.Text = "";
            CodePostal.Text = "";
            Ville.Text = "";

            SClientCRM.Items.Clear();
            SClientCRM.Text = "";
            SClientCRM.SelectedText = "";
            SClientCRM.SelectedIndex = -1;

            SInterlocuteur.Items.Clear();
            SInterlocuteur.Text = "";
            SInterlocuteur.SelectedText = "";
            SInterlocuteur.SelectedIndex = -1;

            SLogiciel.Items.Clear();
            SLogiciel.Text = "";
            SLogiciel.SelectedText = "";
            SLogiciel.SelectedIndex = -1;

            SMateriel.Items.Clear();
            SMateriel.Text = "";
            SMateriel.SelectedText = "";
            SMateriel.SelectedIndex = -1;

            STypeRDV.Text = "";
            STypeRDV.SelectedText = "";
            STypeRDV.SelectedIndex = -1;

            SDomaine.Text = "Gestion - Bureautique";
            SDomaine.SelectedText = "Gestion - Bureautique";
            SDomaine.SelectedIndex = -1;
            DomaineOri = 0;

        }

        private void RemplissageListe(String ClientSage, Object ClientCRM)
        {
            // Liste des clients CRM
            Int16 IndexSel = -1;
            string NomVille = "";
            SClientCRM.Items.Clear();
            Int32 NombreClient = 0;

            // Compte le nbr de client concerné
            if (ClientSage != "")
            {
                //20191029
                /*
                string SQL1 = "SELECT  Count(*) as Nombre ";
                SQL1 += " FROM [AccountBase] ";
                SQL1 += " INNER JOIN AccountExtensionBase ON AccountBase.AccountId=AccountExtensionBase.AccountId ";
                SQL1 += " LEFT JOIN [CustomerAddressBase] ON  ([AccountBase].[AccountId] = [CustomerAddressBase].[ParentId]) ";
                SQL1 += "  and ([CustomerAddressBase].AddressNumber=1)  AND ((CustomerTypeCode IS NULL) OR (CustomerTypeCode !=11)) ";

                SQL1 += " WHERE  ([AccountExtensionBase].[New_SageGestion] ='" + ClientSage + "')";
                SQL1 += " OR  ([AccountExtensionBase].[New_SageRseau] ='" + ClientSage + "')";
                SQL1 += " OR  ([AccountExtensionBase].[New_SageFormation] ='" + ClientSage + "')";
                SQL1 += " OR  ([AccountExtensionBase].[New_SageInternet] ='" + ClientSage + "')";
                SQL1 += " OR  ([AccountExtensionBase].[New_SageDev] ='" + ClientSage + "')";
                */

                /*string SQL1 = "SELECT  Count(*) as Nombre " +
                     " FROM vtiger_relations r " +
                     " INNER JOIN vtiger_relationscf rc ON rc.relationsid = r.relationsid " +
                     " INNER JOIN vtiger_crmentity e ON e.crmid = r.relationsid " +
                     " INNER JOIN vtiger_societes s ON s.societesid = r.cf_societes_id " +
                     " INNER JOIN vtiger_account a ON a.accountid = r.cf_accounts_id " +
                     " INNER JOIN vtiger_accountbillads adr ON adr.accountaddressid = r.cf_accounts_id " +

                     " WHERE rc.cf_1159 = '" + ClientSage + "' " +
                     " AND (s.at_key = '" + SocieteSage.Text + "'  OR s.at_key = 'ADEFINIR') " +
                     " AND e.deleted = 0    ";*/

                //oleCommandCRM.CommandText = SQL1;
                //OleDbDataReader ReaderCRM1 = oleCommandCRM.ExecuteReader();
                //CommandCRM.CommandText = SQL1;
                MySqlDataReader ReaderCRM1 = CommandCRM.ExecuteReader();

                if (ReaderCRM1.Read())
                {
                    NombreClient = Convert.ToInt16(ReaderCRM1["Nombre"]);
                }
                ReaderCRM1.Close();
            }

            /*   //20191029
            string SQL = "SELECT  [AccountBase].[AccountId], ";
            SQL += " [AccountBase].[Name] ";
            SQL += " + CASE WHEN [City] IS NOT NULL THEN  ' - ' + [City] ELSE '' END ";
            SQL += " + ' (' ";
            SQL += " + ' G: ' + isnull(StringMap_1.[Value],'') "; 
            SQL += " + ' R: ' + isnull(StringMap_2.[Value],'') "; 
            SQL += " + ' I: ' + isnull(StringMap_3.[Value],'') ";
            SQL += " + ' E: ' + isnull(StringMap_4.[Value],'') ";
            SQL += " + ' D: ' + isnull(StringMap_5.[Value],'') ";
            SQL += " + ')' ";
            SQL += " AS NOMVILLE, ";
            SQL += " [Line1], [Line2], [Line3], [City],[PostalCode],[Country], ";
            SQL += " AccountExtensionBase.[new_chemin] ";
            SQL += " ,StringMap_1.[Value] AS SocGestion, ParentAccountId,StringMap_2.[Value] AS SocReseau, ";
            SQL += " StringMap_3.[Value] AS SocInternet, StringMap_4.[Value] AS SocERP, StringMap_5.[Value] AS SocDev ";
            SQL += " FROM [AccountBase] ";
            SQL += " INNER JOIN AccountExtensionBase ON AccountBase.AccountId=AccountExtensionBase.AccountId ";
            SQL += " LEFT JOIN [CustomerAddressBase] ON  ([AccountBase].[AccountId] = [CustomerAddressBase].[ParentId]) ";
            SQL += " AND ([CustomerAddressBase].AddressNumber=1)  AND ((CustomerTypeCode IS NULL) OR (CustomerTypeCode !=11)) ";
            SQL += " LEFT OUTER JOIN StringMap StringMap_1 ON AccountExtensionBase.New_SteGestion = StringMap_1.AttributeValue AND StringMap_1.AttributeName = 'new_stegestion' ";
            SQL += " LEFT OUTER JOIN StringMap StringMap_2 ON AccountExtensionBase.New_Sterseau = StringMap_2.AttributeValue AND StringMap_2.AttributeName = 'New_sterseau' ";
            SQL += " LEFT OUTER JOIN StringMap StringMap_3 ON AccountExtensionBase.New_SteInternet = StringMap_3.AttributeValue AND StringMap_3.AttributeName = 'New_steInternet' "; 
            SQL += " LEFT OUTER JOIN StringMap StringMap_4 ON AccountExtensionBase.New_SteFormation = StringMap_4.AttributeValue AND StringMap_4.AttributeName = 'new_steFormation' ";
            SQL += " LEFT OUTER JOIN StringMap StringMap_5 ON AccountExtensionBase.New_SteDev = StringMap_5.AttributeValue AND StringMap_5.AttributeName = 'New_steDev' ";

            if (ClientSage != "")
            {
                SQL += " WHERE  ([AccountExtensionBase].[New_SageGestion] ='" + ClientSage + "')";
                SQL += " OR  ([AccountExtensionBase].[New_SageRseau] ='" + ClientSage + "')";
                SQL += " OR  ([AccountExtensionBase].[New_SageFormation] ='" + ClientSage + "')";
                SQL += " OR  ([AccountExtensionBase].[New_SageInternet] ='" + ClientSage + "')";
                SQL += " OR  ([AccountExtensionBase].[New_SageDev] ='" + ClientSage + "')";
            }
            SQL += " ORDER BY   [AccountBase].[Name]";
            */

            /*string SQL = "SELECT DISTINCT r.at_key AS Guid_Account, cf_accounts_id AS CodeTiers, a.accountname, CONCAT(a.accountname,' - ',adr.bill_city,' - ',p.nom,'-',s.nom) AS NOMVILLE, " +
                " cf_societes_id, cf_poles_id, " +
                " a.phone, a.otherphone, a.email1, a.email2, a.website, a.fax, " +
                " adr.bill_code, adr.bill_street, s.at_key, s.societes_no,s.nom " +
                " FROM vtiger_relations r " +
                " INNER JOIN vtiger_relationscf rc ON rc.relationsid = r.relationsid " +
                " INNER JOIN vtiger_crmentity e ON e.crmid = r.relationsid " +
                " INNER JOIN vtiger_societes s ON s.societesid = r.cf_societes_id " +
                " INNER JOIN vtiger_account a ON a.accountid = r.cf_accounts_id " +
                " INNER JOIN vtiger_accountbillads adr ON adr.accountaddressid = r.cf_accounts_id " +
                " LEFT JOIN vtiger_poles p ON p.polesid = r.cf_poles_id  " +

                //" WHERE (s.at_key = p.nom  OR s.at_key = 'ADEFINIR') " +
                " WHERE (s.at_key = p.nom  OR s.at_key = '" + SocieteSage.Text + "') " +
                " AND e.deleted = 0 ";
            if (ClientSage != "")
                SQL += " AND rc.cf_1159 = '" + ClientSage + "'";
            SQL += " ORDER BY a.accountname ";*/

            //oleCommandCRM.CommandText = SQL;
            //OleDbDataReader ReaderCRM = oleCommandCRM.ExecuteReader();
            
            /*CommandCRM.CommandText = SQL;
            MySqlDataReader ReaderCRM = CommandCRM.ExecuteReader();

            SClientCRM.BackColor = Color.White;
            while (ReaderCRM.Read())
            {
                IndexSel += 1;
                NomVille = Convert.ToString(ReaderCRM["NOMVILLE"]);

                //SClientCRM.Items.Add(new ComboItemCRM(ReaderCRM.GetGuid(0), NomVille));   //20191029
                string Guid_Account = Convert.ToString(ReaderCRM["Guid_Account"]);
                char[] charSeparators = new char[] { '-' };
                string[] tabAccount;
                tabAccount = Guid_Account.Split(charSeparators);
                string guidTiers = tabAccount[tabAccount.Length - 1];
                Int32 CodeTiers = Convert.ToInt32(ReaderCRM["CodeTiers"]);

                SClientCRM.Items.Add(new ComboItemCRM(CodeTiers, NomVille));

                if ((ClientCRM.ToString() == "") && (IndexSel == 0) && (ClientSage != ""))
                {
                    //MessageBox.Show("ClientCRM Liste : " + ClientCRMDebut.ToString());
                    if (NombreClient == 1)
                    {
                        //ClientCRMDebut = ReaderCRM.GetGuid(0);//20191029
                        ClientCRMDebut = ReaderCRM.GetString(1);
                        NomVille = Convert.ToString(ReaderCRM["NOMVILLE"]);
                        SClientCRM.SelectedText = Convert.ToString(ReaderCRM["NOMVILLE"]);
                        SClientCRM.SelectedIndex = IndexSel;
                        SClientCRM.Text = Convert.ToString(ReaderCRM["NOMVILLE"]);
                        SClientCRM.BackColor = Color.White;
                    }
                    else
                        SClientCRM.BackColor = Color.Red;
                }

                //if (ReaderCRM.GetGuid(0).ToString() == ClientCRM.ToString())
                if (CodeTiers.ToString() == ClientCRM.ToString())
                {
                    NomVille = Convert.ToString(ReaderCRM["NOMVILLE"]);
                    SClientCRM.SelectedText = Convert.ToString(ReaderCRM["NOMVILLE"]);
                    SClientCRM.SelectedIndex = IndexSel;
                }
            }
            ReaderCRM.Close();*/
        }

        private void RechercheInfoClient(Object ClientCRM, Object InterloCRM, Object LogicielCRM, Object MaterielCRM)
        {
            //MessageBox.Show("ClientCRM Info : " + ClientCRM.ToString());
            if (ClientCRM.ToString() != "")
            {
                // Recherche Adresse client
                Int16 IndexSel = 0;
                string NomVille = "";
                /*  //20191029
                string SQL = "SELECT distinct [AccountBase].[AccountId], ";
                SQL += " CASE WHEN [City] IS NOT NULL THEN [AccountBase].[Name] + ' - ' + [City]  ELSE [AccountBase].[Name] END AS NOMVILLE, ";
                SQL += "  [AccountBase].[Name] as NomClient,[Line1], [Line2], [Line3], [City],[PostalCode],[Country], ";
                SQL += " AccountExtensionBase.[new_chemin] ";
                SQL += " FROM [AccountBase] ";
                SQL += " INNER JOIN AccountExtensionBase ON AccountBase.AccountId=AccountExtensionBase.AccountId ";
                SQL += " LEFT JOIN [CustomerAddressBase] ON  ([AccountBase].[AccountId] = [CustomerAddressBase].[ParentId]) ";
                SQL += "  and ([CustomerAddressBase].AddressNumber=1)  AND ((CustomerTypeCode IS NULL) OR (CustomerTypeCode !=11)) ";
                SQL += " WHERE  ([AccountBase].[AccountId] ='" + ClientCRM + "')";
                oleCommandCRMCli.CommandText = SQL;
                OleDbDataReader ReaderCRMCli = oleCommandCRMCli.ExecuteReader();
                 */
                string SQL = "SELECT a.accountname AS NomClient, CONCAT('Tel. ',a.phone)  AS Line2, a.otherphone, a.email1, a.email2, a.website, CONCAT('Fax. ',a.fax) AS Line3, " +
                             " adr.bill_city AS City, adr.bill_code AS PostalCode, adr.bill_street AS Line1, CONCAT(a.accountname, ' - ',adr.bill_city) AS NOMVILLE " +
                             " FROM vtiger_account a " +
                             " LEFT JOIN vtiger_accountbillads adr ON adr.accountaddressid = a.accountid " +
                             " INNER JOIN vtiger_crmentity e ON e.crmid = a.accountid " +
                             " WHERE (e.deleted = 0) AND (a.accountid ='" + ClientCRM + "')";


                CommandCRMCli.CommandText = SQL;
                MySqlDataReader ReaderCRMCli = CommandCRMCli.ExecuteReader();
                if (ReaderCRMCli.Read())
                {
                    NomClient.Text = Convert.ToString(ReaderCRMCli["NomClient"]);
                    Adresse1.Text = Convert.ToString(ReaderCRMCli["Line1"]);
                    Adresse2.Text = Convert.ToString(ReaderCRMCli["Line2"]);
                    Adresse3.Text = Convert.ToString(ReaderCRMCli["Line3"]);
                    CodePostal.Text = Convert.ToString(ReaderCRMCli["PostalCode"]);
                    Ville.Text = Convert.ToString(ReaderCRMCli["City"]);
                    NomVille = Convert.ToString(ReaderCRMCli["NOMVILLE"]);
                }
                ReaderCRMCli.Close();

                // Liste des interlocuteurs client
                IndexSel = -1;
                SInterlocuteur.Items.Clear();
                /* //20191029
                SQL = "SELECT ContactId,COALESCE([FirstName] + ' ' + [LastName],COALESCE([FirstName],[LastName])) AS NomPrenom "
                           + "FROM [ContactBase] "
                           + "WHERE [AccountId]= '" + ClientCRM + "' AND DeletionStateCode = 0";
                 oleCommandCRMCli.CommandText = SQL;
                ReaderCRMCli = oleCommandCRMCli.ExecuteReader();
                 */
                SQL = "SELECT c.contactid AS CodeInterlo, CONCAT(c.firstName,' ',c.lastname) AS NomPrenom  FROM vtiger_contactdetails c " +
                      " INNER JOIN vtiger_crmentity e ON e.crmid = c.contactid " +
                      " WHERE e.deleted = 0 AND accountid ='" + ClientCRM + "'";

                CommandCRMCli.CommandText = SQL;
                ReaderCRMCli = CommandCRMCli.ExecuteReader();
                while (ReaderCRMCli.Read())
                {
                    IndexSel += 1;
                    //SInterlocuteur.Items.Add(new ComboItemCRM(ReaderCRMCli.GetGuid(0), ReaderCRMCli.GetString(1)));   //20191029
                    Int32 CodeInterlo = Convert.ToInt32(ReaderCRMCli["CodeInterlo"]);
                    SInterlocuteur.Items.Add(new ComboItemCRM(CodeInterlo, ReaderCRMCli.GetString(1)));

                    // Recherche Interlocuteur sélectionné
                    //if (ReaderCRMCli.GetGuid(0).ToString() == InterloCRM.ToString())  //20191029
                    if (CodeInterlo.ToString() == InterloCRM.ToString())
                    {
                        SInterlocuteur.SelectedText = Convert.ToString(ReaderCRMCli["NomPrenom"]);
                        SInterlocuteur.SelectedIndex = IndexSel;
                    }
                }
                ReaderCRMCli.Close();

                // Liste des logiciels client
                IndexSel = -1;
                SLogiciel.Items.Clear();
                /*  //20191029
                SQL = "SELECT New_ParcGestionExtensionBase.new_ParcGestionId, StringMap_2.[Value] AS Type, StringMap_1.[Value] AS 'Editeur', "
          + "StringMap_3.[Value] AS 'Gamme', New_ParcGestionExtensionBase.New_Version AS 'Version', New_ParcGestionExtensionBase.New_ParcGestionId AS 'idMateriel' "
          + "FROM New_ParcGestionExtensionBase LEFT OUTER JOIN StringMap StringMap_3 ON New_ParcGestionExtensionBase.New_Gamme = StringMap_3.AttributeValue AND StringMap_3.AttributeName = 'New_Gamme' "
          + "LEFT OUTER JOIN StringMap StringMap_5 ON New_ParcGestionExtensionBase.New_Contrat = StringMap_5.AttributeValue AND StringMap_5.AttributeName = 'New_Contrat' "
          + "LEFT OUTER JOIN StringMap StringMap_4 ON New_ParcGestionExtensionBase.New_Reseau = StringMap_4.AttributeValue AND StringMap_4.AttributeName = 'New_Reseau' "
          + "LEFT OUTER JOIN StringMap StringMap_2 ON New_ParcGestionExtensionBase.New_TypeG = StringMap_2.AttributeValue AND StringMap_2.AttributeName = 'New_TypeG' "
          + "LEFT OUTER JOIN StringMap StringMap_1 ON New_ParcGestionExtensionBase.New_editeur = StringMap_1.AttributeValue AND StringMap_1.AttributeName = 'New_editeur' "
          + "WHERE (New_ParcGestionExtensionBase.new_gestionid = '" + ClientCRM + "')";
                oleCommandCRMCli.CommandText = SQL;
                ReaderCRMCli = oleCommandCRMCli.ExecuteReader();

                 */
                SQL = "SELECT l.parclogicielid AS CodeLog, l.cf_societes_id, l.nom, " +
                      " lcf.cf_1047 AS Type, lcf.cf_1045 AS Editeur, lcf.cf_1049 AS Gamme, CONCAT(lcf.cf_1051,' ',lcf.cf_1055) AS Version " +
                      " FROM vtiger_parclogiciel l  " +
                      " LEFT JOIN vtiger_parclogicielcf lcf ON lcf.parclogicielid = l.parclogicielid " +
                      " INNER JOIN vtiger_crmentity e ON e.crmid = l.parclogicielid  " +
                      " WHERE (e.deleted = 0) AND (l.cf_accounts_id = '" + ClientCRM + "')";

                CommandCRMCli.CommandText = SQL;
                ReaderCRMCli = CommandCRMCli.ExecuteReader();
                String LibLogiciel = "";
                while (ReaderCRMCli.Read())
                {
                    IndexSel += 1;
                    LibLogiciel = Convert.ToString(ReaderCRMCli["Type"]) + " - " + Convert.ToString(ReaderCRMCli["Editeur"]) + " - " + Convert.ToString(ReaderCRMCli["Gamme"]) + " - " + Convert.ToString(ReaderCRMCli["Version"]);
                    //SLogiciel.Items.Add(new ComboItemCRM(ReaderCRMCli.GetGuid(0), LibLogiciel));  //20191029
                    Int32 CodeLogiciel = Convert.ToInt32(ReaderCRMCli["CodeLog"]);
                    SLogiciel.Items.Add(new ComboItemCRM(CodeLogiciel, LibLogiciel));

                    // Recherche logiciel sélectionné
                    //if (ReaderCRMCli.GetGuid(0).ToString() == LogicielCRM.ToString()) //20191029
                    if (CodeLogiciel.ToString() == LogicielCRM.ToString())
                    {
                        SLogiciel.SelectedText = LibLogiciel;
                        SLogiciel.SelectedIndex = IndexSel;
                    }
                }
                ReaderCRMCli.Close();

                // Liste des matériels client
                IndexSel = -1;
                SMateriel.Items.Clear();
                /*  //20191029
                SQL = "SELECT New_ParcRseauExtensionBase.New_ParcRseauId AS 'idMateriel',StringMap_2.[Value] AS Type, "
         + " StringMap_1.[Value] AS 'Fabricant', New_ParcRseauExtensionBase.New_designation AS 'Désignation' "
         + "FROM New_ParcRseauExtensionBase LEFT OUTER JOIN StringMap StringMap_1 "
         + "ON New_ParcRseauExtensionBase.New_Marque = StringMap_1.AttributeValue AND StringMap_1.AttributeName = 'New_Marque' "
         + "LEFT OUTER JOIN StringMap StringMap_2 "
         + "ON New_ParcRseauExtensionBase.New_Type = StringMap_2.AttributeValue AND StringMap_2.AttributeName = 'New_Type' "
         + "WHERE (New_ParcRseauExtensionBase.new_rseauid = '" + ClientCRM + "') "
         + "AND (StringMap_1.ObjectTypeCode = 10001) AND (StringMap_2.ObjectTypeCode = 10001)";
                oleCommandCRMCli.CommandText = SQL;
                ReaderCRMCli = oleCommandCRMCli.ExecuteReader();

                 */
                SQL = "SELECT m.parcmaterielid AS CodeMat, m.cf_societes_id, m.nomdumateriel, " +
                      " mcf.cf_1089 AS Type, mcf.cf_1091 AS Fabricant, mcf.cf_1093 AS Designation " +
                      " FROM vtiger_parcmateriel m  " +
                      " LEFT JOIN vtiger_parcmaterielcf mcf ON mcf.parcmaterielid = m.parcmaterielid " +
                      " INNER JOIN vtiger_crmentity e ON e.crmid = m.parcmaterielid " +
                      " WHERE (e.deleted = 0) AND (m.cf_accounts_id = '" + ClientCRM + "')";
                CommandCRMCli.CommandText = SQL;
                ReaderCRMCli = CommandCRMCli.ExecuteReader();
                String LibMateriel = "";
                while (ReaderCRMCli.Read())
                {
                    IndexSel += 1;
                    LibMateriel = Convert.ToString(ReaderCRMCli["Type"]) + " - " + Convert.ToString(ReaderCRMCli["Fabricant"]) + " - " + Convert.ToString(ReaderCRMCli["Designation"]);
                    //SMateriel.Items.Add(new ComboItemCRM(ReaderCRMCli.GetGuid(0), LibMateriel));
                    Int32 CodeMateriel = Convert.ToInt32(ReaderCRMCli["CodeMat"]);
                    SMateriel.Items.Add(new ComboItemCRM(CodeMateriel, LibMateriel));
                    // Recherche matériel sélectionné
                    //if (ReaderCRMCli.GetGuid(0).ToString() == MaterielCRM.ToString())
                    if (CodeMateriel.ToString() == MaterielCRM.ToString())
                    {
                        SMateriel.SelectedText = LibMateriel;
                        SMateriel.SelectedIndex = IndexSel;
                    }
                }
                ReaderCRMCli.Close();

                // Recherche client dans ListeClientVP
                string LibVP = NomClient.Text.Trim() + " / " + CodePostal.Text.Trim() + " / " + Ville.Text.Trim();
                ListeVP.SelectedText = "";
                ListeVP.SelectedIndex = -1;
                ListeVP.Text = "";
                NomVP.Text = "";
                CPVP.Text = "";
                VilleVP.Text = "";

                for (int T = 0; T <= ListeVP.Items.Count - 1; T++)
                {
                    ComboItemVP item = ListeVP.Items[T] as ComboItemVP;
                    if (LibVP == item.Value.ToString())
                    {
                        ListeVP.SelectedText = LibVP;
                        ListeVP.SelectedIndex = T;
                        T = ListeVP.Items.Count;
                    }

                }

            }
        }

        private void SClientSage_TextChanged(object sender, EventArgs e)
        {
            if (Recherche == true)
                RemplissageListe(SClientSage.Text, SClientCRM.Text);
        }

        private void SClientCRM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((SClientCRM.SelectedItem != null) && (Recherche == true))
            {
                ComboItemCRM item = SClientCRM.SelectedItem as ComboItemCRM;
                RechercheInfoClient(item.Key, "", "", "");
            }
        }


        private void ListeCommande_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Validation dans la base Transfert_VP si Commande Non envoyée
            //Valide_Commande();

            if (ListeCommande.SelectedItem != null)
            {
                ComboItem item = ListeCommande.SelectedItem as ComboItem;
                String F = item.Value.Substring(item.Value.Length - 1, 1);
                ClientCRMDebut = "";
                AffichageCommande(item.Key, Convert.ToInt32(F));
            }
        }

        private void BoutValide_Click(object sender, EventArgs e)
        {
            // Validation dans la base Transfert_VP si Commande Non envoyée
            //Valide_Commande();
        }

        private void Valide_Commande()
        {
            // Validation dans la base Transfert_VP si Commande Non envoyée
            if ((SCommande.Text != "") && (!SEnvoi.Checked))
            {
                DGVCRM.EndEdit();
                BSourceCRM.EndEdit();

                Object CliCRM = "";
                Object InterloCRM = "";
                Object LogCRM = "";
                Object MatCRM = "";
                Object Domaine = "";

                if (SClientCRM.Text != "")
                {
                    if (SClientCRM.SelectedItem != null)
                    {
                        ComboItemCRM item = SClientCRM.SelectedItem as ComboItemCRM;
                        CliCRM = item.Key;
                    }
                    else
                    {
                        ComboItemCRM item = SClientCRM.Items[SClientCRM.SelectedIndex + 1] as ComboItemCRM;
                        CliCRM = item.Key;
                    }
                }

                if (SInterlocuteur.Text != "")
                {
                    if (SInterlocuteur.SelectedItem != null)
                    {
                        ComboItemCRM item = SInterlocuteur.SelectedItem as ComboItemCRM;
                        InterloCRM = item.Key;
                    }
                    else
                    {
                        ComboItemCRM item = SInterlocuteur.Items[SInterlocuteur.SelectedIndex + 1] as ComboItemCRM;
                        InterloCRM = item.Key;
                    }
                }

                if (SLogiciel.Text != "")
                {
                    if (SLogiciel.SelectedItem != null)
                    {
                        ComboItemCRM item = SLogiciel.SelectedItem as ComboItemCRM;
                        LogCRM = item.Key;
                    }
                    else
                    {
                        ComboItemCRM item = SLogiciel.Items[SLogiciel.SelectedIndex + 1] as ComboItemCRM;
                        LogCRM = item.Key;
                    }
                }

                if (SMateriel.Text != "")
                {
                    if (SMateriel.SelectedItem != null)
                    {
                        ComboItemCRM item = SMateriel.SelectedItem as ComboItemCRM;
                        MatCRM = item.Key;
                    }
                    else
                    {
                        ComboItemCRM item = SMateriel.Items[SMateriel.SelectedIndex + 1] as ComboItemCRM;
                        MatCRM = item.Key;
                    }
                }

                /*if ((SDomaine.Text != ""))
                {
                    if (SDomaine.SelectedItem != null)
                    {
                        ComboItemPole item = SDomaine.SelectedItem as ComboItemPole;
                        Domaine = item.Key;
                    }
                    else
                    {
                        ComboItemPole item = SDomaine.Items[SDomaine.SelectedIndex + 1] as ComboItemPole;
                        Domaine = item.Key;
                    }
                }*/

                string SQL = "SELECT * from CommandeSage Where CSType =" + TypeDoc;
                SQL += " AND CSPiece ='" + SCommande.Text + "' AND CSSociete= '" + TxtSociete + "'";
                //SQL += " and CSDomaine =" + DomaineOri;
                oleCommandLib.CommandText = SQL;
                OleDbDataReader Reader = oleCommandLib.ExecuteReader();

                if (Reader.Read())
                {
                    SQL = "UPDATE CommandeSage SET ";
                    SQL += "CSDate ='" + Convert.ToDateTime(SDate.Text) + "'";
                    SQL += ", CSClient ='" + SClientSage.Text + "'";
                    if (CliCRM.ToString() != "")
                        SQL += ", CSClientCRM ='" + CliCRM.ToString() + "'";
                    else
                        SQL += ", CSClientCRM =null";
                    if (InterloCRM.ToString() != "")
                        SQL += ", CSInterlocuteur ='" + InterloCRM.ToString() + "'";
                    else
                        SQL += ", CSInterlocuteur =null";
                    if (LogCRM.ToString() != "")
                        SQL += ", CSLogiciel = '" + LogCRM.ToString() + "'";
                    else
                        SQL += ", CSLogiciel = null";
                    if (MatCRM.ToString() != "")
                        SQL += ", CSMateriel ='" + MatCRM.ToString() + "'";
                    else
                        SQL += ", CSMateriel =null";
                   // SQL += ", CSDomaine =" + Domaine.ToString();
                    SQL += ", CSTypeRDV = '" + STypeRDV.Text + "'";

                    SQL += " Where CSType = " + TypeDoc;
                    SQL += " AND CSPiece ='" + SCommande.Text + "'";
                    SQL += " AND CSSociete= '" + TxtSociete + "'";
                   // SQL += " and CSDomaine =" + DomaineOri;
                }
                else
                {
                    SQL = "INSERT Into CommandeSage ";
                    SQL += "(CSSociete, CSType, CSPiece, CSDate, CSClient, CSClientCRM, CSInterlocuteur, CSLogiciel, CSMateriel, CSDomaine, CSTypeRDV, CSEnvoi) ";
                    SQL += "Values (";
                    SQL += "'" + TxtSociete + "'," + TypeDoc + ",'" + SCommande.Text + "','" + Convert.ToDateTime(SDate.Text) + "','" + SClientSage.Text + "'";
                    if (CliCRM.ToString() != "")
                        SQL += ", '" + CliCRM.ToString() + "'";
                    else
                        SQL += ", null";
                    if (InterloCRM.ToString() != "")
                        SQL += ", '" + InterloCRM.ToString() + "'";
                    else
                        SQL += ", null";
                    if (LogCRM.ToString() != "")
                        SQL += ", '" + LogCRM.ToString() + "'";
                    else
                        SQL += ", null";
                    if (MatCRM.ToString() != "")
                        SQL += ", '" + MatCRM.ToString() + "'";
                    else
                        SQL += ", null";
                    SQL += ", " + Domaine.ToString() + "";

                    SQL += ",'" + STypeRDV.Text + "'";
                    if (SEnvoi.Checked)
                        SQL += ",1";
                    else
                        SQL += ",0";
                    SQL += ")";

                    String Lib = SCommande.Text + " - " + SClientSage.Text + " - " +
                                 Convert.ToDateTime(SDate.Text).ToString("dd/MM/yyyy") +
                                 " - " + Domaine.ToString();
                    ListeCommande.Items.Add(new ComboItem(SCommande.Text, Lib));

                }

                Reader.Close();
                oleComInsert.CommandText = SQL;
                oleComInsert.ExecuteNonQuery();

                // MAJ des lignes
                SQL = "Delete from CommandeSageLigne Where CSLType =" + TypeDoc;
                SQL += " AND CSLPiece ='" + SCommande.Text + "' AND CSLSociete= '" + TxtSociete + "'";
                //SQL += " and CSLDomaine =" + DomaineOri;
                oleComInsert.CommandText = SQL;
                oleComInsert.ExecuteNonQuery();

                for (int i = 0; i <= DGVCRM.RowCount - 1; i++)
                {
                    if ((DGVCRM[2, i].Value != null) && (DGVCRM[2, i].Value.ToString().Length != 0))
                    {
                        SQL = "Insert into CommandeSageLigne (CSLSociete, CSLType, CSLPiece, CSLDomaine, CSLTypeRDV, CSLLigne, CSLTypeCde, CSLLibelle, ";
                        SQL += " CSLCommentaire,CSLNbJours, CSLIdentifiant) Values (";
                        SQL += "'" + TxtSociete + "', ";
                        SQL += TypeDoc + ",";
                        SQL += " '" + SCommande.Text + "',";
                        SQL += " '" + DGVCRM[0, i].Value + "',";
                        SQL += " '" + DGVCRM[1, i].Value + "',";
                        SQL += (i + 1) + ",";
                        SQL += " '" + DGVCRM[2, i].Value + "',";
                        SQL += " '" + DGVCRM[3, i].Value.ToString().Replace("'", "''") + "',";
                        SQL += " '" + DGVCRM[5, i].Value.ToString().Replace("'", "''") + "',";
                        SQL += " '" + DGVCRM[4, i].Value.ToString().Replace(",", ".") + "',";
                        if ((DGVCRM[6, i].Value != null) && (DGVCRM[6, i].Value.ToString().Length != 0))
                            SQL += " '" + DGVCRM[6, i].Value + "'";
                        else
                            SQL += "null ";
                        SQL += ")";

                        oleComInsert.CommandText = SQL;
                        oleComInsert.ExecuteNonQuery();
                    }
                }

                //DomaineOri = Convert.ToInt32(Domaine);
                Valide_Cde = true;
            }
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            Valide_Commande();

            oleConnect.Close();
            //oleConnectCRM.Close();
            oleConnectSage.Close();
            connMySQL.Close();
            if (Envoi)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
                Close();

        }

        private void BoutSage_Click(object sender, EventArgs e)
        {
            Numero = SCommande.Text;
            EnvoiProgSage(Numero);

        }

        private void EnvoiProgSage(Object Numero)
        {
            //"C:\Appli\SageV1605\Sage Entreprise\GecoMaes.exe " "C:\Users\Public\Documents\Sage\Sage Entreprise\bijou.gcm" /u"<Administrateur>" /p
            //"C:\Appli\SageV1605\Sage Entreprise\GecoMaes.exe " "C:\Users\Public\Documents\Sage\Sage Entreprise\bijou.gcm"  /cmd="Tiers.Show(Tiers='CARAT')" /u"<Administrateur>" /p

            // Retour à Sage
            Char[] sepChars = new Char[1];
            sepChars[0] = '"';

            // recherche du programme Sage
            String NomProg = @"C:\Program Files\SageV1605\Sage Entreprise\GecoMaes.exe";

            // dans la table Users System
            String req = "SELECT USRepertSage FROM USERS WHERE USUSER ='" + System.Environment.UserName + "'";
            oleCommandLib.CommandText = req;
            OleDbDataReader Reader = oleCommandLib.ExecuteReader();
            if (Reader.Read())
            {
                if (!Reader.IsDBNull(0))
                    NomProg = Reader.GetString(0).Trim();
                Reader.Close();
            }
            else
            {
                //  dans la table TypeDoc
                Reader.Close();
                String req2 = "SELECT TDEnumerateur FROM TYPEDOC WHERE TDTYPE ='.'";
                oleCommandLib.CommandText = req2;
                OleDbDataReader ReaderTD = oleCommandLib.ExecuteReader();
                if (ReaderTD.Read())
                {
                    if (!ReaderTD.IsDBNull(0))
                        NomProg = ReaderTD.GetString(0).Trim();
                }
                ReaderTD.Close();
            }

            req = "SELECT TDVALEUR, TDEnumerateur FROM TYPEDOC ";
            req = req + " WHERE TDTable='F_DOCENTETE' AND UPPER(TDVALEUR) ='" + TypeDoc.ToUpper() + "' ";
            oleCommandLib.CommandText = req;
            Reader = oleCommandLib.ExecuteReader();
            if (Reader.Read())
            {
                if (!Reader.IsDBNull(1))
                    Enumerateur = Reader.GetString(1).Trim();
            }
            Reader.Close();

            Process myInfo = new Process();
            myInfo.StartInfo.FileName = sepChars[0] + NomProg + sepChars[0];

            String Argum = "";
            Argum = sepChars[0] + CheminSoc + sepChars[0];

            if (Numero.ToString() != "")
            {
                Argum += " /cmd=" + sepChars[0] + "Document.Show(Type=" + Enumerateur + ",Piece='" + Numero + "')" + sepChars[0];
            }
            Argum += @" /u" + sepChars[0] + User + sepChars[0] + " /p";
            if (Mdp != "")
                Argum += sepChars[0] + Mdp + sepChars[0];

            //MessageBox.Show(Argum);
            myInfo.StartInfo.Arguments = Argum;
            myInfo.Start();

            oleConnect.Close();
            //oleConnectCRM.Close();
            oleConnectSage.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void BoutRAZ_Click(object sender, EventArgs e)
        {
            RAZAffichage();
            SCommande.Text = "";
            SClientSage.Text = "";
            Recherche = true;

            SCommande.Focus();
        }

        private void BoutSuppression_Click(object sender, EventArgs e)
        {
            if (SEnvoi.Checked)
            {
                MessageBox.Show("La commande a été envoyée dans l'intranet. La suppression est interdite.");
            }
            else
            {
                if (MessageBox.Show("Voulez-vous supprimer la commande " + SCommande.Text + " ?\r\nCela vous permet de la supprimer du programme d'envoi pour la reparamétrer", "Suppression ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    try
                    {
                        String SQL = "DELETE FROM CommandeSage ";
                        SQL += " Where CSType = " + TypeDoc;
                        SQL += " AND CSPiece ='" + SCommande.Text + "' AND CSDomaine = " + DomaineOri + " AND CSSociete= '" + TxtSociete + "'";
                        oleComInsert.CommandText = SQL;
                        oleComInsert.ExecuteNonQuery();

                        SQL = "DELETE FROM CommandeSageLigne ";
                        SQL += " Where CSLType = " + TypeDoc;
                        SQL += " AND CSLPiece ='" + SCommande.Text + "' AND CSLDomaine = " + DomaineOri + "' AND CSLSociete= '" + TxtSociete + "'";
                        //SQL += " AND CSLDomaine = " + DomaineOri;
                        oleComInsert.CommandText = SQL;
                        oleComInsert.ExecuteNonQuery();

                        ListeCommandeAffiche();
                        RAZAffichage();
                        int NbrLig = DGVCRM.RowCount - 1;
                        for (int i = NbrLig; i > 0; i--)
                        {
                            DGVCRM.Rows.RemoveAt(i - 1);
                        }
                        DGVCRM.Refresh();
                        NbrLig = DGVSage.RowCount;
                        for (int i = NbrLig; i > 0; i--)
                        {
                            DGVSage.Rows.RemoveAt(i - 1);
                        }
                        DGVSage.Refresh();

                    }

                    catch (Exception ex)
                    {
                        LStatus.Text = Commun.GestErreur.Ajoute(this.Name, ex);
                    }
                }
            }

        }

        private void boutAjoutContact_Click(object sender, EventArgs e)
        {
            object CliCRM = "";
            if (SClientCRM.Text != "")
            {
                if (SClientCRM.SelectedItem != null)
                {
                    ComboItemCRM item = SClientCRM.SelectedItem as ComboItemCRM;
                    CliCRM = item.Key;
                }
                else
                {
                    ComboItemCRM item = SClientCRM.Items[SClientCRM.SelectedIndex + 1] as ComboItemCRM;
                    CliCRM = item.Key;
                }
                UFAjoutContact AjoutContact = new UFAjoutContact();
                AjoutContact.lblIdClient = CliCRM.ToString();
                AjoutContact.lblClientSage = SClientSage.Text.Trim();
                AjoutContact.lblSocSage = TxtSociete.Trim();
                AjoutContact.ShowDialog();

                String LibContact = AjoutContact.LibelleContact;
                Int32 CodContact = AjoutContact.CodeContact;
                if (LibContact != "")
                    SInterlocuteur.Items.Add(new ComboItemCRM(CodContact, LibContact));
            }
        }

        private void boutAjoutLogiciel_Click(object sender, EventArgs e)
        {
            object CliCRM = "";
            if (SClientCRM.Text != "")
            {
                if (SClientCRM.SelectedItem != null)
                {
                    ComboItemCRM item = SClientCRM.SelectedItem as ComboItemCRM;
                    CliCRM = item.Key;
                }
                else
                {
                    ComboItemCRM item = SClientCRM.Items[SClientCRM.SelectedIndex + 1] as ComboItemCRM;
                    CliCRM = item.Key;
                }
                UFAjoutLogiciel AjoutLogiciel = new UFAjoutLogiciel();
                AjoutLogiciel.lblIdClient = CliCRM.ToString();
                AjoutLogiciel.lblClientSage = SClientSage.Text.Trim();
                AjoutLogiciel.lblSocSage = TxtSociete.Trim();
                AjoutLogiciel.ShowDialog();

                String LibLogiciel = AjoutLogiciel.LibelleLogiciel;
                Int32 CodLogiciel = AjoutLogiciel.CodeLogiciel;
                if (LibLogiciel != "")
                    SLogiciel.Items.Add(new ComboItemCRM(CodLogiciel, LibLogiciel));
            }
        }

        private void boutAjoutMateriel_Click(object sender, EventArgs e)
        {
            object CliCRM = "";
            if (SClientCRM.Text != "")
            {
                if (SClientCRM.SelectedItem != null)
                {
                    ComboItemCRM item = SClientCRM.SelectedItem as ComboItemCRM;
                    CliCRM = item.Key;
                }
                else
                {
                    ComboItemCRM item = SClientCRM.Items[SClientCRM.SelectedIndex + 1] as ComboItemCRM;
                    CliCRM = item.Key;
                }
                UFAjoutMateriel AjoutMateriel = new UFAjoutMateriel();
                AjoutMateriel.lblIdClient = CliCRM.ToString();
                AjoutMateriel.lblClientSage = SClientSage.Text.Trim();
                AjoutMateriel.lblSocSage = TxtSociete.Trim();
                AjoutMateriel.ShowDialog();

                String LibMateriel = AjoutMateriel.LibelleMateriel;
                Int32 CodMateriel = AjoutMateriel.CodeMateriel;
                if (LibMateriel != "")
                    SMateriel.Items.Add(new ComboItemCRM(CodMateriel, LibMateriel));

            }

        }

        private void BoutSociete_Click(object sender, EventArgs e)
        {
            UFAjoutSociete AjoutSociete = new UFAjoutSociete();
            AjoutSociete.ShowDialog();
        }

        private void BoutEnvoiCRM_Click(object sender, EventArgs e)
        {
            Valide_Commande();
            EnvoiCRM();
        }

        private void EnvoiCRM()
        {
            if (!SEnvoi.Checked)
            {
                string CliDoc = "";
                string DateDoc = "";
                object ClientCRM = "";
                object InterlocuteurCRM = "null";
                object LogicielCRM = "null";
                object MaterielCRM = "null";
                object LogicielMateriel = "null";
                object DomaineCRM = "";
                string TypeRDVVP = "";
                object TypeDemande = "null";
                Int32 TypeDemande2 = 0;

                //Boolean EnvoiCRM = false;
                string Libelle = "";
                string Commentaire = "";
                Double NbJours = 0;
                Object lblAutoGuid = "";

                String lblNomUser = System.Environment.UserName;
                string lblIdUserCRM = "";
                // Récup GUID de l'utilisateur
                /*
                string chaineSQL1 = "SELECT id FROM vtiger_users WHERE user_name = '" + lblNomUser + "'";
                CommandCRM.CommandText = chaineSQL1;
                MySqlDataReader ReaderCRM = CommandCRM.ExecuteReader();
                if (ReaderCRM.Read())
                    lblIdUserCRM = ReaderCRM.GetInt32(0).ToString();
                ReaderCRM.Close();*/

                String SQL = "select  CSLDOMAINE , CSLTypeRDV , CSLTypeCde , CSLLibelle, CSLNbJours, CSLCommentaire ";//0-5
                SQL += ",CSDATE, CSCLIENT, CSCLIENTCRM, CSINTERLOCUTEUR, CSLOGICIEL, CSMATERIEL, CSENVOI, CSLLigne ";//6-13
                SQL += " FROM CommandeSageLigne  ";
                SQL += " INNER JOIN CommandeSage on CSLSociete=CSSociete AnD CSLType=CSType and CSLPiece=CSPiece ";
                SQL += " Where CSLType =" + TypeDoc;
                SQL += " AND CSLPiece ='" + SCommande.Text + "' AND CSLSociete= '" + TxtSociete + "'";
                SQL += " Order by CSLLigne";
                oleCommandLib.CommandText = SQL;
                OleDbDataReader Reader = oleCommandLib.ExecuteReader();

                while (Reader.Read())
                {
                    if (!Reader.IsDBNull(7))
                        CliDoc = Convert.ToString(Reader["CSClient"]);
                    if (!Reader.IsDBNull(6))
                        DateDoc = Convert.ToString(Convert.ToDateTime(Reader["CSDate"]));
                    if (!Reader.IsDBNull(8))
                        ClientCRM = Reader.GetInt32(8);
                    if (!Reader.IsDBNull(9))
                        InterlocuteurCRM = "'" + Reader.GetInt32(9) + "'";
                    if (!Reader.IsDBNull(10))
                        LogicielCRM = "'" + Reader.GetInt32(10) + "'";
                    if (!Reader.IsDBNull(11))
                        MaterielCRM = "'" + Reader.GetInt32(11) + "'";
                    if (!Reader.IsDBNull(0))
                        DomaineCRM = Convert.ToInt32(Reader["CSLDomaine"]);
                    if (!Reader.IsDBNull(1))
                        TypeRDVVP = Convert.ToString(Reader["CSLTypeRDV"]);
                    if (!Reader.IsDBNull(2))
                    {
                        TypeDemande = "'" + Reader.GetInt32(2) + "'";
                        TypeDemande2 = Reader.GetInt32(2);
                    }
                    if (!Reader.IsDBNull(3))
                        Libelle = Convert.ToString(Reader["CSLLibelle"]).Replace("'", "''");
                    if (!Reader.IsDBNull(5))
                        Commentaire = Convert.ToString(Reader["CSLCommentaire"]).Replace("'", "''");
                    if (!Reader.IsDBNull(6))
                        NbJours = Convert.ToDouble(Reader["CSLNbJours"]);

                    if (Libelle.Length >= 45)
                        Libelle = Libelle.Substring(0, 45) + " ...";

                    if (DomaineCRM.ToString() == "2")
                        LogicielMateriel = MaterielCRM;
                    else
                        LogicielMateriel = LogicielCRM;

                    MySqlCommand cmdCRM = new MySqlCommand();
                    cmdCRM.Connection = connMySQL;

                    // recherche libelle
                    /*string Lib_Domaine = "";
                    string SQL_D = "SELECT nom FROM `vtiger_poles` WHERE polesid=" + DomaineCRM;
                    cmdCRM.CommandText = SQL_D;
                    Lib_Domaine = cmdCRM.ExecuteScalar().ToString();*/

                    // Recherche libelle Type Demande
                    /*
                    string Lib_TypeDemande = "";
                    string SQL_T = "SELECT cf_1031 FROM `vtiger_cf_1031` WHERE cf_1031id=" + TypeDemande;
                    cmdCRM.CommandText = SQL_T;
                    Lib_TypeDemande = cmdCRM.ExecuteScalar().ToString();

                    String EditeurVP = "";
                    String ProduitVP = "";
                    String GammeVP = "";
                    Int32 Code_log = 0;
                    if (SLogiciel.Text != "")
                    {
                        if (SLogiciel.SelectedItem != null)
                        {
                            ComboItemCRM item = SLogiciel.SelectedItem as ComboItemCRM;
                            Code_log = item.Key;
                        }
                    }
                    SQL = "SELECT l.parclogicielid AS CodeLog, l.cf_societes_id, l.nom, " +
                  " lcf.cf_1047 AS Type, lcf.cf_1045 AS Editeur, lcf.cf_1049 AS Gamme, CONCAT(lcf.cf_1051,' ',lcf.cf_1055) AS Version " +
                  " FROM vtiger_parclogiciel l  " +
                  " LEFT JOIN vtiger_parclogicielcf lcf ON lcf.parclogicielid = l.parclogicielid " +
                  " INNER JOIN vtiger_crmentity e ON e.crmid = l.parclogicielid  " +
                  " WHERE (e.deleted = 0) AND (l.cf_accounts_id = '" + ClientCRM + "') AND l.parclogicielid =" + Code_log;

                    cmdCRM.CommandText = SQL;
                    ReaderCRM = cmdCRM.ExecuteReader();
                    if (ReaderCRM.Read())
                    {
                        if (!ReaderCRM.IsDBNull(2))
                            ProduitVP = Convert.ToString(ReaderCRM["Type"]).Replace("'", "''");
                        if (!ReaderCRM.IsDBNull(3))
                            EditeurVP = Convert.ToString(ReaderCRM["Editeur"]).Replace("'", "''");
                        if (!ReaderCRM.IsDBNull(5))
                            GammeVP = Convert.ToString(ReaderCRM["Gamme"]).Replace("'", "''");
                    }
                    ReaderCRM.Close();
                    */
                    // Recherche libelle Type Demande
                    string Lib_TypeDemande = "";
                    String EditeurVP = "";
                    String ProduitVP = "";
                    String GammeVP = "";
                    OleDbCommand command_VP = new OleDbCommand();
                    command_VP.Connection = oleConnect;
                    SQL = "SELECT logicielId, logicielName, logicielType, logicielEditeur FROM TYPEDEMANDE WHERE logicielId = " + TypeDemande2;
                    command_VP.CommandText = SQL;
                    OleDbDataReader ReaderDem = command_VP.ExecuteReader();
                    while (ReaderDem.Read())
                    {
                        if (!ReaderDem.IsDBNull(1))
                            Lib_TypeDemande = Convert.ToString(ReaderDem["logicielName"]);
                        if (!ReaderDem.IsDBNull(2))
                            ProduitVP = Convert.ToString(ReaderDem["logicielType"]);
                        if (!ReaderDem.IsDBNull(3))
                            EditeurVP = Convert.ToString(ReaderDem["logicielEditeur"]);

                    }
                    ReaderDem.Close();
                    //if (NbJours != 0)
                    //{
                    //String lblIdCasSubject = "";
                    //String lblNewTicket = "";

                    try
                    {
                        // Envoi dans la CRM : création du contact
                        //string url = Properties.Settings.Default.URL_Aditiger;
                        //url += "/apirest/post/Project";
                        string cleToken = Properties.Settings.Default.Cle_Token.Trim();

                        using (var wb = new WebClient())
                        {
                            var data = new NameValueCollection();
                            data["token"] = Commun.Commun.GetToken(cleToken);
                            data["societes"] = SocieteSage.Text.ToUpper().Trim();
                            data["accounts"] = SClientSage.Text.Trim();
                            data["users"] = System.Environment.UserName.Trim();
                            data["origin"] = "DIVALTO";
                            data["key"] = "";

                            data["NoDeCommande"] = SCommande.Text.Trim();
                            //data["PoleConcerne"] = Lib_Domaine.Trim();
                            data["Objet"] = Libelle.Trim();
                            data["Compte"] = SClientSage.Text.Trim();
                            data["JoursVendus"] = NbJours.ToString().Replace(",", ".");
                            data["Commentaire"] = Commentaire.Trim();

                            //data["TypeDemande"] = Lib_TypeDemande;

                            try
                            {
                               // var response = wb.UploadValues(url, "POST", data);
                               // string responseInString = Encoding.UTF8.GetString(response);
                                LStatus.Text = "Création de la commande dans la CRM OK";
                            }
                            catch (Exception ex2)
                            {
                                LStatus.Text = "Échec de la création de la commande dans la CRM";
                            }
                        }

                        // Recherche infos Client VP
                        String _NomVP = NomClient.Text.Replace("'", "''");
                        String _CPVP = CodePostal.Text;
                        String _VilleVP = Ville.Text.Replace("'", "''");
                        if (NomVP.Text != "")
                        {
                            _NomVP = NomVP.Text;
                            _CPVP = CPVP.Text;
                            _VilleVP = VilleVP.Text;
                        }

                        String noteVP = Libelle + " " + Commentaire;
                        if (noteVP.Length > 80)
                            noteVP = noteVP.Substring(0, 80);
    
                        // Mise à jour de la table COMMANDEVP
                        string chaineSQL4 = "INSERT INTO COMMANDEVP (CVPOBJET, CVPSOCIETE, CVPEDITEUR, CVPPRODUIT, CVPGAMME, CVPTYPERDV,  " +
                            "CVPTEMPS, CVPCLIENT, CVPDATE, CVPNOTE, CVPTRANSFERT, CVPCLIENTNOM, CVPCLIENTCP, CVPCLIENTVILLE, CVPDATEIMPORT) VALUES (";
                        chaineSQL4 += "'" + SCommande.Text + " - " + NomClient.Text.Replace("'", "''") + " - " + Ville.Text.Replace("'", "''") + "', ";
                        chaineSQL4 += "'" + SocieteSage.Text.ToUpper() + "', ";
                        chaineSQL4 += "'" + EditeurVP + "',";
                        chaineSQL4 += "'" + ProduitVP + "',";
                        chaineSQL4 += "'" + GammeVP + "', ";
                        chaineSQL4 += "'" + TypeRDVVP + "', ";
                        chaineSQL4 += NbJours.ToString().Replace(",", ".") + ", ";
                        chaineSQL4 += "'" + SClientSage.Text + "',";
                        chaineSQL4 += "'" + DateDoc + "',";
                        chaineSQL4 += "'" + Libelle + " " + Commentaire + "','false',";
                        chaineSQL4 += "'" + NomClient.Text.Replace("'", "''") + "',";
                        chaineSQL4 += "'" + CodePostal.Text + "', ";
                        chaineSQL4 += "'" + Ville.Text.Replace("'", "''") + "', ";
                        chaineSQL4 += "'" + Convert.ToString(DateTime.Now) + "'";
                        chaineSQL4 += ")";
                        oleComInsert.CommandText = chaineSQL4;
                        oleComInsert.ExecuteNonQuery();

                        // MAJ IDENTIFIANT DE L'INTRANET
                        string chaineSQL6 = " Update CommandeSageLigne set CSLIdentifiant='" + lblAutoGuid + "' ";
                        chaineSQL6 += " Where CSLType =" + TypeDoc;
                        chaineSQL6 += " AND CSLPiece ='" + SCommande.Text + "' AND CSLSociete= '" + TxtSociete + "' ";
                        chaineSQL6 += " AND CSLDOMAINE = " + DomaineCRM + " AND CSLTYPERDV = '" + TypeRDVVP + "' ";
                        chaineSQL6 += " AND CSLLIGNE = " + Convert.ToInt16(Reader["CSLLigne"]);
                        oleComInsert.CommandText = chaineSQL6;
                        oleComInsert.ExecuteNonQuery();

                        Int16 i = Convert.ToInt16(Reader["CSLLigne"]);
                        DGVCRM[6, i - 1].Value = lblAutoGuid;

                    }
                    catch (Exception exc)
                    {
                        LStatus.Text = exc.Message + " - " + lblAutoGuid.ToString();
                    }

                    //}
                }
                Reader.Close();

                // MAJ Envoi à True
                string chaineSQL5 = " Update CommandeSage set CSEnvoi='true' ";
                chaineSQL5 += " Where CSType =" + TypeDoc;
                chaineSQL5 += " AND CSPiece ='" + SCommande.Text + "' AND CSSociete= '" + TxtSociete + "'";
                oleComInsert.CommandText = chaineSQL5;
                oleComInsert.ExecuteNonQuery();

                DGVCRM.EndEdit();
                BSourceCRM.EndEdit();

                //Lancement de l'import dans VP
                Process p = new Process();
                p.StartInfo.FileName = Properties.Settings.Default.LienPlanning;
                p.Start();

                SEnvoi.Checked = true;
                labelEnvoi.Text = "Commande envoyée dans l'intranet.";
                DGVCRM.Enabled = false;
                SClientCRM.Enabled = false;
                SInterlocuteur.Enabled = false;
                SLogiciel.Enabled = false;
                SMateriel.Enabled = false;
            }
        }

        private void EnvoiPlanning()
        {
            bool fich = false;
            int ite = 0;
            string nomFichier = Application.StartupPath + "\\" + "Planning" + dateToString(Convert.ToString(DateTimeOffset.Now)) + ".txt";
            //On peut crée plusieurs fichiers SAGE le meme jour il faut donc les différencier:
            //Tant que le nom du fichier existe ou alors au premier passage
            while (fich == false)
            {
                //Si le fichier existe déja:
                if (File.Exists(nomFichier))
                {
                    //Si c'est la premier passage dans la boucle
                    if (ite == 0)
                    {
                        nomFichier = nomFichier.Insert(nomFichier.Length - 4, "_");
                        ite++;
                        nomFichier = nomFichier.Insert(nomFichier.Length - 4, Convert.ToString(ite));
                    }
                    else
                    {
                        ite++;
                        nomFichier = nomFichier.Substring(0, nomFichier.Length - (Convert.ToString(ite - 1).Length + 5)) + nomFichier.Substring(nomFichier.Length - (Convert.ToString(ite - 1).Length + 5)).Replace(Convert.ToString(ite - 1), Convert.ToString(ite));
                    }
                }
                else
                {
                    fich = true;
                }
            }

            //MessageBox.Show(nomFichier);

            Encoding ANSI = Encoding.GetEncoding(1252);
            StreamWriter scribe = new StreamWriter(nomFichier, false, ANSI);
            //if (SEnvoi.Checked)
            //{
            string SQL = "SELECT  * FROM CommandeVP  Where CVPTransfert = 0  or CVPTRansfert is null  Order by CVPSociete, CVPObjet";
            oleCommandLib.CommandText = SQL;
            OleDbDataReader Reader = oleCommandLib.ExecuteReader();

            while (Reader.Read())
            {
                String Ligne = Convert.ToString(Reader["CVPObjet"]);
                Ligne += ";";
                if (!Reader.IsDBNull(1))
                    Ligne += Convert.ToString(Reader["CVPSociete"]);
                Ligne += ";";
                if (!Reader.IsDBNull(2))
                    Ligne += Convert.ToString(Reader["CVPEditeur"]);
                Ligne += ";";
                if (!Reader.IsDBNull(3))
                    Ligne += Convert.ToString(Reader["CVPGamme"]);
                Ligne += ";";
                if (!Reader.IsDBNull(4))
                    Ligne += Convert.ToString(Reader["CVPProduit"]);
                Ligne += ";";
                if (!Reader.IsDBNull(5))
                    Ligne += Convert.ToString(Reader["CVPTypeRDV"]);
                Ligne += ";";
                if (!Reader.IsDBNull(6))
                    Ligne += Convert.ToString(Reader["CVPTemps"]);
                Ligne += ";";
                if (!Reader.IsDBNull(7))
                    Ligne += Convert.ToString(Reader["CVPClient"]);
                Ligne += ";";
                if (!Reader.IsDBNull(8))
                    Ligne += Convert.ToString(Reader["CVPDate"]);
                Ligne += ";";
                if (!Reader.IsDBNull(9))
                    Ligne += Convert.ToString(Reader["CVPNote"]);
                Ligne += ";";
                if (!Reader.IsDBNull(10))
                    Ligne += Convert.ToString(Reader["CVPClientNom"]);
                Ligne += ";";
                if (!Reader.IsDBNull(11))
                    Ligne += Convert.ToString(Reader["CVPClientCP"]);
                Ligne += ";";
                if (!Reader.IsDBNull(12))
                    Ligne += Convert.ToString(Reader["CVPClientVille"]);

                Ligne += ";";
                if (!Reader.IsDBNull(13))
                    Ligne += Convert.ToString(Reader["CVPDateImport"]);
                scribe.WriteLine(Ligne);
            }
            scribe.Close();
            //}


        }

        //Transforme un string de la forme JJ/MM/AAAA en string de la forme JJMMAA
        private string dateToString(string dateEntree)
        {
            if (dateEntree != null)
            {
                if (dateEntree.Length > 8)
                {
                    return dateEntree.Substring(0, 2) + dateEntree.Substring(3, 2) + dateEntree.Substring(8, 2);
                }
                else
                //Si le string en entrée ne correspond pas a une date valide on retourne une chaine vide
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
        }


        private void BoutDesenvoyer_Click(object sender, EventArgs e)
        {
            /*
            if (SEnvoi.Checked)
            {
                string SQL = "select  CSLIdentifiant ";
                SQL += " FROM CommandeSageLigne  ";
                SQL += " Where CSLType =" + TypeDocSage;
                SQL += " AND CSLPiece ='" + SCommande.Text + "' AND CSLSociete= '" + TxtSocSage + "'";
                SQL += " Order by CSLLigne";
                oleCommandLib.CommandText = SQL;
                OleDbDataReader Reader = oleCommandLib.ExecuteReader();

                while (Reader.Read())
                {
                    if (!Reader.IsDBNull(0))
                    {
                        string chaineSQL = "Update IncidentBase SET DELETIONStateCode = 2 ";
                        chaineSQL += " WHERE IncidentId='" + Reader.GetGuid(0) + "'";
                        oleCommandCRM.CommandText = chaineSQL;
                        oleCommandCRM.ExecuteNonQuery();

                        string chaineSQL1 = " Update CommandeSageLigne set CSLIdentifiant=null ";
                        chaineSQL1 += " Where CSLType =" + TypeDocSage;
                        chaineSQL1 += " AND CSLPiece ='" + SCommande.Text + "' AND CSLSociete= '" + TxtSocSage + "'";
                        oleComInsert.CommandText = chaineSQL1;
                        oleComInsert.ExecuteNonQuery();
                    }
                }
                Reader.Close();

                // Suppression dans la table CommandeVP
                string chaineSQL3 = "DELETE FROM COMMANDEVP WHERE ";
                chaineSQL3 += "CVPOBJET = '" + SCommande.Text + " - " + NomClient.Text.Replace("'", "''") + " - " + Ville.Text.Replace("'", "''") + "' ";
                chaineSQL3 += "AND CVPCLIENT = '" + SClientSage.Text + "' ";
                chaineSQL3 += "AND Upper(CVPSOCIETE) = '" + SocieteSage.Text.ToUpper() + "' ";
                //chaineSQL3 += "AND (CVPTRANSFERT = 0 or CVPTransfert is null)";
                oleComInsert.CommandText = chaineSQL3;
                oleComInsert.ExecuteNonQuery();

                // MAJ Envoi à False
                string chaineSQL2 = " Update CommandeSage set CSEnvoi='false' ";
                chaineSQL2 += " Where CSType =" + TypeDocSage;
                chaineSQL2 += " AND CSPiece ='" + SCommande.Text + "' AND CSSociete= '" + TxtSocSage + "'";
                oleComInsert.CommandText = chaineSQL2;
                oleComInsert.ExecuteNonQuery();

                for (int i = 0; i <= DGVCRM.RowCount - 1; i++)
                {
                    DGVCRM[6, i].Value = DBNull.Value;
                }
                DGVCRM.EndEdit();
                BSourceCRM.EndEdit();

                SEnvoi.Checked = false;
                labelEnvoi.Text = "";
                DGVCRM.Enabled = true;
                SClientCRM.Enabled = true;
                SInterlocuteur.Enabled = true;
                SLogiciel.Enabled = true;
                SMateriel.Enabled = true;
            }
            */
        }

        private void DGVCRM_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = DGVCRM.RowCount;
                if (i != 0)
                {
                    if ((DGVCRM[3, i - 2].Value != null) && (DGVCRM[3, i - 2].Value.ToString().Length != 0))
                    {
                        LibellePrec = DGVCRM[3, i - 2].Value.ToString();
                        DSCRM.Tables[0].Columns[3].DefaultValue = LibellePrec;
                    }
                    if ((DGVCRM[2, i - 2].Value != null) && (DGVCRM[2, i - 2].Value.ToString().Length != 0))
                    {
                        DemCRMPrec = DGVCRM[2, i - 2].Value.ToString();
                        DSCRM.Tables[0].Columns[2].DefaultValue = DemCRMPrec;
                    }
                }
            }
            catch
            {
            }

        }

        private void DGVCRM_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string decimalSeparator = Thread.CurrentThread.CurrentUICulture.NumberFormat.NumberDecimalSeparator;

            if (((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name.Equals("NbrJours"))
            {
                string Valeur = (string)(sender as DataGridView)[e.ColumnIndex, e.RowIndex].EditedFormattedValue.ToString();
                DGVCRM.CurrentCell.Value = Valeur.Replace(".", decimalSeparator).Replace(",", decimalSeparator);
                DGVCRM.RefreshEdit();
            }
        }

        private void ListeVP_SelectedIndexChanged(object sender, EventArgs e)
        {
            String _NomVP = "";
            //
            String _DosVP = "";
            // String _CPVP = "";
            // String _VilleVP = "";

            if (ListeVP.Text != "")
            {
                int CodeCliVP = 0;
                if (ListeVP.SelectedItem != null)
                {
                    ComboItemVP item = ListeVP.SelectedItem as ComboItemVP;
                    CodeCliVP = item.Key;
                }
                else
                {
                    ComboItemVP item = ListeVP.Items[ListeVP.SelectedIndex + 1] as ComboItemVP;
                    CodeCliVP = item.Key;
                }

                /*string chaineSQL8 = "SELECT ID,UID,Rub13, Rub14, Rub15, Rub16, Rub17, Rub18 FROM Eventresource6 WHERE ID =" + CodeCliVP;
                oleCommandVP.CommandText = chaineSQL8;
                OleDbDataReader ReaderVP2 = oleCommandVP.ExecuteReader();

                if (ReaderVP2.Read())
                {
                    if (!ReaderVP2.IsDBNull(2))
                        _NomVP = Convert.ToString(ReaderVP2["Rub13"]).Replace("'", "''");
                    if (!ReaderVP2.IsDBNull(5))
                        _CPVP = Convert.ToString(ReaderVP2["Rub16"]).Replace("'", "''");
                    if (!ReaderVP2.IsDBNull(6))
                        _VilleVP = Convert.ToString(ReaderVP2["Rub17"]).Replace("'", "''");
                }
                ReaderVP2.Close();*/
            }
            /*NomVP.Text = _NomVP;
            CPVP.Text = _CPVP;
            VilleVP.Text = _VilleVP;*/
        }

        private void boutAjoutClientVP_Click(object sender, EventArgs e)
        {
            ListeVP.SelectedText = "";
            ListeVP.SelectedIndex = -1;
            ListeVP.Text = "";
            NomVP.Text = "";
            CPVP.Text = "";
            VilleVP.Text = "";

            UFAjoutClientVP AjoutClientVP = new UFAjoutClientVP();
            AjoutClientVP.lblNomVP = NomClient.Text;
            AjoutClientVP.lblCP = CodePostal.Text;
            AjoutClientVP.lblVille = Ville.Text;
            AjoutClientVP.lblTel = "";
            AjoutClientVP.lblAdresse1 = Adresse1.Text;
            AjoutClientVP.lblAdresse2 = Adresse2.Text;
            AjoutClientVP.ShowDialog();

            NomVP.Text = AjoutClientVP.NomVP;
            CPVP.Text = AjoutClientVP.CPVP;
            VilleVP.Text = AjoutClientVP.VilleVP;
        }

       

    }
}
