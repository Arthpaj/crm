namespace EnvoiCommandeCRM
{
    partial class UFSaisie
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UFSaisie));
            this.oleConnect = new System.Data.OleDb.OleDbConnection();
            this.oleCommandPa = new System.Data.OleDb.OleDbCommand();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.LStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.Barre = new System.Windows.Forms.ToolStripProgressBar();
            this.LNbr = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Quitter = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LabRecherche = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ListeCommande = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BoutValide = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BoutEnvoiCRM = new System.Windows.Forms.ToolStripButton();
            this.BoutSage = new System.Windows.Forms.ToolStripButton();
            this.BoutDesenvoyer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.BoutRAZ = new System.Windows.Forms.ToolStripButton();
            this.BoutSuppression = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.BoutSociete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.oleConnectCRM = new System.Data.OleDb.OleDbConnection();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SCommande = new System.Windows.Forms.TextBox();
            this.SClientSage = new System.Windows.Forms.TextBox();
            this.SDate = new System.Windows.Forms.DateTimePicker();
            this.SClientCRM = new System.Windows.Forms.ComboBox();
            this.SInterlocuteur = new System.Windows.Forms.ComboBox();
            this.SLogiciel = new System.Windows.Forms.ComboBox();
            this.SMateriel = new System.Windows.Forms.ComboBox();
            this.STypeRDV = new System.Windows.Forms.ComboBox();
            this.SDomaine = new System.Windows.Forms.ComboBox();
            this.SEnvoi = new System.Windows.Forms.CheckBox();
            this.oleCommandLib = new System.Data.OleDb.OleDbCommand();
            this.oleCommandCRM = new System.Data.OleDb.OleDbCommand();
            this.Adresse1 = new System.Windows.Forms.TextBox();
            this.Adresse2 = new System.Windows.Forms.TextBox();
            this.Adresse3 = new System.Windows.Forms.TextBox();
            this.CodePostal = new System.Windows.Forms.TextBox();
            this.Ville = new System.Windows.Forms.TextBox();
            this.oleComInsert = new System.Data.OleDb.OleDbCommand();
            this.oleConnectSage = new System.Data.OleDb.OleDbConnection();
            this.SocieteSage = new System.Windows.Forms.TextBox();
            this.DGVSage = new System.Windows.Forms.DataGridView();
            this.DSSage = new System.Data.DataSet();
            this.oleDAC = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            this.BSource = new System.Windows.Forms.BindingSource(this.components);
            this.DGVCRM = new System.Windows.Forms.DataGridView();
            this.oleDACCRM = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbCommand4 = new System.Data.OleDb.OleDbCommand();
            this.DSCRM = new System.Data.DataSet();
            this.BSourceCRM = new System.Windows.Forms.BindingSource(this.components);
            this.oleCommandSage = new System.Data.OleDb.OleDbCommand();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SReferenceSage = new System.Windows.Forms.TextBox();
            this.SCommentaireSage = new System.Windows.Forms.TextBox();
            this.SInterlocuteurSage = new System.Windows.Forms.TextBox();
            this.oleCommandCRMCli = new System.Data.OleDb.OleDbCommand();
            this.oleComInsertCRM = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbCommand6 = new System.Data.OleDb.OleDbCommand();
            this.oleDbCommand7 = new System.Data.OleDb.OleDbCommand();
            this.oleDbCommand8 = new System.Data.OleDb.OleDbCommand();
            this.labelEnvoi = new System.Windows.Forms.Label();
            this.NomClient = new System.Windows.Forms.TextBox();
            this.CPVP = new System.Windows.Forms.TextBox();
            this.VilleVP = new System.Windows.Forms.TextBox();
            this.NomVP = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ListeVP = new System.Windows.Forms.ComboBox();
            this.oleConnectVP = new System.Data.OleDb.OleDbConnection();
            this.oleCommandVP = new System.Data.OleDb.OleDbCommand();
            this.boutAjoutClientVP = new System.Windows.Forms.Button();
            this.boutAjoutMateriel = new System.Windows.Forms.Button();
            this.boutAjoutLogiciel = new System.Windows.Forms.Button();
            this.boutAjoutContact = new System.Windows.Forms.Button();
            this.Status.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSSage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCRM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSCRM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSourceCRM)).BeginInit();
            this.SuspendLayout();
            // 
            // oleConnect
            // 
            this.oleConnect.ConnectionString = "Provider=SQLNCLI10;Data Source=SRV-TSE;Integrated Security=SSPI;Initial Catalog=T" +
    "RANSFERT_VP;Packet Size=4096;MARS Connection=True";
            // 
            // oleCommandPa
            // 
            this.oleCommandPa.Connection = this.oleConnect;
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.SystemColors.Control;
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LStatus,
            this.Barre,
            this.LNbr});
            this.Status.Location = new System.Drawing.Point(0, 632);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(977, 65);
            this.Status.TabIndex = 4;
            this.Status.Text = "statusStrip1";
            // 
            // LStatus
            // 
            this.LStatus.AutoSize = false;
            this.LStatus.BackColor = System.Drawing.SystemColors.Control;
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(800, 60);
            this.LStatus.Text = "                          ";
            // 
            // Barre
            // 
            this.Barre.AutoSize = false;
            this.Barre.Name = "Barre";
            this.Barre.Size = new System.Drawing.Size(150, 59);
            this.Barre.Visible = false;
            // 
            // LNbr
            // 
            this.LNbr.Name = "LNbr";
            this.LNbr.Size = new System.Drawing.Size(19, 60);
            this.LNbr.Text = "    ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Quitter,
            this.toolStripSeparator1,
            this.LabRecherche,
            this.toolStripSeparator3,
            this.ListeCommande,
            this.toolStripSeparator2,
            this.BoutValide,
            this.toolStripSeparator4,
            this.BoutEnvoiCRM,
            this.BoutSage,
            this.BoutDesenvoyer,
            this.toolStripSeparator5,
            this.BoutRAZ,
            this.BoutSuppression,
            this.toolStripSeparator6,
            this.BoutSociete,
            this.toolStripSeparator7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(977, 39);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Quitter
            // 
            this.Quitter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Quitter.Image = global::EnvoiCommandeCRM.Properties.Resources.quitter2;
            this.Quitter.ImageTransparentColor = System.Drawing.Color.White;
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(36, 36);
            this.Quitter.Text = "Quitter";
            this.Quitter.ToolTipText = "Quitter";
            this.Quitter.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // LabRecherche
            // 
            this.LabRecherche.Name = "LabRecherche";
            this.LabRecherche.Size = new System.Drawing.Size(128, 36);
            this.LabRecherche.Text = "Recherche Commande";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // ListeCommande
            // 
            this.ListeCommande.AutoSize = false;
            this.ListeCommande.DropDownWidth = 200;
            this.ListeCommande.Name = "ListeCommande";
            this.ListeCommande.Size = new System.Drawing.Size(200, 23);
            this.ListeCommande.SelectedIndexChanged += new System.EventHandler(this.ListeCommande_SelectedIndexChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // BoutValide
            // 
            this.BoutValide.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoutValide.Image = global::EnvoiCommandeCRM.Properties.Resources.valide;
            this.BoutValide.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoutValide.Name = "BoutValide";
            this.BoutValide.Size = new System.Drawing.Size(36, 36);
            this.BoutValide.Text = "Validation Commande";
            this.BoutValide.Visible = false;
            this.BoutValide.Click += new System.EventHandler(this.BoutValide_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            this.toolStripSeparator4.Visible = false;
            // 
            // BoutEnvoiCRM
            // 
            this.BoutEnvoiCRM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoutEnvoiCRM.Image = global::EnvoiCommandeCRM.Properties.Resources.add_32;
            this.BoutEnvoiCRM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoutEnvoiCRM.Name = "BoutEnvoiCRM";
            this.BoutEnvoiCRM.Size = new System.Drawing.Size(36, 36);
            this.BoutEnvoiCRM.Text = "Envoi Intranet et Visual Planning";
            this.BoutEnvoiCRM.Click += new System.EventHandler(this.BoutEnvoiCRM_Click);
            // 
            // BoutSage
            // 
            this.BoutSage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoutSage.Image = global::EnvoiCommandeCRM.Properties.Resources.Sage;
            this.BoutSage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoutSage.Name = "BoutSage";
            this.BoutSage.Size = new System.Drawing.Size(36, 36);
            this.BoutSage.Text = "Retour vers Sage";
            this.BoutSage.Visible = false;
            this.BoutSage.Click += new System.EventHandler(this.BoutSage_Click);
            // 
            // BoutDesenvoyer
            // 
            this.BoutDesenvoyer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoutDesenvoyer.Image = global::EnvoiCommandeCRM.Properties.Resources.undo_32;
            this.BoutDesenvoyer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoutDesenvoyer.Name = "BoutDesenvoyer";
            this.BoutDesenvoyer.Size = new System.Drawing.Size(36, 36);
            this.BoutDesenvoyer.Text = "Annuler l\'envoi pour recommencer";
            this.BoutDesenvoyer.Visible = false;
            this.BoutDesenvoyer.Click += new System.EventHandler(this.BoutDesenvoyer_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // BoutRAZ
            // 
            this.BoutRAZ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoutRAZ.Image = global::EnvoiCommandeCRM.Properties.Resources.new_document_32;
            this.BoutRAZ.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoutRAZ.Name = "BoutRAZ";
            this.BoutRAZ.Size = new System.Drawing.Size(36, 36);
            this.BoutRAZ.Text = "RAZ";
            this.BoutRAZ.Visible = false;
            this.BoutRAZ.Click += new System.EventHandler(this.BoutRAZ_Click);
            // 
            // BoutSuppression
            // 
            this.BoutSuppression.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoutSuppression.Image = global::EnvoiCommandeCRM.Properties.Resources.trash_321;
            this.BoutSuppression.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoutSuppression.Name = "BoutSuppression";
            this.BoutSuppression.Size = new System.Drawing.Size(36, 36);
            this.BoutSuppression.Text = "Suppression de la commande";
            this.BoutSuppression.Click += new System.EventHandler(this.BoutSuppression_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            this.toolStripSeparator6.Visible = false;
            // 
            // BoutSociete
            // 
            this.BoutSociete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoutSociete.Image = global::EnvoiCommandeCRM.Properties.Resources.Param;
            this.BoutSociete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoutSociete.Name = "BoutSociete";
            this.BoutSociete.Size = new System.Drawing.Size(36, 36);
            this.BoutSociete.Text = "Paramètres Sociétés";
            this.BoutSociete.Click += new System.EventHandler(this.BoutSociete_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 39);
            // 
            // oleConnectCRM
            // 
            this.oleConnectCRM.ConnectionString = "Provider=SQLNCLI10;Data Source=SRV-TSE;Integrated Security=SSPI;Initial Catalog=g" +
    "roupeadinfo_MSCRM;Packet Size=4096;MARS Connection=True";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Commande";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Code Client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Client CRM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(506, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Interlocuteur CRM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(506, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Logiciel CRM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(506, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Matériel CRM";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(149, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Domaine";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(651, 390);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Type RDV V.P.";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 390);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Type Demande = Install";
            // 
            // SCommande
            // 
            this.SCommande.BackColor = System.Drawing.SystemColors.Info;
            this.SCommande.Enabled = false;
            this.SCommande.Location = new System.Drawing.Point(120, 61);
            this.SCommande.Name = "SCommande";
            this.SCommande.Size = new System.Drawing.Size(121, 20);
            this.SCommande.TabIndex = 27;
            // 
            // SClientSage
            // 
            this.SClientSage.BackColor = System.Drawing.SystemColors.Info;
            this.SClientSage.Enabled = false;
            this.SClientSage.Location = new System.Drawing.Point(609, 61);
            this.SClientSage.Name = "SClientSage";
            this.SClientSage.Size = new System.Drawing.Size(121, 20);
            this.SClientSage.TabIndex = 29;
            this.SClientSage.TextChanged += new System.EventHandler(this.SClientSage_TextChanged);
            // 
            // SDate
            // 
            this.SDate.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.SDate.Enabled = false;
            this.SDate.Location = new System.Drawing.Point(309, 61);
            this.SDate.Name = "SDate";
            this.SDate.Size = new System.Drawing.Size(177, 20);
            this.SDate.TabIndex = 28;
            // 
            // SClientCRM
            // 
            this.SClientCRM.BackColor = System.Drawing.SystemColors.Window;
            this.SClientCRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SClientCRM.FormattingEnabled = true;
            this.SClientCRM.Location = new System.Drawing.Point(120, 127);
            this.SClientCRM.Name = "SClientCRM";
            this.SClientCRM.Size = new System.Drawing.Size(816, 21);
            this.SClientCRM.TabIndex = 30;
            this.SClientCRM.SelectedIndexChanged += new System.EventHandler(this.SClientCRM_SelectedIndexChanged);
            // 
            // SInterlocuteur
            // 
            this.SInterlocuteur.FormattingEnabled = true;
            this.SInterlocuteur.Location = new System.Drawing.Point(609, 154);
            this.SInterlocuteur.Name = "SInterlocuteur";
            this.SInterlocuteur.Size = new System.Drawing.Size(327, 21);
            this.SInterlocuteur.TabIndex = 32;
            // 
            // SLogiciel
            // 
            this.SLogiciel.FormattingEnabled = true;
            this.SLogiciel.Location = new System.Drawing.Point(609, 180);
            this.SLogiciel.Name = "SLogiciel";
            this.SLogiciel.Size = new System.Drawing.Size(327, 21);
            this.SLogiciel.TabIndex = 33;
            // 
            // SMateriel
            // 
            this.SMateriel.FormattingEnabled = true;
            this.SMateriel.Location = new System.Drawing.Point(609, 206);
            this.SMateriel.Name = "SMateriel";
            this.SMateriel.Size = new System.Drawing.Size(327, 21);
            this.SMateriel.TabIndex = 34;
            // 
            // STypeRDV
            // 
            this.STypeRDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.STypeRDV.FormattingEnabled = true;
            this.STypeRDV.Location = new System.Drawing.Point(737, 387);
            this.STypeRDV.Name = "STypeRDV";
            this.STypeRDV.Size = new System.Drawing.Size(172, 21);
            this.STypeRDV.TabIndex = 35;
            this.STypeRDV.Visible = false;
            // 
            // SDomaine
            // 
            this.SDomaine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SDomaine.FormattingEnabled = true;
            this.SDomaine.Location = new System.Drawing.Point(204, 387);
            this.SDomaine.Name = "SDomaine";
            this.SDomaine.Size = new System.Drawing.Size(153, 21);
            this.SDomaine.TabIndex = 31;
            // 
            // SEnvoi
            // 
            this.SEnvoi.AutoSize = true;
            this.SEnvoi.Enabled = false;
            this.SEnvoi.Location = new System.Drawing.Point(736, 61);
            this.SEnvoi.Name = "SEnvoi";
            this.SEnvoi.Size = new System.Drawing.Size(87, 17);
            this.SEnvoi.TabIndex = 36;
            this.SEnvoi.Text = "Déjà Envoyé";
            this.SEnvoi.UseVisualStyleBackColor = true;
            // 
            // oleCommandLib
            // 
            this.oleCommandLib.Connection = this.oleConnect;
            // 
            // oleCommandCRM
            // 
            this.oleCommandCRM.Connection = this.oleConnectCRM;
            // 
            // Adresse1
            // 
            this.Adresse1.BackColor = System.Drawing.SystemColors.Info;
            this.Adresse1.Enabled = false;
            this.Adresse1.Location = new System.Drawing.Point(120, 153);
            this.Adresse1.Name = "Adresse1";
            this.Adresse1.Size = new System.Drawing.Size(366, 20);
            this.Adresse1.TabIndex = 37;
            // 
            // Adresse2
            // 
            this.Adresse2.BackColor = System.Drawing.SystemColors.Info;
            this.Adresse2.Enabled = false;
            this.Adresse2.Location = new System.Drawing.Point(120, 170);
            this.Adresse2.Name = "Adresse2";
            this.Adresse2.Size = new System.Drawing.Size(366, 20);
            this.Adresse2.TabIndex = 38;
            // 
            // Adresse3
            // 
            this.Adresse3.BackColor = System.Drawing.SystemColors.Info;
            this.Adresse3.Enabled = false;
            this.Adresse3.Location = new System.Drawing.Point(120, 187);
            this.Adresse3.Name = "Adresse3";
            this.Adresse3.Size = new System.Drawing.Size(366, 20);
            this.Adresse3.TabIndex = 39;
            // 
            // CodePostal
            // 
            this.CodePostal.BackColor = System.Drawing.SystemColors.Info;
            this.CodePostal.Enabled = false;
            this.CodePostal.Location = new System.Drawing.Point(120, 208);
            this.CodePostal.Name = "CodePostal";
            this.CodePostal.Size = new System.Drawing.Size(100, 20);
            this.CodePostal.TabIndex = 40;
            // 
            // Ville
            // 
            this.Ville.BackColor = System.Drawing.SystemColors.Info;
            this.Ville.Enabled = false;
            this.Ville.Location = new System.Drawing.Point(226, 208);
            this.Ville.Name = "Ville";
            this.Ville.Size = new System.Drawing.Size(260, 20);
            this.Ville.TabIndex = 41;
            // 
            // oleComInsert
            // 
            this.oleComInsert.Connection = this.oleConnect;
            // 
            // oleConnectSage
            // 
            this.oleConnectSage.ConnectionString = "Provider=SQLNCLI11;Data Source=SRV1-SQL2008;Integrated Security=SSPI;Initial Cata" +
    "log=BIJOU";
            // 
            // SocieteSage
            // 
            this.SocieteSage.BackColor = System.Drawing.SystemColors.Info;
            this.SocieteSage.Enabled = false;
            this.SocieteSage.Location = new System.Drawing.Point(832, 59);
            this.SocieteSage.Name = "SocieteSage";
            this.SocieteSage.Size = new System.Drawing.Size(100, 20);
            this.SocieteSage.TabIndex = 42;
            // 
            // DGVSage
            // 
            this.DGVSage.AllowUserToAddRows = false;
            this.DGVSage.AllowUserToDeleteRows = false;
            this.DGVSage.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.DGVSage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVSage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVSage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVSage.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVSage.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.DGVSage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVSage.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVSage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVSage.ColumnHeadersHeight = 18;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVSage.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVSage.GridColor = System.Drawing.SystemColors.Info;
            this.DGVSage.Location = new System.Drawing.Point(30, 252);
            this.DGVSage.MultiSelect = false;
            this.DGVSage.Name = "DGVSage";
            this.DGVSage.ReadOnly = true;
            this.DGVSage.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVSage.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVSage.RowHeadersVisible = false;
            this.DGVSage.RowTemplate.Height = 18;
            this.DGVSage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSage.Size = new System.Drawing.Size(878, 129);
            this.DGVSage.TabIndex = 229;
            // 
            // DSSage
            // 
            this.DSSage.DataSetName = "DataSetStd";
            // 
            // oleDAC
            // 
            this.oleDAC.DeleteCommand = this.oleDbDeleteCommand2;
            this.oleDAC.InsertCommand = this.oleDbInsertCommand2;
            this.oleDAC.SelectCommand = this.oleDbSelectCommand4;
            this.oleDAC.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "", new System.Data.Common.DataColumnMapping[0])});
            this.oleDAC.UpdateCommand = this.oleDbUpdateCommand2;
            // 
            // oleDbDeleteCommand2
            // 
            this.oleDbDeleteCommand2.Connection = this.oleConnectSage;
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.Connection = this.oleConnectSage;
            // 
            // oleDbSelectCommand4
            // 
            this.oleDbSelectCommand4.Connection = this.oleConnectSage;
            // 
            // oleDbUpdateCommand2
            // 
            this.oleDbUpdateCommand2.Connection = this.oleConnectSage;
            // 
            // BSource
            // 
            this.BSource.AllowNew = true;
            this.BSource.DataSource = this.DSSage;
            this.BSource.Filter = "";
            this.BSource.Position = 0;
            // 
            // DGVCRM
            // 
            this.DGVCRM.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.DGVCRM.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVCRM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVCRM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVCRM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVCRM.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.DGVCRM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVCRM.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCRM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVCRM.ColumnHeadersHeight = 18;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVCRM.DefaultCellStyle = dataGridViewCellStyle7;
            this.DGVCRM.GridColor = System.Drawing.Color.AliceBlue;
            this.DGVCRM.Location = new System.Drawing.Point(30, 414);
            this.DGVCRM.MultiSelect = false;
            this.DGVCRM.Name = "DGVCRM";
            this.DGVCRM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCRM.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DGVCRM.RowHeadersVisible = false;
            this.DGVCRM.RowTemplate.Height = 18;
            this.DGVCRM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCRM.Size = new System.Drawing.Size(878, 157);
            this.DGVCRM.TabIndex = 230;
            this.DGVCRM.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DGVCRM_CellValidating);
            // 
            // oleDACCRM
            // 
            this.oleDACCRM.DeleteCommand = this.oleDbCommand1;
            this.oleDACCRM.InsertCommand = this.oleDbCommand2;
            this.oleDACCRM.SelectCommand = this.oleDbCommand3;
            this.oleDACCRM.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "", new System.Data.Common.DataColumnMapping[0])});
            this.oleDACCRM.UpdateCommand = this.oleDbCommand4;
            // 
            // oleDbCommand1
            // 
            this.oleDbCommand1.Connection = this.oleConnect;
            // 
            // oleDbCommand2
            // 
            this.oleDbCommand2.Connection = this.oleConnect;
            // 
            // oleDbCommand3
            // 
            this.oleDbCommand3.Connection = this.oleConnect;
            // 
            // oleDbCommand4
            // 
            this.oleDbCommand4.Connection = this.oleConnect;
            // 
            // DSCRM
            // 
            this.DSCRM.DataSetName = "DataSetCRM";
            // 
            // BSourceCRM
            // 
            this.BSourceCRM.AllowNew = true;
            this.BSourceCRM.DataSource = this.DSCRM;
            this.BSourceCRM.Filter = "";
            this.BSourceCRM.Position = 0;
            // 
            // oleCommandSage
            // 
            this.oleCommandSage.Connection = this.oleConnectSage;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 231;
            this.label5.Text = "Référence";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(389, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 232;
            this.label12.Text = "Description";
            // 
            // SReferenceSage
            // 
            this.SReferenceSage.BackColor = System.Drawing.SystemColors.Info;
            this.SReferenceSage.Enabled = false;
            this.SReferenceSage.Location = new System.Drawing.Point(120, 91);
            this.SReferenceSage.Name = "SReferenceSage";
            this.SReferenceSage.Size = new System.Drawing.Size(263, 20);
            this.SReferenceSage.TabIndex = 233;
            // 
            // SCommentaireSage
            // 
            this.SCommentaireSage.BackColor = System.Drawing.SystemColors.Info;
            this.SCommentaireSage.Enabled = false;
            this.SCommentaireSage.Location = new System.Drawing.Point(463, 91);
            this.SCommentaireSage.Name = "SCommentaireSage";
            this.SCommentaireSage.Size = new System.Drawing.Size(238, 20);
            this.SCommentaireSage.TabIndex = 234;
            // 
            // SInterlocuteurSage
            // 
            this.SInterlocuteurSage.BackColor = System.Drawing.SystemColors.Info;
            this.SInterlocuteurSage.Enabled = false;
            this.SInterlocuteurSage.Location = new System.Drawing.Point(710, 91);
            this.SInterlocuteurSage.Name = "SInterlocuteurSage";
            this.SInterlocuteurSage.Size = new System.Drawing.Size(222, 20);
            this.SInterlocuteurSage.TabIndex = 235;
            // 
            // oleCommandCRMCli
            // 
            this.oleCommandCRMCli.Connection = this.oleConnectCRM;
            // 
            // oleComInsertCRM
            // 
            this.oleComInsertCRM.DeleteCommand = this.oleDbCommand5;
            this.oleComInsertCRM.InsertCommand = this.oleDbCommand6;
            this.oleComInsertCRM.SelectCommand = this.oleDbCommand7;
            this.oleComInsertCRM.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "", new System.Data.Common.DataColumnMapping[0])});
            this.oleComInsertCRM.UpdateCommand = this.oleDbCommand8;
            // 
            // oleDbCommand5
            // 
            this.oleDbCommand5.Connection = this.oleConnect;
            // 
            // oleDbCommand6
            // 
            this.oleDbCommand6.Connection = this.oleConnect;
            // 
            // oleDbCommand7
            // 
            this.oleDbCommand7.Connection = this.oleConnectCRM;
            // 
            // oleDbCommand8
            // 
            this.oleDbCommand8.Connection = this.oleConnect;
            // 
            // labelEnvoi
            // 
            this.labelEnvoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEnvoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnvoi.ForeColor = System.Drawing.Color.Red;
            this.labelEnvoi.Location = new System.Drawing.Point(363, 386);
            this.labelEnvoi.Name = "labelEnvoi";
            this.labelEnvoi.Size = new System.Drawing.Size(317, 22);
            this.labelEnvoi.TabIndex = 768;
            this.labelEnvoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NomClient
            // 
            this.NomClient.BackColor = System.Drawing.SystemColors.Info;
            this.NomClient.Enabled = false;
            this.NomClient.Location = new System.Drawing.Point(120, 229);
            this.NomClient.Name = "NomClient";
            this.NomClient.Size = new System.Drawing.Size(366, 20);
            this.NomClient.TabIndex = 769;
            // 
            // CPVP
            // 
            this.CPVP.BackColor = System.Drawing.SystemColors.Info;
            this.CPVP.Enabled = false;
            this.CPVP.Location = new System.Drawing.Point(488, 604);
            this.CPVP.Name = "CPVP";
            this.CPVP.Size = new System.Drawing.Size(72, 20);
            this.CPVP.TabIndex = 780;
            // 
            // VilleVP
            // 
            this.VilleVP.BackColor = System.Drawing.SystemColors.Info;
            this.VilleVP.Enabled = false;
            this.VilleVP.Location = new System.Drawing.Point(566, 604);
            this.VilleVP.Name = "VilleVP";
            this.VilleVP.Size = new System.Drawing.Size(366, 20);
            this.VilleVP.TabIndex = 779;
            // 
            // NomVP
            // 
            this.NomVP.BackColor = System.Drawing.SystemColors.Info;
            this.NomVP.Enabled = false;
            this.NomVP.Location = new System.Drawing.Point(116, 604);
            this.NomVP.Name = "NomVP";
            this.NomVP.Size = new System.Drawing.Size(366, 20);
            this.NomVP.TabIndex = 778;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 577);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 777;
            this.label13.Text = "Client VP";
            // 
            // ListeVP
            // 
            this.ListeVP.FormattingEnabled = true;
            this.ListeVP.Location = new System.Drawing.Point(116, 577);
            this.ListeVP.Name = "ListeVP";
            this.ListeVP.Size = new System.Drawing.Size(816, 21);
            this.ListeVP.TabIndex = 776;
            this.ListeVP.SelectedIndexChanged += new System.EventHandler(this.ListeVP_SelectedIndexChanged);
            // 
            // oleConnectVP
            // 
            this.oleConnectVP.ConnectionString = "Provider=SQLNCLI11;Data Source=SRV3-INTERNE;Password=vpuser;User ID=vpuser;Initia" +
    "l Catalog=\"VP GROUPE ADINFO\";MultipleActiveResultSets=True";
            // 
            // oleCommandVP
            // 
            this.oleCommandVP.Connection = this.oleConnectVP;
            // 
            // boutAjoutClientVP
            // 
            this.boutAjoutClientVP.BackColor = System.Drawing.Color.LightSteelBlue;
            this.boutAjoutClientVP.Image = global::EnvoiCommandeCRM.Properties.Resources.add;
            this.boutAjoutClientVP.Location = new System.Drawing.Point(938, 574);
            this.boutAjoutClientVP.Name = "boutAjoutClientVP";
            this.boutAjoutClientVP.Size = new System.Drawing.Size(33, 24);
            this.boutAjoutClientVP.TabIndex = 781;
            this.boutAjoutClientVP.UseVisualStyleBackColor = false;
            this.boutAjoutClientVP.Click += new System.EventHandler(this.boutAjoutClientVP_Click);
            // 
            // boutAjoutMateriel
            // 
            this.boutAjoutMateriel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.boutAjoutMateriel.Image = global::EnvoiCommandeCRM.Properties.Resources.add;
            this.boutAjoutMateriel.Location = new System.Drawing.Point(942, 203);
            this.boutAjoutMateriel.Name = "boutAjoutMateriel";
            this.boutAjoutMateriel.Size = new System.Drawing.Size(33, 24);
            this.boutAjoutMateriel.TabIndex = 767;
            this.boutAjoutMateriel.UseVisualStyleBackColor = false;
            this.boutAjoutMateriel.Click += new System.EventHandler(this.boutAjoutMateriel_Click);
            // 
            // boutAjoutLogiciel
            // 
            this.boutAjoutLogiciel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.boutAjoutLogiciel.Image = global::EnvoiCommandeCRM.Properties.Resources.add;
            this.boutAjoutLogiciel.Location = new System.Drawing.Point(942, 177);
            this.boutAjoutLogiciel.Name = "boutAjoutLogiciel";
            this.boutAjoutLogiciel.Size = new System.Drawing.Size(33, 24);
            this.boutAjoutLogiciel.TabIndex = 766;
            this.boutAjoutLogiciel.UseVisualStyleBackColor = false;
            this.boutAjoutLogiciel.Click += new System.EventHandler(this.boutAjoutLogiciel_Click);
            // 
            // boutAjoutContact
            // 
            this.boutAjoutContact.BackColor = System.Drawing.Color.LightSteelBlue;
            this.boutAjoutContact.Image = global::EnvoiCommandeCRM.Properties.Resources.add;
            this.boutAjoutContact.Location = new System.Drawing.Point(942, 150);
            this.boutAjoutContact.Name = "boutAjoutContact";
            this.boutAjoutContact.Size = new System.Drawing.Size(33, 24);
            this.boutAjoutContact.TabIndex = 765;
            this.boutAjoutContact.UseVisualStyleBackColor = false;
            this.boutAjoutContact.Click += new System.EventHandler(this.boutAjoutContact_Click);
            // 
            // UFSaisie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(977, 697);
            this.Controls.Add(this.boutAjoutClientVP);
            this.Controls.Add(this.CPVP);
            this.Controls.Add(this.VilleVP);
            this.Controls.Add(this.NomVP);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ListeVP);
            this.Controls.Add(this.NomClient);
            this.Controls.Add(this.labelEnvoi);
            this.Controls.Add(this.boutAjoutMateriel);
            this.Controls.Add(this.boutAjoutLogiciel);
            this.Controls.Add(this.boutAjoutContact);
            this.Controls.Add(this.SInterlocuteurSage);
            this.Controls.Add(this.SCommentaireSage);
            this.Controls.Add(this.SReferenceSage);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DGVCRM);
            this.Controls.Add(this.DGVSage);
            this.Controls.Add(this.SocieteSage);
            this.Controls.Add(this.Ville);
            this.Controls.Add(this.CodePostal);
            this.Controls.Add(this.Adresse3);
            this.Controls.Add(this.Adresse2);
            this.Controls.Add(this.Adresse1);
            this.Controls.Add(this.SEnvoi);
            this.Controls.Add(this.SDomaine);
            this.Controls.Add(this.STypeRDV);
            this.Controls.Add(this.SMateriel);
            this.Controls.Add(this.SLogiciel);
            this.Controls.Add(this.SInterlocuteur);
            this.Controls.Add(this.SClientCRM);
            this.Controls.Add(this.SDate);
            this.Controls.Add(this.SClientSage);
            this.Controls.Add(this.SCommande);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Status);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UFSaisie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envoi de la Commande dans l\'intranet";
            this.Load += new System.EventHandler(this.UFSaisie_Load);
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSSage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCRM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSCRM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSourceCRM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.OleDb.OleDbConnection oleConnect;
        private System.Data.OleDb.OleDbCommand oleCommandPa;
        public System.Windows.Forms.StatusStrip Status;
        public System.Windows.Forms.ToolStripProgressBar Barre;
        public System.Windows.Forms.ToolStripStatusLabel LNbr;
        public System.Windows.Forms.ToolStripStatusLabel LStatus;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Quitter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel LabRecherche;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripComboBox ListeCommande;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BoutValide;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton BoutSage;
        private System.Windows.Forms.ToolStripButton BoutEnvoiCRM;
        private System.Data.OleDb.OleDbConnection oleConnectCRM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox SCommande;
        private System.Windows.Forms.TextBox SClientSage;
        private System.Windows.Forms.DateTimePicker SDate;
        private System.Windows.Forms.ComboBox SClientCRM;
        private System.Windows.Forms.ComboBox SInterlocuteur;
        private System.Windows.Forms.ComboBox SLogiciel;
        private System.Windows.Forms.ComboBox SMateriel;
        private System.Windows.Forms.ComboBox STypeRDV;
        private System.Windows.Forms.ComboBox SDomaine;
        private System.Windows.Forms.CheckBox SEnvoi;
        private System.Data.OleDb.OleDbCommand oleCommandLib;
        private System.Data.OleDb.OleDbCommand oleCommandCRM;
        private System.Windows.Forms.TextBox Adresse1;
        private System.Windows.Forms.TextBox Adresse2;
        private System.Windows.Forms.TextBox Adresse3;
        private System.Windows.Forms.TextBox CodePostal;
        private System.Windows.Forms.TextBox Ville;
        private System.Data.OleDb.OleDbCommand oleComInsert;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton BoutRAZ;
        private System.Windows.Forms.ToolStripButton BoutSuppression;
        private System.Data.OleDb.OleDbConnection oleConnectSage;
        private System.Windows.Forms.TextBox SocieteSage;
        public System.Windows.Forms.DataGridView DGVSage;
        public System.Data.DataSet DSSage;
        private System.Data.OleDb.OleDbDataAdapter oleDAC;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand4;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
        public System.Windows.Forms.BindingSource BSource;
        public System.Windows.Forms.DataGridView DGVCRM;
        private System.Data.OleDb.OleDbDataAdapter oleDACCRM;
        private System.Data.OleDb.OleDbCommand oleDbCommand1;
        private System.Data.OleDb.OleDbCommand oleDbCommand2;
        private System.Data.OleDb.OleDbCommand oleDbCommand3;
        private System.Data.OleDb.OleDbCommand oleDbCommand4;
        public System.Data.DataSet DSCRM;
        public System.Windows.Forms.BindingSource BSourceCRM;
        private System.Data.OleDb.OleDbCommand oleCommandSage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox SReferenceSage;
        private System.Windows.Forms.TextBox SCommentaireSage;
        private System.Windows.Forms.TextBox SInterlocuteurSage;
        private System.Data.OleDb.OleDbCommand oleCommandCRMCli;
        private System.Windows.Forms.Button boutAjoutContact;
        private System.Windows.Forms.Button boutAjoutLogiciel;
        private System.Windows.Forms.Button boutAjoutMateriel;
        private System.Data.OleDb.OleDbDataAdapter oleComInsertCRM;
        private System.Data.OleDb.OleDbCommand oleDbCommand5;
        private System.Data.OleDb.OleDbCommand oleDbCommand6;
        private System.Data.OleDb.OleDbCommand oleDbCommand7;
        private System.Data.OleDb.OleDbCommand oleDbCommand8;
        private System.Windows.Forms.Label labelEnvoi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton BoutSociete;
        private System.Windows.Forms.TextBox NomClient;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton BoutDesenvoyer;
        private System.Windows.Forms.Button boutAjoutClientVP;
        private System.Windows.Forms.TextBox CPVP;
        private System.Windows.Forms.TextBox VilleVP;
        private System.Windows.Forms.TextBox NomVP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ListeVP;
        private System.Data.OleDb.OleDbConnection oleConnectVP;
        private System.Data.OleDb.OleDbCommand oleCommandVP;
    }
}

