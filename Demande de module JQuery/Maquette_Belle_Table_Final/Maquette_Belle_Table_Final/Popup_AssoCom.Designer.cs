namespace Maquette_Belle_Table_Final
{
    partial class Popup_AssoCom
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
            this.textBoxNomCom = new System.Windows.Forms.TextBox();
            this.buttonAnul = new System.Windows.Forms.Button();
            this.buttonVal = new System.Windows.Forms.Button();
            this.labelNomCom = new System.Windows.Forms.Label();
            this.panelBorderBottom = new System.Windows.Forms.Panel();
            this.panelBordeLeft = new System.Windows.Forms.Panel();
            this.panelBorderRight = new System.Windows.Forms.Panel();
            this.textBoxPrenomCom = new System.Windows.Forms.TextBox();
            this.labelPrenomCom = new System.Windows.Forms.Label();
            this.labelNomPF = new System.Windows.Forms.Label();
            this.comboBoxNomPF = new System.Windows.Forms.ComboBox();
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
            this.panelMenu.Size = new System.Drawing.Size(629, 33);
            this.panelMenu.TabIndex = 35;
            // 
            // panelTitre
            // 
            this.panelTitre.Controls.Add(this.label2);
            this.panelTitre.Controls.Add(this.labelBT);
            this.panelTitre.Controls.Add(this.pictureBoxBT);
            this.panelTitre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitre.Location = new System.Drawing.Point(0, 0);
            this.panelTitre.Name = "panelTitre";
            this.panelTitre.Size = new System.Drawing.Size(629, 33);
            this.panelTitre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(596, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 22);
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
            this.pictureBoxBT.Size = new System.Drawing.Size(32, 27);
            this.pictureBoxBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBT.TabIndex = 0;
            this.pictureBoxBT.TabStop = false;
            // 
            // textBoxNomCom
            // 
            this.textBoxNomCom.Location = new System.Drawing.Point(238, 65);
            this.textBoxNomCom.Name = "textBoxNomCom";
            this.textBoxNomCom.Size = new System.Drawing.Size(286, 27);
            this.textBoxNomCom.TabIndex = 42;
            // 
            // buttonAnul
            // 
            this.buttonAnul.BackColor = System.Drawing.Color.Gold;
            this.buttonAnul.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnul.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonAnul.Location = new System.Drawing.Point(46, 302);
            this.buttonAnul.Name = "buttonAnul";
            this.buttonAnul.Size = new System.Drawing.Size(100, 34);
            this.buttonAnul.TabIndex = 41;
            this.buttonAnul.Text = "Annuler";
            this.buttonAnul.UseVisualStyleBackColor = false;
            this.buttonAnul.Click += new System.EventHandler(this.buttonAnul_Click);
            // 
            // buttonVal
            // 
            this.buttonVal.BackColor = System.Drawing.Color.Gold;
            this.buttonVal.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonVal.Location = new System.Drawing.Point(491, 302);
            this.buttonVal.Name = "buttonVal";
            this.buttonVal.Size = new System.Drawing.Size(100, 34);
            this.buttonVal.TabIndex = 40;
            this.buttonVal.Text = "Valider";
            this.buttonVal.UseVisualStyleBackColor = false;
            this.buttonVal.Click += new System.EventHandler(this.buttonVal_Click);
            // 
            // labelNomCom
            // 
            this.labelNomCom.AutoSize = true;
            this.labelNomCom.BackColor = System.Drawing.Color.Transparent;
            this.labelNomCom.Location = new System.Drawing.Point(41, 68);
            this.labelNomCom.Name = "labelNomCom";
            this.labelNomCom.Size = new System.Drawing.Size(180, 21);
            this.labelNomCom.TabIndex = 39;
            this.labelNomCom.Text = "Nom du commercial : ";
            // 
            // panelBorderBottom
            // 
            this.panelBorderBottom.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelBorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBorderBottom.Location = new System.Drawing.Point(1, 366);
            this.panelBorderBottom.Name = "panelBorderBottom";
            this.panelBorderBottom.Size = new System.Drawing.Size(629, 1);
            this.panelBorderBottom.TabIndex = 38;
            // 
            // panelBordeLeft
            // 
            this.panelBordeLeft.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelBordeLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBordeLeft.Location = new System.Drawing.Point(0, 0);
            this.panelBordeLeft.Name = "panelBordeLeft";
            this.panelBordeLeft.Size = new System.Drawing.Size(1, 367);
            this.panelBordeLeft.TabIndex = 37;
            // 
            // panelBorderRight
            // 
            this.panelBorderRight.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelBorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBorderRight.Location = new System.Drawing.Point(630, 0);
            this.panelBorderRight.Name = "panelBorderRight";
            this.panelBorderRight.Size = new System.Drawing.Size(1, 367);
            this.panelBorderRight.TabIndex = 36;
            // 
            // textBoxPrenomCom
            // 
            this.textBoxPrenomCom.Location = new System.Drawing.Point(238, 127);
            this.textBoxPrenomCom.Name = "textBoxPrenomCom";
            this.textBoxPrenomCom.Size = new System.Drawing.Size(286, 27);
            this.textBoxPrenomCom.TabIndex = 44;
            // 
            // labelPrenomCom
            // 
            this.labelPrenomCom.AutoSize = true;
            this.labelPrenomCom.BackColor = System.Drawing.Color.Transparent;
            this.labelPrenomCom.Location = new System.Drawing.Point(41, 130);
            this.labelPrenomCom.Name = "labelPrenomCom";
            this.labelPrenomCom.Size = new System.Drawing.Size(202, 21);
            this.labelPrenomCom.TabIndex = 43;
            this.labelPrenomCom.Text = "Prénom du commercial : ";
            // 
            // labelNomPF
            // 
            this.labelNomPF.AutoSize = true;
            this.labelNomPF.BackColor = System.Drawing.Color.Transparent;
            this.labelNomPF.Location = new System.Drawing.Point(41, 199);
            this.labelNomPF.Name = "labelNomPF";
            this.labelNomPF.Size = new System.Drawing.Size(175, 21);
            this.labelNomPF.TabIndex = 45;
            this.labelNomPF.Text = "Nom du portefeuille : ";
            // 
            // comboBoxNomPF
            // 
            this.comboBoxNomPF.FormattingEnabled = true;
            this.comboBoxNomPF.Location = new System.Drawing.Point(238, 196);
            this.comboBoxNomPF.Name = "comboBoxNomPF";
            this.comboBoxNomPF.Size = new System.Drawing.Size(233, 29);
            this.comboBoxNomPF.TabIndex = 46;
            // 
            // Popup_AssoCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maquette_Belle_Table_Final.Properties.Resources.fond;
            this.ClientSize = new System.Drawing.Size(631, 367);
            this.Controls.Add(this.comboBoxNomPF);
            this.Controls.Add(this.labelNomPF);
            this.Controls.Add(this.textBoxPrenomCom);
            this.Controls.Add(this.labelPrenomCom);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.textBoxNomCom);
            this.Controls.Add(this.buttonAnul);
            this.Controls.Add(this.buttonVal);
            this.Controls.Add(this.labelNomCom);
            this.Controls.Add(this.panelBorderBottom);
            this.Controls.Add(this.panelBordeLeft);
            this.Controls.Add(this.panelBorderRight);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Popup_AssoCom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popup_AssoCom";
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
        private System.Windows.Forms.TextBox textBoxNomCom;
        private System.Windows.Forms.Button buttonAnul;
        private System.Windows.Forms.Button buttonVal;
        private System.Windows.Forms.Label labelNomCom;
        private System.Windows.Forms.Panel panelBorderBottom;
        private System.Windows.Forms.Panel panelBordeLeft;
        private System.Windows.Forms.Panel panelBorderRight;
        private System.Windows.Forms.TextBox textBoxPrenomCom;
        private System.Windows.Forms.Label labelPrenomCom;
        private System.Windows.Forms.Label labelNomPF;
        private System.Windows.Forms.ComboBox comboBoxNomPF;
    }
}