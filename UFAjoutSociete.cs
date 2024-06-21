using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnvoiCommandeCRM
{
    public partial class UFAjoutSociete : Form
    {
        DataGridViewComboBoxColumn comboxColonne_Domaine;
        DataGridViewComboBoxColumn comboxColonne_RDV;
        DataGridViewTextBoxColumn comboxColonne_Societe;

        public UFAjoutSociete()
        {
            InitializeComponent();
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
                /*{ new Choix_Domaine("Gestion - Bureautique", 1) },
                { new Choix_Domaine("Matériel - Réseau", 2) },
                { new Choix_Domaine("Internet", 3) },
                { new Choix_Domaine("ERP", 4) },
                { new Choix_Domaine("Développement", 5) }*/
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
                { new Choix_RDV("") },
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

        public class Choix_Societe
        {
            public string NameSociete { get; private set; }

            public Choix_Societe(string name)
            {
                NameSociete = name;
            }

            private static readonly List<Choix_Societe> possibleChoixSociete = new List<Choix_Societe>
            {
                { new Choix_Societe("Différence Informatique") },
                { new Choix_Societe("Bertrand Informatique") }
            };

            public static List<Choix_Societe> GetChoixSociete()
            {
                return possibleChoixSociete;
            }
        }

        private void UFAjoutSociete_Load(object sender, EventArgs e)
        {
            if (oleConnect.State != ConnectionState.Open)
            {
                oleConnect.ConnectionString = Properties.Settings.Default.VpTranferConnectionString;
                oleConnect.Open();
            }

            oleDAC.Fill(DSSoc);
            oleDAC.TableMappings.Clear();
            oleDAC.TableMappings.Add(DSSoc.Tables[0].TableName, DSSoc.Tables[0].TableName);
            BSourceSoc.DataMember = DSSoc.Tables[0].TableName;
            DGVSociete.DataSource = BSourceSoc;
            DGVSociete.AllowUserToAddRows = true;
            DGVSociete.AllowUserToResizeColumns = true;

            comboxColonne_Societe = new DataGridViewTextBoxColumn();
            //comboxColonne_Societe.DataSource = Choix_Societe.GetChoixSociete();
            comboxColonne_Societe.HeaderText = "Nom Société                          ";
            //comboxColonne_Societe.DisplayMember = "NameSociete";
            //comboxColonne_Societe.ValueMember = "NameSociete";
            comboxColonne_Societe.DataPropertyName = "SONom";
            comboxColonne_Societe.Name = "SONom";
           
            comboxColonne_Domaine = new DataGridViewComboBoxColumn();
            comboxColonne_Domaine.DataSource = Choix_Domaine.GetChoixDomaine();
            comboxColonne_Domaine.HeaderText = "Domaine                                    ";
            comboxColonne_Domaine.DisplayMember = "NameDom";
            comboxColonne_Domaine.ValueMember = "ValueDom";
            comboxColonne_Domaine.DataPropertyName = "SODomaine";
            comboxColonne_Domaine.Name = "SODomaine";

            comboxColonne_RDV = new DataGridViewComboBoxColumn();
            comboxColonne_RDV.DataSource = Choix_RDV.GetChoixRDV();
            comboxColonne_RDV.HeaderText = "Type_RDV_VP                        ";
            comboxColonne_RDV.DisplayMember = "NameRDV";
            comboxColonne_RDV.ValueMember = "NameRDV";
            comboxColonne_RDV.DataPropertyName = "SOTypeRDV";
            comboxColonne_RDV.Name = "SOTypeRDV";

            DGVSociete.Columns.Clear();
            // Remplissage Liste Société
            //DGVSociete.Columns.Remove("SONom");
            DGVSociete.Columns.Add(comboxColonne_Societe);
            //DGVSociete.Columns.Insert(0, comboxColonne_Societe);
            DGVSociete.Columns[0].Name = "SONom";

            // Remplissage Liste Domaine
            //DGVSociete.Columns.Remove("SODomaine");
            DGVSociete.Columns.Add(comboxColonne_Domaine);
            //DGVSociete.Columns.Insert(1, comboxColonne_Domaine);
            DGVSociete.Columns[1].Name = "SODomaine";

            // Remplissage Liste TypeRDV
            //DGVSociete.Columns.Remove("SOTypeRDV");
            DGVSociete.Columns.Add(comboxColonne_RDV);
            //DGVSociete.Columns.Insert(2, comboxColonne_RDV);
            DGVSociete.Columns[2].Name = "SOTypeRDV";

            DGVSociete.Columns[0].Width = 250;
            DGVSociete.Columns[1].Width = 250;
            DGVSociete.Columns[2].Width = 250;
            //DGVSociete.Columns[0].HeaderText = "Nom Société                     ";
        }

        private void BoutValid_Click(object sender, EventArgs e)
        {
            Validation();
        }

        private void Validation()
        {
            DGVSociete.EndEdit();
            BSourceSoc.EndEdit();
            if (DSSoc.Tables[0].GetChanges() != null)
            {
                try
                {
                    oleDAC.Update(DSSoc.Tables[0]);
                    DSSoc.AcceptChanges();
                }
                catch (Exception ex)
                {
                    LStatus.Text = Commun.GestErreur.Ajoute(this.Name, ex);
                }
            }
        }

        private void BoutExit_Click(object sender, EventArgs e)
        {
            Validation();
            oleConnect.Close();
            Close();
        }

    }
}
