namespace Maquette_Belle_Table_Final
{
    partial class Popup_VoirMails
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
            this.dataGridViewVoirMail = new System.Windows.Forms.DataGridView();
            this.buttonEcMail = new System.Windows.Forms.Button();
            this.buttonOuvMail = new System.Windows.Forms.Button();
            this.panelBordeLeft = new System.Windows.Forms.Panel();
            this.panelBorderBottom = new System.Windows.Forms.Panel();
            this.panelBorderRight = new System.Windows.Forms.Panel();
            this.tableLayoutEntete.SuspendLayout();
            this.panelTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVoirMail)).BeginInit();
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
            this.tableLayoutEntete.Size = new System.Drawing.Size(942, 37);
            this.tableLayoutEntete.TabIndex = 4;
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
            this.panelTitre.Size = new System.Drawing.Size(936, 31);
            this.panelTitre.TabIndex = 2;
            // 
            // labelFermeture
            // 
            this.labelFermeture.AutoSize = true;
            this.labelFermeture.BackColor = System.Drawing.Color.Transparent;
            this.labelFermeture.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFermeture.ForeColor = System.Drawing.Color.Gold;
            this.labelFermeture.Location = new System.Drawing.Point(917, 6);
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
            // dataGridViewVoirMail
            // 
            this.dataGridViewVoirMail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVoirMail.Location = new System.Drawing.Point(26, 61);
            this.dataGridViewVoirMail.Name = "dataGridViewVoirMail";
            this.dataGridViewVoirMail.RowTemplate.Height = 28;
            this.dataGridViewVoirMail.Size = new System.Drawing.Size(614, 434);
            this.dataGridViewVoirMail.TabIndex = 9;
            this.dataGridViewVoirMail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVoirMail_CellContentClick);
            // 
            // buttonEcMail
            // 
            this.buttonEcMail.BackColor = System.Drawing.Color.Gold;
            this.buttonEcMail.Location = new System.Drawing.Point(699, 61);
            this.buttonEcMail.Name = "buttonEcMail";
            this.buttonEcMail.Size = new System.Drawing.Size(201, 34);
            this.buttonEcMail.TabIndex = 10;
            this.buttonEcMail.Text = "Ecrire un mail";
            this.buttonEcMail.UseVisualStyleBackColor = false;
            this.buttonEcMail.Click += new System.EventHandler(this.buttonEcMail_Click);
            // 
            // buttonOuvMail
            // 
            this.buttonOuvMail.BackColor = System.Drawing.Color.Gold;
            this.buttonOuvMail.Location = new System.Drawing.Point(699, 119);
            this.buttonOuvMail.Name = "buttonOuvMail";
            this.buttonOuvMail.Size = new System.Drawing.Size(201, 34);
            this.buttonOuvMail.TabIndex = 11;
            this.buttonOuvMail.Text = "Ouvrir le Mail";
            this.buttonOuvMail.UseVisualStyleBackColor = false;
            this.buttonOuvMail.Click += new System.EventHandler(this.buttonOuvMail_Click);
            // 
            // panelBordeLeft
            // 
            this.panelBordeLeft.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelBordeLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBordeLeft.Location = new System.Drawing.Point(0, 37);
            this.panelBordeLeft.Name = "panelBordeLeft";
            this.panelBordeLeft.Size = new System.Drawing.Size(1, 484);
            this.panelBordeLeft.TabIndex = 20;
            // 
            // panelBorderBottom
            // 
            this.panelBorderBottom.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelBorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBorderBottom.Location = new System.Drawing.Point(1, 520);
            this.panelBorderBottom.Name = "panelBorderBottom";
            this.panelBorderBottom.Size = new System.Drawing.Size(941, 1);
            this.panelBorderBottom.TabIndex = 21;
            // 
            // panelBorderRight
            // 
            this.panelBorderRight.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelBorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBorderRight.Location = new System.Drawing.Point(941, 37);
            this.panelBorderRight.Name = "panelBorderRight";
            this.panelBorderRight.Size = new System.Drawing.Size(1, 483);
            this.panelBorderRight.TabIndex = 22;
            // 
            // Popup_VoirMails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maquette_Belle_Table_Final.Properties.Resources.fond;
            this.ClientSize = new System.Drawing.Size(942, 521);
            this.Controls.Add(this.buttonOuvMail);
            this.Controls.Add(this.buttonEcMail);
            this.Controls.Add(this.dataGridViewVoirMail);
            this.Controls.Add(this.panelBorderRight);
            this.Controls.Add(this.panelBorderBottom);
            this.Controls.Add(this.panelBordeLeft);
            this.Controls.Add(this.tableLayoutEntete);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Popup_VoirMails";
            this.Text = "Popup_VoirMails";
            this.tableLayoutEntete.ResumeLayout(false);
            this.panelTitre.ResumeLayout(false);
            this.panelTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVoirMail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutEntete;
        private System.Windows.Forms.Panel panelTitre;
        private System.Windows.Forms.Label labelFermeture;
        private System.Windows.Forms.Label labelBT;
        private System.Windows.Forms.PictureBox pictureBoxBT;
        private System.Windows.Forms.DataGridView dataGridViewVoirMail;
        private System.Windows.Forms.Button buttonEcMail;
        private System.Windows.Forms.Button buttonOuvMail;
        private System.Windows.Forms.Panel panelBordeLeft;
        private System.Windows.Forms.Panel panelBorderBottom;
        private System.Windows.Forms.Panel panelBorderRight;
    }
}