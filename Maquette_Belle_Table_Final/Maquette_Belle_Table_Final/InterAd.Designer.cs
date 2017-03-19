namespace Maquette_Belle_Table_Final
{
    partial class InterAd
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageUti = new System.Windows.Forms.TabPage();
            this.panelUtilisateur = new System.Windows.Forms.Panel();
            this.dataGridViewUti = new System.Windows.Forms.DataGridView();
            this.buttonSuppUti = new System.Windows.Forms.Button();
            this.buttonModUti = new System.Windows.Forms.Button();
            this.buttonAddUti = new System.Windows.Forms.Button();
            this.tabPageHC = new System.Windows.Forms.TabPage();
            this.panelHistoriqueC = new System.Windows.Forms.Panel();
            this.dataGridViewHC = new System.Windows.Forms.DataGridView();
            this.tabPageCMDP = new System.Windows.Forms.TabPage();
            this.panelChangerMDP = new System.Windows.Forms.Panel();
            this.textBoxNoMDP = new System.Windows.Forms.TextBox();
            this.labelNoMDP = new System.Windows.Forms.Label();
            this.labelLogC = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.buttonValCDMDP = new System.Windows.Forms.Button();
            this.tableLayoutEntete.SuspendLayout();
            this.panelTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBT)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageUti.SuspendLayout();
            this.panelUtilisateur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUti)).BeginInit();
            this.tabPageHC.SuspendLayout();
            this.panelHistoriqueC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHC)).BeginInit();
            this.tabPageCMDP.SuspendLayout();
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
            this.tableLayoutEntete.TabIndex = 2;
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
            this.labelFermeture.Location = new System.Drawing.Point(966, 2);
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
            this.panelBorderRight.TabIndex = 12;
            // 
            // panelBorderBottom
            // 
            this.panelBorderBottom.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelBorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBorderBottom.Location = new System.Drawing.Point(0, 536);
            this.panelBorderBottom.Name = "panelBorderBottom";
            this.panelBorderBottom.Size = new System.Drawing.Size(999, 1);
            this.panelBorderBottom.TabIndex = 13;
            // 
            // panelBordeLeft
            // 
            this.panelBordeLeft.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelBordeLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBordeLeft.Location = new System.Drawing.Point(0, 37);
            this.panelBordeLeft.Name = "panelBordeLeft";
            this.panelBordeLeft.Size = new System.Drawing.Size(1, 499);
            this.panelBordeLeft.TabIndex = 14;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPageUti);
            this.tabControl1.Controls.Add(this.tabPageHC);
            this.tabControl1.Controls.Add(this.tabPageCMDP);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.tabControl1.Location = new System.Drawing.Point(1, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(998, 499);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPageUti
            // 
            this.tabPageUti.BackgroundImage = global::Maquette_Belle_Table_Final.Properties.Resources.fond;
            this.tabPageUti.Controls.Add(this.panelUtilisateur);
            this.tabPageUti.Location = new System.Drawing.Point(4, 33);
            this.tabPageUti.Name = "tabPageUti";
            this.tabPageUti.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUti.Size = new System.Drawing.Size(990, 462);
            this.tabPageUti.TabIndex = 0;
            this.tabPageUti.Text = "Utilisateurs";
            this.tabPageUti.UseVisualStyleBackColor = true;
            // 
            // panelUtilisateur
            // 
            this.panelUtilisateur.BackgroundImage = global::Maquette_Belle_Table_Final.Properties.Resources.fond;
            this.panelUtilisateur.Controls.Add(this.dataGridViewUti);
            this.panelUtilisateur.Controls.Add(this.buttonSuppUti);
            this.panelUtilisateur.Controls.Add(this.buttonModUti);
            this.panelUtilisateur.Controls.Add(this.buttonAddUti);
            this.panelUtilisateur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUtilisateur.Location = new System.Drawing.Point(3, 3);
            this.panelUtilisateur.Name = "panelUtilisateur";
            this.panelUtilisateur.Size = new System.Drawing.Size(984, 456);
            this.panelUtilisateur.TabIndex = 3;
            // 
            // dataGridViewUti
            // 
            this.dataGridViewUti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUti.Location = new System.Drawing.Point(35, 88);
            this.dataGridViewUti.Name = "dataGridViewUti";
            this.dataGridViewUti.RowTemplate.Height = 28;
            this.dataGridViewUti.Size = new System.Drawing.Size(913, 340);
            this.dataGridViewUti.TabIndex = 3;
            this.dataGridViewUti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUti_CellContentClick);
            // 
            // buttonSuppUti
            // 
            this.buttonSuppUti.BackColor = System.Drawing.Color.Gold;
            this.buttonSuppUti.Location = new System.Drawing.Point(629, 19);
            this.buttonSuppUti.Name = "buttonSuppUti";
            this.buttonSuppUti.Size = new System.Drawing.Size(203, 36);
            this.buttonSuppUti.TabIndex = 2;
            this.buttonSuppUti.Text = "Supprimer utilisateur";
            this.buttonSuppUti.UseVisualStyleBackColor = false;
            this.buttonSuppUti.Click += new System.EventHandler(this.buttonSuppUti_Click);
            // 
            // buttonModUti
            // 
            this.buttonModUti.BackColor = System.Drawing.Color.Gold;
            this.buttonModUti.Location = new System.Drawing.Point(332, 19);
            this.buttonModUti.Name = "buttonModUti";
            this.buttonModUti.Size = new System.Drawing.Size(203, 36);
            this.buttonModUti.TabIndex = 1;
            this.buttonModUti.Text = "Modifier utilisateur";
            this.buttonModUti.UseVisualStyleBackColor = false;
            this.buttonModUti.Click += new System.EventHandler(this.buttonModUti_Click);
            // 
            // buttonAddUti
            // 
            this.buttonAddUti.BackColor = System.Drawing.Color.Gold;
            this.buttonAddUti.Location = new System.Drawing.Point(35, 19);
            this.buttonAddUti.Name = "buttonAddUti";
            this.buttonAddUti.Size = new System.Drawing.Size(203, 36);
            this.buttonAddUti.TabIndex = 0;
            this.buttonAddUti.Text = "Ajouter utilisateur";
            this.buttonAddUti.UseVisualStyleBackColor = false;
            this.buttonAddUti.Click += new System.EventHandler(this.buttonAddUti_Click);
            // 
            // tabPageHC
            // 
            this.tabPageHC.BackgroundImage = global::Maquette_Belle_Table_Final.Properties.Resources.fond;
            this.tabPageHC.Controls.Add(this.panelHistoriqueC);
            this.tabPageHC.Location = new System.Drawing.Point(4, 33);
            this.tabPageHC.Name = "tabPageHC";
            this.tabPageHC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHC.Size = new System.Drawing.Size(990, 462);
            this.tabPageHC.TabIndex = 1;
            this.tabPageHC.Text = "Historique des connexions";
            this.tabPageHC.UseVisualStyleBackColor = true;
            // 
            // panelHistoriqueC
            // 
            this.panelHistoriqueC.BackgroundImage = global::Maquette_Belle_Table_Final.Properties.Resources.fond;
            this.panelHistoriqueC.Controls.Add(this.dataGridViewHC);
            this.panelHistoriqueC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHistoriqueC.Location = new System.Drawing.Point(3, 3);
            this.panelHistoriqueC.Name = "panelHistoriqueC";
            this.panelHistoriqueC.Size = new System.Drawing.Size(984, 456);
            this.panelHistoriqueC.TabIndex = 5;
            // 
            // dataGridViewHC
            // 
            this.dataGridViewHC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHC.Location = new System.Drawing.Point(35, 38);
            this.dataGridViewHC.Name = "dataGridViewHC";
            this.dataGridViewHC.RowTemplate.Height = 28;
            this.dataGridViewHC.Size = new System.Drawing.Size(913, 380);
            this.dataGridViewHC.TabIndex = 0;
            this.dataGridViewHC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHC_CellContentClick);
            // 
            // tabPageCMDP
            // 
            this.tabPageCMDP.Controls.Add(this.panelChangerMDP);
            this.tabPageCMDP.Location = new System.Drawing.Point(4, 33);
            this.tabPageCMDP.Name = "tabPageCMDP";
            this.tabPageCMDP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCMDP.Size = new System.Drawing.Size(990, 462);
            this.tabPageCMDP.TabIndex = 2;
            this.tabPageCMDP.Text = "Changer de mot de passe";
            this.tabPageCMDP.UseVisualStyleBackColor = true;
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
            this.panelChangerMDP.TabIndex = 8;
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
            // buttonValCDMDP
            // 
            this.buttonValCDMDP.BackColor = System.Drawing.Color.Gold;
            this.buttonValCDMDP.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValCDMDP.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonValCDMDP.Location = new System.Drawing.Point(440, 210);
            this.buttonValCDMDP.Name = "buttonValCDMDP";
            this.buttonValCDMDP.Size = new System.Drawing.Size(90, 32);
            this.buttonValCDMDP.TabIndex = 19;
            this.buttonValCDMDP.Text = "Valider";
            this.buttonValCDMDP.UseVisualStyleBackColor = false;
            // 
            // InterAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maquette_Belle_Table_Final.Properties.Resources.fond;
            this.ClientSize = new System.Drawing.Size(1000, 537);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelBordeLeft);
            this.Controls.Add(this.panelBorderBottom);
            this.Controls.Add(this.panelBorderRight);
            this.Controls.Add(this.tableLayoutEntete);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterAd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InterAd";
            this.tableLayoutEntete.ResumeLayout(false);
            this.panelTitre.ResumeLayout(false);
            this.panelTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBT)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageUti.ResumeLayout(false);
            this.panelUtilisateur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUti)).EndInit();
            this.tabPageHC.ResumeLayout(false);
            this.panelHistoriqueC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHC)).EndInit();
            this.tabPageCMDP.ResumeLayout(false);
            this.panelChangerMDP.ResumeLayout(false);
            this.panelChangerMDP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutEntete;
        private System.Windows.Forms.Panel panelTitre;
        private System.Windows.Forms.Label labelBT;
        private System.Windows.Forms.PictureBox pictureBoxBT;
        private System.Windows.Forms.Panel panelBorderRight;
        private System.Windows.Forms.Panel panelBorderBottom;
        private System.Windows.Forms.Panel panelBordeLeft;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageUti;
        private System.Windows.Forms.TabPage tabPageHC;
        private System.Windows.Forms.Panel panelUtilisateur;
        private System.Windows.Forms.DataGridView dataGridViewUti;
        private System.Windows.Forms.Button buttonSuppUti;
        private System.Windows.Forms.Button buttonModUti;
        private System.Windows.Forms.Button buttonAddUti;
        private System.Windows.Forms.TabPage tabPageCMDP;
        private System.Windows.Forms.Label labelFermeture;
        private System.Windows.Forms.Panel panelHistoriqueC;
        private System.Windows.Forms.DataGridView dataGridViewHC;
        private System.Windows.Forms.Panel panelChangerMDP;
        private System.Windows.Forms.TextBox textBoxNoMDP;
        private System.Windows.Forms.Label labelNoMDP;
        private System.Windows.Forms.Label labelLogC;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonValCDMDP;
    }
}