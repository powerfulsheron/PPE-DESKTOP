namespace Maquette_Belle_Table_Final
{
    partial class InterUti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutEntete = new System.Windows.Forms.TableLayoutPanel();
            this.panelTitre = new System.Windows.Forms.Panel();
            this.labelFermeture = new System.Windows.Forms.Label();
            this.labelBT = new System.Windows.Forms.Label();
            this.pictureBoxBT = new System.Windows.Forms.PictureBox();
            this.panelBorderRight = new System.Windows.Forms.Panel();
            this.panelBorderBottom = new System.Windows.Forms.Panel();
            this.panelBordeLeft = new System.Windows.Forms.Panel();
            this.tabPagePlan = new System.Windows.Forms.TabPage();
            this.panelPlanning = new System.Windows.Forms.Panel();
            this.groupBoxPJS = new System.Windows.Forms.GroupBox();
            this.listViewPlan = new System.Windows.Forms.ListView();
            this.buttonNRDV = new System.Windows.Forms.Button();
            this.monthCalendarPlan = new System.Windows.Forms.MonthCalendar();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPagePlanC = new System.Windows.Forms.TabPage();
            this.panelPlanningC = new System.Windows.Forms.Panel();
            this.groupBoxPJSPC = new System.Windows.Forms.GroupBox();
            this.listViewPJSPC = new System.Windows.Forms.ListView();
            this.buttonNPC = new System.Windows.Forms.Button();
            this.monthCalendarPlanC = new System.Windows.Forms.MonthCalendar();
            this.tabPagePF = new System.Windows.Forms.TabPage();
            this.panelPortefeuille = new System.Windows.Forms.Panel();
            this.dataGridViewPortefeuille = new System.Windows.Forms.DataGridView();
            this.buttonEnvoiMail = new System.Windows.Forms.Button();
            this.buttonModCli = new System.Windows.Forms.Button();
            this.buttonAddCli = new System.Windows.Forms.Button();
            this.tabPageMails = new System.Windows.Forms.TabPage();
            this.panelMail = new System.Windows.Forms.Panel();
            this.buttonOuvrirEmail = new System.Windows.Forms.Button();
            this.buttonEnvoiEmail = new System.Windows.Forms.Button();
            this.dataGridViewMail = new System.Windows.Forms.DataGridView();
            this.tabPageCDMDP = new System.Windows.Forms.TabPage();
            this.panelChangerMDP = new System.Windows.Forms.Panel();
            this.buttonValCDMDP = new System.Windows.Forms.Button();
            this.textBoxNoMDP = new System.Windows.Forms.TextBox();
            this.labelNoMDP = new System.Windows.Forms.Label();
            this.labelLogC = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.tableLayoutEntete.SuspendLayout();
            this.panelTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBT)).BeginInit();
            this.tabPagePlan.SuspendLayout();
            this.panelPlanning.SuspendLayout();
            this.groupBoxPJS.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPagePlanC.SuspendLayout();
            this.panelPlanningC.SuspendLayout();
            this.groupBoxPJSPC.SuspendLayout();
            this.tabPagePF.SuspendLayout();
            this.panelPortefeuille.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPortefeuille)).BeginInit();
            this.tabPageMails.SuspendLayout();
            this.panelMail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMail)).BeginInit();
            this.tabPageCDMDP.SuspendLayout();
            this.panelChangerMDP.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutEntete
            // 
            this.tableLayoutEntete.ColumnCount = 1;
            this.tableLayoutEntete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutEntete.Controls.Add(this.panelTitre, 0, 0);
            this.tableLayoutEntete.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutEntete.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutEntete.Name = "tableLayoutEntete";
            this.tableLayoutEntete.RowCount = 1;
            this.tableLayoutEntete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.78161F));
            this.tableLayoutEntete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutEntete.Size = new System.Drawing.Size(1000, 37);
            this.tableLayoutEntete.TabIndex = 3;
            // 
            // panelTitre
            // 
            this.panelTitre.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelTitre.Controls.Add(this.labelFermeture);
            this.panelTitre.Controls.Add(this.labelBT);
            this.panelTitre.Controls.Add(this.pictureBoxBT);
            this.panelTitre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitre.Location = new System.Drawing.Point(3, 3);
            this.panelTitre.Name = "panelTitre";
            this.panelTitre.Size = new System.Drawing.Size(994, 31);
            this.panelTitre.TabIndex = 2;
            // 
            // labelFermeture
            // 
            this.labelFermeture.AutoSize = true;
            this.labelFermeture.BackColor = System.Drawing.Color.Transparent;
            this.labelFermeture.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFermeture.ForeColor = System.Drawing.Color.Gold;
            this.labelFermeture.Location = new System.Drawing.Point(975, 6);
            this.labelFermeture.Name = "labelFermeture";
            this.labelFermeture.Size = new System.Drawing.Size(22, 21);
            this.labelFermeture.TabIndex = 17;
            this.labelFermeture.Text = "X";
            this.labelFermeture.Click += new System.EventHandler(this.labelFermeture_Click);
            // 
            // labelBT
            // 
            this.labelBT.AutoSize = true;
            this.labelBT.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBT.ForeColor = System.Drawing.Color.Gold;
            this.labelBT.Location = new System.Drawing.Point(36, 0);
            this.labelBT.Name = "labelBT";
            this.labelBT.Size = new System.Drawing.Size(65, 22);
            this.labelBT.TabIndex = 1;
            this.labelBT.Text = "GEPEV";
            this.labelBT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxBT
            // 
            this.pictureBoxBT.Image = global::Maquette_Belle_Table_Final.Properties.Resources.table;
            this.pictureBoxBT.Location = new System.Drawing.Point(0, -3);
            this.pictureBoxBT.Name = "pictureBoxBT";
            this.pictureBoxBT.Size = new System.Drawing.Size(29, 26);
            this.pictureBoxBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBT.TabIndex = 0;
            this.pictureBoxBT.TabStop = false;
            // 
            // panelBorderRight
            // 
            this.panelBorderRight.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelBorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBorderRight.Location = new System.Drawing.Point(999, 37);
            this.panelBorderRight.Name = "panelBorderRight";
            this.panelBorderRight.Size = new System.Drawing.Size(1, 500);
            this.panelBorderRight.TabIndex = 13;
            // 
            // panelBorderBottom
            // 
            this.panelBorderBottom.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelBorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBorderBottom.Location = new System.Drawing.Point(0, 536);
            this.panelBorderBottom.Name = "panelBorderBottom";
            this.panelBorderBottom.Size = new System.Drawing.Size(999, 1);
            this.panelBorderBottom.TabIndex = 14;
            // 
            // panelBordeLeft
            // 
            this.panelBordeLeft.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelBordeLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBordeLeft.Location = new System.Drawing.Point(0, 37);
            this.panelBordeLeft.Name = "panelBordeLeft";
            this.panelBordeLeft.Size = new System.Drawing.Size(1, 499);
            this.panelBordeLeft.TabIndex = 15;
            // 
            // tabPagePlan
            // 
            this.tabPagePlan.Controls.Add(this.panelPlanning);
            this.tabPagePlan.Location = new System.Drawing.Point(4, 33);
            this.tabPagePlan.Name = "tabPagePlan";
            this.tabPagePlan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlan.Size = new System.Drawing.Size(990, 462);
            this.tabPagePlan.TabIndex = 0;
            this.tabPagePlan.Text = "Planning";
            this.tabPagePlan.UseVisualStyleBackColor = true;
            // 
            // panelPlanning
            // 
            this.panelPlanning.BackgroundImage = global::Maquette_Belle_Table_Final.Properties.Resources.fond;
            this.panelPlanning.Controls.Add(this.groupBoxPJS);
            this.panelPlanning.Controls.Add(this.buttonNRDV);
            this.panelPlanning.Controls.Add(this.monthCalendarPlan);
            this.panelPlanning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlanning.Location = new System.Drawing.Point(3, 3);
            this.panelPlanning.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelPlanning.Name = "panelPlanning";
            this.panelPlanning.Size = new System.Drawing.Size(984, 456);
            this.panelPlanning.TabIndex = 13;
            // 
            // groupBoxPJS
            // 
            this.groupBoxPJS.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPJS.Controls.Add(this.listViewPlan);
            this.groupBoxPJS.Location = new System.Drawing.Point(641, 97);
            this.groupBoxPJS.Name = "groupBoxPJS";
            this.groupBoxPJS.Size = new System.Drawing.Size(290, 347);
            this.groupBoxPJS.TabIndex = 2;
            this.groupBoxPJS.TabStop = false;
            this.groupBoxPJS.Text = "Planning du Jour sélectionné";
            // 
            // listViewPlan
            // 
            this.listViewPlan.Location = new System.Drawing.Point(30, 42);
            this.listViewPlan.Name = "listViewPlan";
            this.listViewPlan.Size = new System.Drawing.Size(230, 289);
            this.listViewPlan.TabIndex = 0;
            this.listViewPlan.UseCompatibleStateImageBehavior = false;
            // 
            // buttonNRDV
            // 
            this.buttonNRDV.BackColor = System.Drawing.Color.Gold;
            this.buttonNRDV.Location = new System.Drawing.Point(671, 34);
            this.buttonNRDV.Name = "buttonNRDV";
            this.buttonNRDV.Size = new System.Drawing.Size(230, 34);
            this.buttonNRDV.TabIndex = 1;
            this.buttonNRDV.Text = "Nouveau Rendez-vous";
            this.buttonNRDV.UseVisualStyleBackColor = false;
            this.buttonNRDV.Click += new System.EventHandler(this.buttonNRDV_Click);
            // 
            // monthCalendarPlan
            // 
            this.monthCalendarPlan.Location = new System.Drawing.Point(62, 97);
            this.monthCalendarPlan.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.monthCalendarPlan.MaximumSize = new System.Drawing.Size(943, 552);
            this.monthCalendarPlan.MinimumSize = new System.Drawing.Size(313, 252);
            this.monthCalendarPlan.Name = "monthCalendarPlan";
            this.monthCalendarPlan.ShowToday = false;
            this.monthCalendarPlan.ShowTodayCircle = false;
            this.monthCalendarPlan.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl2.Controls.Add(this.tabPagePlan);
            this.tabControl2.Controls.Add(this.tabPagePlanC);
            this.tabControl2.Controls.Add(this.tabPagePF);
            this.tabControl2.Controls.Add(this.tabPageMails);
            this.tabControl2.Controls.Add(this.tabPageCDMDP);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.tabControl2.Location = new System.Drawing.Point(1, 37);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(998, 499);
            this.tabControl2.TabIndex = 17;
            // 
            // tabPagePlanC
            // 
            this.tabPagePlanC.Controls.Add(this.panelPlanningC);
            this.tabPagePlanC.Location = new System.Drawing.Point(4, 33);
            this.tabPagePlanC.Name = "tabPagePlanC";
            this.tabPagePlanC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlanC.Size = new System.Drawing.Size(990, 462);
            this.tabPagePlanC.TabIndex = 1;
            this.tabPagePlanC.Text = "Plannification Congés";
            this.tabPagePlanC.UseVisualStyleBackColor = true;
            // 
            // panelPlanningC
            // 
            this.panelPlanningC.BackgroundImage = global::Maquette_Belle_Table_Final.Properties.Resources.fond;
            this.panelPlanningC.Controls.Add(this.groupBoxPJSPC);
            this.panelPlanningC.Controls.Add(this.buttonNPC);
            this.panelPlanningC.Controls.Add(this.monthCalendarPlanC);
            this.panelPlanningC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlanningC.Location = new System.Drawing.Point(3, 3);
            this.panelPlanningC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelPlanningC.Name = "panelPlanningC";
            this.panelPlanningC.Size = new System.Drawing.Size(984, 456);
            this.panelPlanningC.TabIndex = 13;
            // 
            // groupBoxPJSPC
            // 
            this.groupBoxPJSPC.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPJSPC.Controls.Add(this.listViewPJSPC);
            this.groupBoxPJSPC.Location = new System.Drawing.Point(641, 93);
            this.groupBoxPJSPC.Name = "groupBoxPJSPC";
            this.groupBoxPJSPC.Size = new System.Drawing.Size(272, 343);
            this.groupBoxPJSPC.TabIndex = 2;
            this.groupBoxPJSPC.TabStop = false;
            this.groupBoxPJSPC.Text = "Planning du Jour sélectionné";
            // 
            // listViewPJSPC
            // 
            this.listViewPJSPC.Location = new System.Drawing.Point(20, 43);
            this.listViewPJSPC.Name = "listViewPJSPC";
            this.listViewPJSPC.Size = new System.Drawing.Size(234, 282);
            this.listViewPJSPC.TabIndex = 0;
            this.listViewPJSPC.UseCompatibleStateImageBehavior = false;
            // 
            // buttonNPC
            // 
            this.buttonNPC.BackColor = System.Drawing.Color.Gold;
            this.buttonNPC.Location = new System.Drawing.Point(641, 26);
            this.buttonNPC.Name = "buttonNPC";
            this.buttonNPC.Size = new System.Drawing.Size(272, 32);
            this.buttonNPC.TabIndex = 1;
            this.buttonNPC.Text = "Nouvelle période de congés";
            this.buttonNPC.UseVisualStyleBackColor = false;
            this.buttonNPC.Click += new System.EventHandler(this.buttonNPC_Click);
            // 
            // monthCalendarPlanC
            // 
            this.monthCalendarPlanC.Location = new System.Drawing.Point(51, 93);
            this.monthCalendarPlanC.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.monthCalendarPlanC.MaximumSize = new System.Drawing.Size(943, 552);
            this.monthCalendarPlanC.MinimumSize = new System.Drawing.Size(313, 252);
            this.monthCalendarPlanC.Name = "monthCalendarPlanC";
            this.monthCalendarPlanC.ShowToday = false;
            this.monthCalendarPlanC.ShowTodayCircle = false;
            this.monthCalendarPlanC.TabIndex = 0;
            // 
            // tabPagePF
            // 
            this.tabPagePF.Controls.Add(this.panelPortefeuille);
            this.tabPagePF.Location = new System.Drawing.Point(4, 33);
            this.tabPagePF.Name = "tabPagePF";
            this.tabPagePF.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePF.Size = new System.Drawing.Size(990, 462);
            this.tabPagePF.TabIndex = 2;
            this.tabPagePF.Text = "Portefeuille";
            this.tabPagePF.UseVisualStyleBackColor = true;
            // 
            // panelPortefeuille
            // 
            this.panelPortefeuille.BackgroundImage = global::Maquette_Belle_Table_Final.Properties.Resources.fond;
            this.panelPortefeuille.Controls.Add(this.dataGridViewPortefeuille);
            this.panelPortefeuille.Controls.Add(this.buttonEnvoiMail);
            this.panelPortefeuille.Controls.Add(this.buttonModCli);
            this.panelPortefeuille.Controls.Add(this.buttonAddCli);
            this.panelPortefeuille.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPortefeuille.Location = new System.Drawing.Point(3, 3);
            this.panelPortefeuille.Name = "panelPortefeuille";
            this.panelPortefeuille.Size = new System.Drawing.Size(984, 456);
            this.panelPortefeuille.TabIndex = 4;
            // 
            // dataGridViewPortefeuille
            // 
            this.dataGridViewPortefeuille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPortefeuille.Location = new System.Drawing.Point(35, 90);
            this.dataGridViewPortefeuille.Name = "dataGridViewPortefeuille";
            this.dataGridViewPortefeuille.RowTemplate.Height = 28;
            this.dataGridViewPortefeuille.Size = new System.Drawing.Size(913, 340);
            this.dataGridViewPortefeuille.TabIndex = 4;
            this.dataGridViewPortefeuille.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPortefeuille_CellContentClick);
            // 
            // buttonEnvoiMail
            // 
            this.buttonEnvoiMail.BackColor = System.Drawing.Color.Gold;
            this.buttonEnvoiMail.Location = new System.Drawing.Point(718, 37);
            this.buttonEnvoiMail.Name = "buttonEnvoiMail";
            this.buttonEnvoiMail.Size = new System.Drawing.Size(230, 34);
            this.buttonEnvoiMail.TabIndex = 3;
            this.buttonEnvoiMail.Text = "Envoyer un mail";
            this.buttonEnvoiMail.UseVisualStyleBackColor = false;
            this.buttonEnvoiMail.Click += new System.EventHandler(this.buttonEnvoiMail_Click);
            // 
            // buttonModCli
            // 
            this.buttonModCli.BackColor = System.Drawing.Color.Gold;
            this.buttonModCli.Location = new System.Drawing.Point(317, 37);
            this.buttonModCli.Name = "buttonModCli";
            this.buttonModCli.Size = new System.Drawing.Size(230, 34);
            this.buttonModCli.TabIndex = 2;
            this.buttonModCli.Text = "Modifier un client";
            this.buttonModCli.UseVisualStyleBackColor = false;
            this.buttonModCli.Click += new System.EventHandler(this.buttonModCli_Click);
            // 
            // buttonAddCli
            // 
            this.buttonAddCli.BackColor = System.Drawing.Color.Gold;
            this.buttonAddCli.Location = new System.Drawing.Point(35, 37);
            this.buttonAddCli.Name = "buttonAddCli";
            this.buttonAddCli.Size = new System.Drawing.Size(230, 34);
            this.buttonAddCli.TabIndex = 1;
            this.buttonAddCli.Text = "Ajouter un client";
            this.buttonAddCli.UseVisualStyleBackColor = false;
            this.buttonAddCli.Click += new System.EventHandler(this.buttonAddCli_Click);
            // 
            // tabPageMails
            // 
            this.tabPageMails.Controls.Add(this.panelMail);
            this.tabPageMails.Location = new System.Drawing.Point(4, 33);
            this.tabPageMails.Name = "tabPageMails";
            this.tabPageMails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMails.Size = new System.Drawing.Size(990, 462);
            this.tabPageMails.TabIndex = 3;
            this.tabPageMails.Text = "Mails";
            this.tabPageMails.UseVisualStyleBackColor = true;
            // 
            // panelMail
            // 
            this.panelMail.BackgroundImage = global::Maquette_Belle_Table_Final.Properties.Resources.fond;
            this.panelMail.Controls.Add(this.buttonOuvrirEmail);
            this.panelMail.Controls.Add(this.buttonEnvoiEmail);
            this.panelMail.Controls.Add(this.dataGridViewMail);
            this.panelMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMail.Location = new System.Drawing.Point(3, 3);
            this.panelMail.Name = "panelMail";
            this.panelMail.Size = new System.Drawing.Size(984, 456);
            this.panelMail.TabIndex = 6;
            // 
            // buttonOuvrirEmail
            // 
            this.buttonOuvrirEmail.BackColor = System.Drawing.Color.Gold;
            this.buttonOuvrirEmail.Location = new System.Drawing.Point(795, 93);
            this.buttonOuvrirEmail.Name = "buttonOuvrirEmail";
            this.buttonOuvrirEmail.Size = new System.Drawing.Size(158, 34);
            this.buttonOuvrirEmail.TabIndex = 2;
            this.buttonOuvrirEmail.Text = "Ouvrir le mail";
            this.buttonOuvrirEmail.UseVisualStyleBackColor = false;
            this.buttonOuvrirEmail.Click += new System.EventHandler(this.buttonOuvrirEmail_Click);
            // 
            // buttonEnvoiEmail
            // 
            this.buttonEnvoiEmail.BackColor = System.Drawing.Color.Gold;
            this.buttonEnvoiEmail.Location = new System.Drawing.Point(795, 37);
            this.buttonEnvoiEmail.Name = "buttonEnvoiEmail";
            this.buttonEnvoiEmail.Size = new System.Drawing.Size(158, 34);
            this.buttonEnvoiEmail.TabIndex = 1;
            this.buttonEnvoiEmail.Text = "Envoyer un Email";
            this.buttonEnvoiEmail.UseVisualStyleBackColor = false;
            this.buttonEnvoiEmail.Click += new System.EventHandler(this.buttonEnvoiEmail_Click);
            // 
            // dataGridViewMail
            // 
            this.dataGridViewMail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMail.Location = new System.Drawing.Point(19, 37);
            this.dataGridViewMail.Name = "dataGridViewMail";
            this.dataGridViewMail.RowTemplate.Height = 28;
            this.dataGridViewMail.Size = new System.Drawing.Size(735, 387);
            this.dataGridViewMail.TabIndex = 0;
            this.dataGridViewMail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMail_CellContentClick);
            // 
            // tabPageCDMDP
            // 
            this.tabPageCDMDP.Controls.Add(this.panelChangerMDP);
            this.tabPageCDMDP.Location = new System.Drawing.Point(4, 33);
            this.tabPageCDMDP.Name = "tabPageCDMDP";
            this.tabPageCDMDP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCDMDP.Size = new System.Drawing.Size(990, 462);
            this.tabPageCDMDP.TabIndex = 4;
            this.tabPageCDMDP.Text = "Changer de mot de passe";
            this.tabPageCDMDP.UseVisualStyleBackColor = true;
            // 
            // panelChangerMDP
            // 
            this.panelChangerMDP.BackColor = System.Drawing.Color.Transparent;
            this.panelChangerMDP.BackgroundImage = global::Maquette_Belle_Table_Final.Properties.Resources.fond;
            this.panelChangerMDP.Controls.Add(this.buttonValCDMDP);
            this.panelChangerMDP.Controls.Add(this.textBoxNoMDP);
            this.panelChangerMDP.Controls.Add(this.labelNoMDP);
            this.panelChangerMDP.Controls.Add(this.labelLogC);
            this.panelChangerMDP.Controls.Add(this.textBoxLog);
            this.panelChangerMDP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChangerMDP.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelChangerMDP.Location = new System.Drawing.Point(3, 3);
            this.panelChangerMDP.Name = "panelChangerMDP";
            this.panelChangerMDP.Size = new System.Drawing.Size(984, 456);
            this.panelChangerMDP.TabIndex = 9;
            // 
            // buttonValCDMDP
            // 
            this.buttonValCDMDP.BackColor = System.Drawing.Color.Gold;
            this.buttonValCDMDP.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValCDMDP.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonValCDMDP.Location = new System.Drawing.Point(447, 212);
            this.buttonValCDMDP.Name = "buttonValCDMDP";
            this.buttonValCDMDP.Size = new System.Drawing.Size(90, 32);
            this.buttonValCDMDP.TabIndex = 18;
            this.buttonValCDMDP.Text = "Valider";
            this.buttonValCDMDP.UseVisualStyleBackColor = false;
            this.buttonValCDMDP.Click += new System.EventHandler(this.buttonValCDMDP_Click);
            // 
            // textBoxNoMDP
            // 
            this.textBoxNoMDP.Location = new System.Drawing.Point(440, 152);
            this.textBoxNoMDP.Name = "textBoxNoMDP";
            this.textBoxNoMDP.Size = new System.Drawing.Size(248, 27);
            this.textBoxNoMDP.TabIndex = 3;
            // 
            // labelNoMDP
            // 
            this.labelNoMDP.AutoSize = true;
            this.labelNoMDP.BackColor = System.Drawing.Color.Transparent;
            this.labelNoMDP.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoMDP.Location = new System.Drawing.Point(258, 154);
            this.labelNoMDP.Name = "labelNoMDP";
            this.labelNoMDP.Size = new System.Drawing.Size(200, 21);
            this.labelNoMDP.TabIndex = 1;
            this.labelNoMDP.Text = "Nouveau mot de passe :";
            // 
            // labelLogC
            // 
            this.labelLogC.AutoSize = true;
            this.labelLogC.BackColor = System.Drawing.Color.Transparent;
            this.labelLogC.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogC.Location = new System.Drawing.Point(355, 96);
            this.labelLogC.Name = "labelLogC";
            this.labelLogC.Size = new System.Drawing.Size(59, 21);
            this.labelLogC.TabIndex = 0;
            this.labelLogC.Text = "Login :";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(440, 94);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(216, 27);
            this.textBoxLog.TabIndex = 2;
            // 
            // InterGes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maquette_Belle_Table_Final.Properties.Resources.fond;
            this.ClientSize = new System.Drawing.Size(1000, 537);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.panelBordeLeft);
            this.Controls.Add(this.panelBorderBottom);
            this.Controls.Add(this.panelBorderRight);
            this.Controls.Add(this.tableLayoutEntete);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterGes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InterGes";
            this.tableLayoutEntete.ResumeLayout(false);
            this.panelTitre.ResumeLayout(false);
            this.panelTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBT)).EndInit();
            this.tabPagePlan.ResumeLayout(false);
            this.panelPlanning.ResumeLayout(false);
            this.groupBoxPJS.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPagePlanC.ResumeLayout(false);
            this.panelPlanningC.ResumeLayout(false);
            this.groupBoxPJSPC.ResumeLayout(false);
            this.tabPagePF.ResumeLayout(false);
            this.panelPortefeuille.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPortefeuille)).EndInit();
            this.tabPageMails.ResumeLayout(false);
            this.panelMail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMail)).EndInit();
            this.tabPageCDMDP.ResumeLayout(false);
            this.panelChangerMDP.ResumeLayout(false);
            this.panelChangerMDP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutEntete;
        private System.Windows.Forms.Panel panelTitre;
        private System.Windows.Forms.Label labelFermeture;
        private System.Windows.Forms.Label labelBT;
        private System.Windows.Forms.PictureBox pictureBoxBT;
        private System.Windows.Forms.Panel panelBorderRight;
        private System.Windows.Forms.Panel panelBorderBottom;
        private System.Windows.Forms.Panel panelBordeLeft;
        private System.Windows.Forms.TabPage tabPagePlan;
        private System.Windows.Forms.Panel panelPlanning;
        private System.Windows.Forms.GroupBox groupBoxPJS;
        private System.Windows.Forms.ListView listViewPlan;
        private System.Windows.Forms.Button buttonNRDV;
        private System.Windows.Forms.MonthCalendar monthCalendarPlan;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPagePlanC;
        private System.Windows.Forms.Panel panelPlanningC;
        private System.Windows.Forms.GroupBox groupBoxPJSPC;
        private System.Windows.Forms.ListView listViewPJSPC;
        private System.Windows.Forms.Button buttonNPC;
        private System.Windows.Forms.MonthCalendar monthCalendarPlanC;
        private System.Windows.Forms.TabPage tabPagePF;
        private System.Windows.Forms.Panel panelPortefeuille;
        private System.Windows.Forms.DataGridView dataGridViewPortefeuille;
        private System.Windows.Forms.Button buttonEnvoiMail;
        private System.Windows.Forms.Button buttonModCli;
        private System.Windows.Forms.Button buttonAddCli;
        private System.Windows.Forms.TabPage tabPageMails;
        private System.Windows.Forms.Panel panelMail;
        private System.Windows.Forms.Button buttonOuvrirEmail;
        private System.Windows.Forms.Button buttonEnvoiEmail;
        private System.Windows.Forms.DataGridView dataGridViewMail;
        private System.Windows.Forms.TabPage tabPageCDMDP;
        private System.Windows.Forms.Panel panelChangerMDP;
        private System.Windows.Forms.TextBox textBoxNoMDP;
        private System.Windows.Forms.Label labelNoMDP;
        private System.Windows.Forms.Label labelLogC;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonValCDMDP;
    }
}