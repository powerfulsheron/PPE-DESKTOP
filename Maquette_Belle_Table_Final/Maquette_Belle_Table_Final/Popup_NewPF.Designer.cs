namespace Maquette_Belle_Table_Final
{
    partial class Popup_NewPF
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
            this.label2 = new System.Windows.Forms.Label();
            this.labelBT = new System.Windows.Forms.Label();
            this.pictureBoxBT = new System.Windows.Forms.PictureBox();
            this.buttonAnul = new System.Windows.Forms.Button();
            this.buttonVal = new System.Windows.Forms.Button();
            this.labelDC = new System.Windows.Forms.Label();
            this.panelBorderBottom = new System.Windows.Forms.Panel();
            this.panelBordeLeft = new System.Windows.Forms.Panel();
            this.panelBorderRight = new System.Windows.Forms.Panel();
            this.textBoxPF = new System.Windows.Forms.TextBox();
            this.labelComm = new System.Windows.Forms.Label();
            this.comboBoxCom = new System.Windows.Forms.ComboBox();
            this.comboBoxC = new System.Windows.Forms.ComboBox();
            this.labelcom = new System.Windows.Forms.Label();
            this.radioButtonAjout = new System.Windows.Forms.RadioButton();
            this.radioButtonModif = new System.Windows.Forms.RadioButton();
            this.checkBoxselect = new System.Windows.Forms.CheckBox();
            this.panelMenu.SuspendLayout();
            this.panelTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBT)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMenu.Controls.Add(this.panelTitre);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(1, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(684, 33);
            this.panelMenu.TabIndex = 26;
            // 
            // panelTitre
            // 
            this.panelTitre.Controls.Add(this.label2);
            this.panelTitre.Controls.Add(this.labelBT);
            this.panelTitre.Controls.Add(this.pictureBoxBT);
            this.panelTitre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitre.Location = new System.Drawing.Point(0, 0);
            this.panelTitre.Name = "panelTitre";
            this.panelTitre.Size = new System.Drawing.Size(684, 33);
            this.panelTitre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(655, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelBT
            // 
            this.labelBT.AutoSize = true;
            this.labelBT.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBT.ForeColor = System.Drawing.Color.Gold;
            this.labelBT.Location = new System.Drawing.Point(40, 0);
            this.labelBT.Name = "labelBT";
            this.labelBT.Size = new System.Drawing.Size(56, 18);
            this.labelBT.TabIndex = 1;
            this.labelBT.Text = "GEPEV";
            this.labelBT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxBT
            // 
            this.pictureBoxBT.Image = global::Maquette_Belle_Table_Final.Properties.Resources.table;
            this.pictureBoxBT.Location = new System.Drawing.Point(0, -3);
            this.pictureBoxBT.Name = "pictureBoxBT";
            this.pictureBoxBT.Size = new System.Drawing.Size(32, 27);
            this.pictureBoxBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBT.TabIndex = 0;
            this.pictureBoxBT.TabStop = false;
            // 
            // buttonAnul
            // 
            this.buttonAnul.BackColor = System.Drawing.Color.Gold;
            this.buttonAnul.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnul.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonAnul.Location = new System.Drawing.Point(25, 287);
            this.buttonAnul.Name = "buttonAnul";
            this.buttonAnul.Size = new System.Drawing.Size(100, 34);
            this.buttonAnul.TabIndex = 33;
            this.buttonAnul.Text = "Annuler";
            this.buttonAnul.UseVisualStyleBackColor = false;
            this.buttonAnul.Click += new System.EventHandler(this.buttonAnul_Click);
            // 
            // buttonVal
            // 
            this.buttonVal.BackColor = System.Drawing.Color.Gold;
            this.buttonVal.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonVal.Location = new System.Drawing.Point(565, 287);
            this.buttonVal.Name = "buttonVal";
            this.buttonVal.Size = new System.Drawing.Size(100, 34);
            this.buttonVal.TabIndex = 32;
            this.buttonVal.Text = "Valider";
            this.buttonVal.UseVisualStyleBackColor = false;
            this.buttonVal.Click += new System.EventHandler(this.buttonVal_Click);
            // 
            // labelDC
            // 
            this.labelDC.AutoSize = true;
            this.labelDC.BackColor = System.Drawing.Color.Transparent;
            this.labelDC.Location = new System.Drawing.Point(21, 103);
            this.labelDC.Name = "labelDC";
            this.labelDC.Size = new System.Drawing.Size(157, 19);
            this.labelDC.TabIndex = 30;
            this.labelDC.Text = "Nom du portefeuille : ";
            // 
            // panelBorderBottom
            // 
            this.panelBorderBottom.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelBorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBorderBottom.Location = new System.Drawing.Point(1, 332);
            this.panelBorderBottom.Name = "panelBorderBottom";
            this.panelBorderBottom.Size = new System.Drawing.Size(684, 1);
            this.panelBorderBottom.TabIndex = 29;
            // 
            // panelBordeLeft
            // 
            this.panelBordeLeft.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelBordeLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBordeLeft.Location = new System.Drawing.Point(0, 0);
            this.panelBordeLeft.Name = "panelBordeLeft";
            this.panelBordeLeft.Size = new System.Drawing.Size(1, 333);
            this.panelBordeLeft.TabIndex = 28;
            // 
            // panelBorderRight
            // 
            this.panelBorderRight.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelBorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBorderRight.Location = new System.Drawing.Point(685, 0);
            this.panelBorderRight.Name = "panelBorderRight";
            this.panelBorderRight.Size = new System.Drawing.Size(1, 333);
            this.panelBorderRight.TabIndex = 27;
            // 
            // textBoxPF
            // 
            this.textBoxPF.Location = new System.Drawing.Point(263, 100);
            this.textBoxPF.Name = "textBoxPF";
            this.textBoxPF.Size = new System.Drawing.Size(286, 24);
            this.textBoxPF.TabIndex = 34;
            this.textBoxPF.TextChanged += new System.EventHandler(this.textBoxPF_TextChanged);
            // 
            // labelComm
            // 
            this.labelComm.AutoSize = true;
            this.labelComm.BackColor = System.Drawing.Color.Transparent;
            this.labelComm.Location = new System.Drawing.Point(21, 184);
            this.labelComm.Name = "labelComm";
            this.labelComm.Size = new System.Drawing.Size(215, 19);
            this.labelComm.TabIndex = 36;
            this.labelComm.Text = "Commercial sans portefeuille :";
            // 
            // comboBoxCom
            // 
            this.comboBoxCom.FormattingEnabled = true;
            this.comboBoxCom.Location = new System.Drawing.Point(263, 178);
            this.comboBoxCom.Name = "comboBoxCom";
            this.comboBoxCom.Size = new System.Drawing.Size(286, 25);
            this.comboBoxCom.TabIndex = 37;
            this.comboBoxCom.SelectedIndexChanged += new System.EventHandler(this.comboBoxCom_SelectedIndexChanged);
            // 
            // comboBoxC
            // 
            this.comboBoxC.FormattingEnabled = true;
            this.comboBoxC.Location = new System.Drawing.Point(263, 209);
            this.comboBoxC.Name = "comboBoxC";
            this.comboBoxC.Size = new System.Drawing.Size(286, 25);
            this.comboBoxC.TabIndex = 40;
            // 
            // labelcom
            // 
            this.labelcom.AutoSize = true;
            this.labelcom.BackColor = System.Drawing.Color.Transparent;
            this.labelcom.Location = new System.Drawing.Point(21, 215);
            this.labelcom.Name = "labelcom";
            this.labelcom.Size = new System.Drawing.Size(105, 19);
            this.labelcom.TabIndex = 42;
            this.labelcom.Text = "Commercial  :";
            // 
            // radioButtonAjout
            // 
            this.radioButtonAjout.AutoSize = true;
            this.radioButtonAjout.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonAjout.Location = new System.Drawing.Point(150, 53);
            this.radioButtonAjout.Name = "radioButtonAjout";
            this.radioButtonAjout.Size = new System.Drawing.Size(78, 23);
            this.radioButtonAjout.TabIndex = 44;
            this.radioButtonAjout.TabStop = true;
            this.radioButtonAjout.Text = "Ajouter";
            this.radioButtonAjout.UseVisualStyleBackColor = false;
            this.radioButtonAjout.CheckedChanged += new System.EventHandler(this.radioButtonAjout_CheckedChanged);
            // 
            // radioButtonModif
            // 
            this.radioButtonModif.AutoSize = true;
            this.radioButtonModif.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonModif.Location = new System.Drawing.Point(370, 53);
            this.radioButtonModif.Name = "radioButtonModif";
            this.radioButtonModif.Size = new System.Drawing.Size(85, 23);
            this.radioButtonModif.TabIndex = 45;
            this.radioButtonModif.TabStop = true;
            this.radioButtonModif.Text = "Modifier";
            this.radioButtonModif.UseVisualStyleBackColor = false;
            this.radioButtonModif.CheckedChanged += new System.EventHandler(this.radioButtonModif_CheckedChanged);
            // 
            // checkBoxselect
            // 
            this.checkBoxselect.AutoSize = true;
            this.checkBoxselect.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxselect.Location = new System.Drawing.Point(263, 139);
            this.checkBoxselect.Name = "checkBoxselect";
            this.checkBoxselect.Size = new System.Drawing.Size(320, 23);
            this.checkBoxselect.TabIndex = 46;
            this.checkBoxselect.Text = "Rattacher le portefeuille à un commercial";
            this.checkBoxselect.UseVisualStyleBackColor = false;
            this.checkBoxselect.CheckedChanged += new System.EventHandler(this.checkBoxselect_CheckedChanged);
            // 
            // Popup_NewPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maquette_Belle_Table_Final.Properties.Resources.fond;
            this.ClientSize = new System.Drawing.Size(686, 333);
            this.Controls.Add(this.checkBoxselect);
            this.Controls.Add(this.radioButtonModif);
            this.Controls.Add(this.radioButtonAjout);
            this.Controls.Add(this.labelcom);
            this.Controls.Add(this.comboBoxC);
            this.Controls.Add(this.comboBoxCom);
            this.Controls.Add(this.labelComm);
            this.Controls.Add(this.textBoxPF);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.buttonAnul);
            this.Controls.Add(this.buttonVal);
            this.Controls.Add(this.labelDC);
            this.Controls.Add(this.panelBorderBottom);
            this.Controls.Add(this.panelBordeLeft);
            this.Controls.Add(this.panelBorderRight);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Popup_NewPF";
            this.Text = "Popup_NewPF";
            this.Load += new System.EventHandler(this.Popup_NewPF_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitre.ResumeLayout(false);
            this.panelTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelBT;
        private System.Windows.Forms.PictureBox pictureBoxBT;
        private System.Windows.Forms.Button buttonAnul;
        private System.Windows.Forms.Button buttonVal;
        private System.Windows.Forms.Label labelDC;
        private System.Windows.Forms.Panel panelBorderBottom;
        private System.Windows.Forms.Panel panelBordeLeft;
        private System.Windows.Forms.Panel panelBorderRight;
        private System.Windows.Forms.TextBox textBoxPF;
        private System.Windows.Forms.Label labelComm;
        private System.Windows.Forms.ComboBox comboBoxCom;
        private System.Windows.Forms.ComboBox comboBoxC;
        private System.Windows.Forms.Label labelcom;
        private System.Windows.Forms.RadioButton radioButtonAjout;
        private System.Windows.Forms.RadioButton radioButtonModif;
        private System.Windows.Forms.CheckBox checkBoxselect;
    }
}