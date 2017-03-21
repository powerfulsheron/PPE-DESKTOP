namespace Maquette_Belle_Table
{
    partial class PopNouveauRDV
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelTitre = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFermeture = new System.Windows.Forms.Label();
            this.labelBT = new System.Windows.Forms.Label();
            this.pictureBoxBT = new System.Windows.Forms.PictureBox();
            this.panelBorderRight = new System.Windows.Forms.Panel();
            this.panelBordeLeft = new System.Windows.Forms.Panel();
            this.panelBorderBottom = new System.Windows.Forms.Panel();
            this.groupBoxAP = new System.Windows.Forms.GroupBox();
            this.labelCodeEntree = new System.Windows.Forms.Label();
            this.textBoxCodeEntree = new System.Windows.Forms.TextBox();
            this.textBoxIC = new System.Windows.Forms.TextBox();
            this.labelIC = new System.Windows.Forms.Label();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.textBoxCp = new System.Windows.Forms.TextBox();
            this.textBoxRue = new System.Windows.Forms.TextBox();
            this.labelRue = new System.Windows.Forms.Label();
            this.labelCP = new System.Windows.Forms.Label();
            this.labelVille = new System.Windows.Forms.Label();
            this.labelTRDV = new System.Windows.Forms.Label();
            this.labelHF = new System.Windows.Forms.Label();
            this.labelHD = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerNRDV = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHD = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHF = new System.Windows.Forms.DateTimePicker();
            this.comboBoxRDVprecedent = new System.Windows.Forms.ComboBox();
            this.comboBoxTRDV = new System.Windows.Forms.ComboBox();
            this.labelAncienRDV = new System.Windows.Forms.Label();
            this.buttonVal = new System.Windows.Forms.Button();
            this.buttonAnul = new System.Windows.Forms.Button();
            this.comboBoxListeClient = new System.Windows.Forms.ComboBox();
            this.panelMenu.SuspendLayout();
            this.panelTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBT)).BeginInit();
            this.groupBoxAP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMenu.Controls.Add(this.panelTitre);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(1, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(665, 31);
            this.panelMenu.TabIndex = 10;
            // 
            // panelTitre
            // 
            this.panelTitre.Controls.Add(this.label1);
            this.panelTitre.Controls.Add(this.labelFermeture);
            this.panelTitre.Controls.Add(this.labelBT);
            this.panelTitre.Controls.Add(this.pictureBoxBT);
            this.panelTitre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitre.Location = new System.Drawing.Point(0, 0);
            this.panelTitre.Name = "panelTitre";
            this.panelTitre.Size = new System.Drawing.Size(665, 31);
            this.panelTitre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(646, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelFermeture
            // 
            this.labelFermeture.AutoSize = true;
            this.labelFermeture.BackColor = System.Drawing.Color.MidnightBlue;
            this.labelFermeture.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFermeture.ForeColor = System.Drawing.Color.Gold;
            this.labelFermeture.Location = new System.Drawing.Point(1286, 0);
            this.labelFermeture.Name = "labelFermeture";
            this.labelFermeture.Size = new System.Drawing.Size(16, 16);
            this.labelFermeture.TabIndex = 2;
            this.labelFermeture.Text = "X";
            // 
            // labelBT
            // 
            this.labelBT.AutoSize = true;
            this.labelBT.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBT.ForeColor = System.Drawing.Color.Gold;
            this.labelBT.Location = new System.Drawing.Point(36, 0);
            this.labelBT.Name = "labelBT";
            this.labelBT.Size = new System.Drawing.Size(45, 16);
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
            this.panelBorderRight.Location = new System.Drawing.Point(666, 0);
            this.panelBorderRight.Name = "panelBorderRight";
            this.panelBorderRight.Size = new System.Drawing.Size(1, 612);
            this.panelBorderRight.TabIndex = 9;
            // 
            // panelBordeLeft
            // 
            this.panelBordeLeft.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelBordeLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBordeLeft.Location = new System.Drawing.Point(0, 0);
            this.panelBordeLeft.Name = "panelBordeLeft";
            this.panelBordeLeft.Size = new System.Drawing.Size(1, 612);
            this.panelBordeLeft.TabIndex = 11;
            // 
            // panelBorderBottom
            // 
            this.panelBorderBottom.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelBorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBorderBottom.Location = new System.Drawing.Point(0, 612);
            this.panelBorderBottom.Name = "panelBorderBottom";
            this.panelBorderBottom.Size = new System.Drawing.Size(667, 1);
            this.panelBorderBottom.TabIndex = 12;
            // 
            // groupBoxAP
            // 
            this.groupBoxAP.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAP.Controls.Add(this.labelCodeEntree);
            this.groupBoxAP.Controls.Add(this.textBoxCodeEntree);
            this.groupBoxAP.Controls.Add(this.textBoxIC);
            this.groupBoxAP.Controls.Add(this.labelIC);
            this.groupBoxAP.Controls.Add(this.textBoxVille);
            this.groupBoxAP.Controls.Add(this.textBoxCp);
            this.groupBoxAP.Controls.Add(this.textBoxRue);
            this.groupBoxAP.Controls.Add(this.labelRue);
            this.groupBoxAP.Controls.Add(this.labelCP);
            this.groupBoxAP.Controls.Add(this.labelVille);
            this.groupBoxAP.Location = new System.Drawing.Point(25, 259);
            this.groupBoxAP.Name = "groupBoxAP";
            this.groupBoxAP.Size = new System.Drawing.Size(630, 302);
            this.groupBoxAP.TabIndex = 9;
            this.groupBoxAP.TabStop = false;
            this.groupBoxAP.Text = "Adresse personnelle";
            // 
            // labelCodeEntree
            // 
            this.labelCodeEntree.AutoSize = true;
            this.labelCodeEntree.Location = new System.Drawing.Point(346, 99);
            this.labelCodeEntree.Name = "labelCodeEntree";
            this.labelCodeEntree.Size = new System.Drawing.Size(93, 16);
            this.labelCodeEntree.TabIndex = 17;
            this.labelCodeEntree.Text = "Code d\'entrée :";
            this.labelCodeEntree.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxCodeEntree
            // 
            this.textBoxCodeEntree.Location = new System.Drawing.Point(451, 94);
            this.textBoxCodeEntree.Name = "textBoxCodeEntree";
            this.textBoxCodeEntree.Size = new System.Drawing.Size(119, 21);
            this.textBoxCodeEntree.TabIndex = 16;
            this.textBoxCodeEntree.Text = "12345";
            // 
            // textBoxIC
            // 
            this.textBoxIC.Location = new System.Drawing.Point(16, 203);
            this.textBoxIC.Multiline = true;
            this.textBoxIC.Name = "textBoxIC";
            this.textBoxIC.Size = new System.Drawing.Size(579, 93);
            this.textBoxIC.TabIndex = 15;
            this.textBoxIC.Text = "des infos lol.";
            // 
            // labelIC
            // 
            this.labelIC.AutoSize = true;
            this.labelIC.Location = new System.Drawing.Point(12, 179);
            this.labelIC.Name = "labelIC";
            this.labelIC.Size = new System.Drawing.Size(134, 16);
            this.labelIC.TabIndex = 14;
            this.labelIC.Text = "Infos complémentaires :";
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(76, 142);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(310, 21);
            this.textBoxVille.TabIndex = 13;
            this.textBoxVille.Text = "Paris";
            // 
            // textBoxCp
            // 
            this.textBoxCp.Location = new System.Drawing.Point(126, 96);
            this.textBoxCp.Name = "textBoxCp";
            this.textBoxCp.Size = new System.Drawing.Size(153, 21);
            this.textBoxCp.TabIndex = 12;
            this.textBoxCp.Text = "76014";
            // 
            // textBoxRue
            // 
            this.textBoxRue.Location = new System.Drawing.Point(76, 39);
            this.textBoxRue.Name = "textBoxRue";
            this.textBoxRue.Size = new System.Drawing.Size(548, 21);
            this.textBoxRue.TabIndex = 11;
            this.textBoxRue.Text = "test";
            // 
            // labelRue
            // 
            this.labelRue.AutoSize = true;
            this.labelRue.Location = new System.Drawing.Point(12, 42);
            this.labelRue.Name = "labelRue";
            this.labelRue.Size = new System.Drawing.Size(35, 16);
            this.labelRue.TabIndex = 5;
            this.labelRue.Text = "Rue :";
            // 
            // labelCP
            // 
            this.labelCP.AutoSize = true;
            this.labelCP.Location = new System.Drawing.Point(12, 99);
            this.labelCP.Name = "labelCP";
            this.labelCP.Size = new System.Drawing.Size(81, 16);
            this.labelCP.TabIndex = 4;
            this.labelCP.Text = "Code postal :";
            // 
            // labelVille
            // 
            this.labelVille.AutoSize = true;
            this.labelVille.Location = new System.Drawing.Point(12, 145);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(34, 16);
            this.labelVille.TabIndex = 3;
            this.labelVille.Text = "Ville :";
            // 
            // labelTRDV
            // 
            this.labelTRDV.AutoSize = true;
            this.labelTRDV.BackColor = System.Drawing.Color.Transparent;
            this.labelTRDV.Location = new System.Drawing.Point(37, 200);
            this.labelTRDV.Name = "labelTRDV";
            this.labelTRDV.Size = new System.Drawing.Size(132, 16);
            this.labelTRDV.TabIndex = 8;
            this.labelTRDV.Text = "Type de Rendez-vous :";
            // 
            // labelHF
            // 
            this.labelHF.AutoSize = true;
            this.labelHF.BackColor = System.Drawing.Color.Transparent;
            this.labelHF.Location = new System.Drawing.Point(357, 144);
            this.labelHF.Name = "labelHF";
            this.labelHF.Size = new System.Drawing.Size(63, 16);
            this.labelHF.TabIndex = 7;
            this.labelHF.Text = "Heure Fin :";
            // 
            // labelHD
            // 
            this.labelHD.AutoSize = true;
            this.labelHD.BackColor = System.Drawing.Color.Transparent;
            this.labelHD.Location = new System.Drawing.Point(357, 107);
            this.labelHD.Name = "labelHD";
            this.labelHD.Size = new System.Drawing.Size(83, 16);
            this.labelHD.TabIndex = 6;
            this.labelHD.Text = "Heure début :";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.BackColor = System.Drawing.Color.Transparent;
            this.labelClient.Location = new System.Drawing.Point(12, 148);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(45, 16);
            this.labelClient.TabIndex = 2;
            this.labelClient.Text = "Client :";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Location = new System.Drawing.Point(12, 102);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(41, 16);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Date :";
            // 
            // dateTimePickerNRDV
            // 
            this.dateTimePickerNRDV.CustomFormat = "dd-mm-yyyy";
            this.dateTimePickerNRDV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNRDV.Location = new System.Drawing.Point(77, 102);
            this.dateTimePickerNRDV.Name = "dateTimePickerNRDV";
            this.dateTimePickerNRDV.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerNRDV.TabIndex = 16;
            this.dateTimePickerNRDV.Value = new System.DateTime(2017, 3, 9, 0, 0, 0, 0);
            // 
            // dateTimePickerHD
            // 
            this.dateTimePickerHD.CustomFormat = "dd-mm-yyyy";
            this.dateTimePickerHD.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHD.Location = new System.Drawing.Point(480, 102);
            this.dateTimePickerHD.Name = "dateTimePickerHD";
            this.dateTimePickerHD.Size = new System.Drawing.Size(161, 21);
            this.dateTimePickerHD.TabIndex = 17;
            this.dateTimePickerHD.Value = new System.DateTime(2017, 3, 9, 0, 0, 0, 0);
            // 
            // dateTimePickerHF
            // 
            this.dateTimePickerHF.CustomFormat = "dd-mm-yyyy";
            this.dateTimePickerHF.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHF.Location = new System.Drawing.Point(480, 144);
            this.dateTimePickerHF.Name = "dateTimePickerHF";
            this.dateTimePickerHF.Size = new System.Drawing.Size(161, 21);
            this.dateTimePickerHF.TabIndex = 18;
            this.dateTimePickerHF.Value = new System.DateTime(2017, 3, 9, 0, 0, 0, 0);
            // 
            // comboBoxRDVprecedent
            // 
            this.comboBoxRDVprecedent.FormattingEnabled = true;
            this.comboBoxRDVprecedent.Location = new System.Drawing.Point(476, 224);
            this.comboBoxRDVprecedent.Name = "comboBoxRDVprecedent";
            this.comboBoxRDVprecedent.Size = new System.Drawing.Size(179, 24);
            this.comboBoxRDVprecedent.TabIndex = 20;
            // 
            // comboBoxTRDV
            // 
            this.comboBoxTRDV.FormattingEnabled = true;
            this.comboBoxTRDV.Location = new System.Drawing.Point(77, 224);
            this.comboBoxTRDV.Name = "comboBoxTRDV";
            this.comboBoxTRDV.Size = new System.Drawing.Size(201, 24);
            this.comboBoxTRDV.TabIndex = 21;
            this.comboBoxTRDV.SelectedIndexChanged += new System.EventHandler(this.comboBoxTRDV_SelectedIndexChanged);
            // 
            // labelAncienRDV
            // 
            this.labelAncienRDV.AutoSize = true;
            this.labelAncienRDV.BackColor = System.Drawing.Color.Transparent;
            this.labelAncienRDV.Location = new System.Drawing.Point(318, 224);
            this.labelAncienRDV.Name = "labelAncienRDV";
            this.labelAncienRDV.Size = new System.Drawing.Size(146, 16);
            this.labelAncienRDV.TabIndex = 22;
            this.labelAncienRDV.Text = "Rendez-vous précédent :";
            // 
            // buttonVal
            // 
            this.buttonVal.BackColor = System.Drawing.Color.Gold;
            this.buttonVal.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonVal.Location = new System.Drawing.Point(501, 569);
            this.buttonVal.Name = "buttonVal";
            this.buttonVal.Size = new System.Drawing.Size(90, 32);
            this.buttonVal.TabIndex = 23;
            this.buttonVal.Text = "Valider";
            this.buttonVal.UseVisualStyleBackColor = false;
            this.buttonVal.Click += new System.EventHandler(this.buttonVal_Click_1);
            // 
            // buttonAnul
            // 
            this.buttonAnul.BackColor = System.Drawing.Color.Gold;
            this.buttonAnul.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnul.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonAnul.Location = new System.Drawing.Point(78, 569);
            this.buttonAnul.Name = "buttonAnul";
            this.buttonAnul.Size = new System.Drawing.Size(90, 32);
            this.buttonAnul.TabIndex = 24;
            this.buttonAnul.Text = "Annuler";
            this.buttonAnul.UseVisualStyleBackColor = false;
            // 
            // comboBoxListeClient
            // 
            this.comboBoxListeClient.FormattingEnabled = true;
            this.comboBoxListeClient.Location = new System.Drawing.Point(76, 141);
            this.comboBoxListeClient.Name = "comboBoxListeClient";
            this.comboBoxListeClient.Size = new System.Drawing.Size(201, 24);
            this.comboBoxListeClient.TabIndex = 25;
            // 
            // PopNouveauRDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 613);
            this.Controls.Add(this.comboBoxListeClient);
            this.Controls.Add(this.buttonAnul);
            this.Controls.Add(this.buttonVal);
            this.Controls.Add(this.labelAncienRDV);
            this.Controls.Add(this.comboBoxTRDV);
            this.Controls.Add(this.comboBoxRDVprecedent);
            this.Controls.Add(this.dateTimePickerHF);
            this.Controls.Add(this.dateTimePickerHD);
            this.Controls.Add(this.dateTimePickerNRDV);
            this.Controls.Add(this.labelTRDV);
            this.Controls.Add(this.labelHF);
            this.Controls.Add(this.labelHD);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.groupBoxAP);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelBorderRight);
            this.Controls.Add(this.panelBordeLeft);
            this.Controls.Add(this.panelBorderBottom);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopNouveauRDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopNouveauRDV";
            this.Load += new System.EventHandler(this.PopNouveauRDV_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitre.ResumeLayout(false);
            this.panelTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBT)).EndInit();
            this.groupBoxAP.ResumeLayout(false);
            this.groupBoxAP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFermeture;
        private System.Windows.Forms.Label labelBT;
        private System.Windows.Forms.PictureBox pictureBoxBT;
        private System.Windows.Forms.Panel panelBorderRight;
        private System.Windows.Forms.Panel panelBordeLeft;
        private System.Windows.Forms.Panel panelBorderBottom;
        private System.Windows.Forms.GroupBox groupBoxAP;
        private System.Windows.Forms.Label labelIC;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.TextBox textBoxCp;
        private System.Windows.Forms.TextBox textBoxRue;
        private System.Windows.Forms.Label labelRue;
        private System.Windows.Forms.Label labelCP;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.Label labelTRDV;
        private System.Windows.Forms.Label labelHF;
        private System.Windows.Forms.Label labelHD;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxIC;
        private System.Windows.Forms.DateTimePicker dateTimePickerNRDV;
        private System.Windows.Forms.DateTimePicker dateTimePickerHD;
        private System.Windows.Forms.DateTimePicker dateTimePickerHF;
        private System.Windows.Forms.ComboBox comboBoxRDVprecedent;
        private System.Windows.Forms.ComboBox comboBoxTRDV;
        private System.Windows.Forms.Label labelAncienRDV;
        private System.Windows.Forms.Button buttonVal;
        private System.Windows.Forms.Button buttonAnul;
        private System.Windows.Forms.ComboBox comboBoxListeClient;
        private System.Windows.Forms.Label labelCodeEntree;
        private System.Windows.Forms.TextBox textBoxCodeEntree;
    }
}