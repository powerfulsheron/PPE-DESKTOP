namespace Maquette_Belle_Table_Final
{
    partial class Popup_VoirRDV
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
            this.panelBordeLeft = new System.Windows.Forms.Panel();
            this.panelBorderBottom = new System.Windows.Forms.Panel();
            this.panelBorderRight = new System.Windows.Forms.Panel();
            this.monthCalendarVRDV = new System.Windows.Forms.MonthCalendar();
            this.groupBoxVRDV = new System.Windows.Forms.GroupBox();
            this.listViewVRDV = new System.Windows.Forms.ListView();
            this.buttonVRDV = new System.Windows.Forms.Button();
            this.labelNoMDP = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.tableLayoutEntete.SuspendLayout();
            this.panelTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBT)).BeginInit();
            this.groupBoxVRDV.SuspendLayout();
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
            this.tableLayoutEntete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutEntete.Size = new System.Drawing.Size(1047, 39);
            this.tableLayoutEntete.TabIndex = 5;
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
            this.panelTitre.Size = new System.Drawing.Size(1041, 33);
            this.panelTitre.TabIndex = 2;
            // 
            // labelFermeture
            // 
            this.labelFermeture.AutoSize = true;
            this.labelFermeture.BackColor = System.Drawing.Color.Transparent;
            this.labelFermeture.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFermeture.ForeColor = System.Drawing.Color.Gold;
            this.labelFermeture.Location = new System.Drawing.Point(1019, 6);
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
            // panelBordeLeft
            // 
            this.panelBordeLeft.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelBordeLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBordeLeft.Location = new System.Drawing.Point(0, 39);
            this.panelBordeLeft.Name = "panelBordeLeft";
            this.panelBordeLeft.Size = new System.Drawing.Size(1, 508);
            this.panelBordeLeft.TabIndex = 21;
            // 
            // panelBorderBottom
            // 
            this.panelBorderBottom.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelBorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBorderBottom.Location = new System.Drawing.Point(1, 546);
            this.panelBorderBottom.Name = "panelBorderBottom";
            this.panelBorderBottom.Size = new System.Drawing.Size(1046, 1);
            this.panelBorderBottom.TabIndex = 22;
            // 
            // panelBorderRight
            // 
            this.panelBorderRight.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelBorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBorderRight.Location = new System.Drawing.Point(1046, 39);
            this.panelBorderRight.Name = "panelBorderRight";
            this.panelBorderRight.Size = new System.Drawing.Size(1, 507);
            this.panelBorderRight.TabIndex = 23;
            // 
            // monthCalendarVRDV
            // 
            this.monthCalendarVRDV.Location = new System.Drawing.Point(89, 157);
            this.monthCalendarVRDV.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.monthCalendarVRDV.MaximumSize = new System.Drawing.Size(943, 552);
            this.monthCalendarVRDV.MinimumSize = new System.Drawing.Size(313, 252);
            this.monthCalendarVRDV.Name = "monthCalendarVRDV";
            this.monthCalendarVRDV.ShowToday = false;
            this.monthCalendarVRDV.ShowTodayCircle = false;
            this.monthCalendarVRDV.TabIndex = 24;
            // 
            // groupBoxVRDV
            // 
            this.groupBoxVRDV.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxVRDV.Controls.Add(this.listViewVRDV);
            this.groupBoxVRDV.Location = new System.Drawing.Point(601, 157);
            this.groupBoxVRDV.Name = "groupBoxVRDV";
            this.groupBoxVRDV.Size = new System.Drawing.Size(290, 347);
            this.groupBoxVRDV.TabIndex = 25;
            this.groupBoxVRDV.TabStop = false;
            this.groupBoxVRDV.Text = "Planning du Jour sélectionné";
            // 
            // listViewVRDV
            // 
            this.listViewVRDV.Location = new System.Drawing.Point(30, 42);
            this.listViewVRDV.Name = "listViewVRDV";
            this.listViewVRDV.Size = new System.Drawing.Size(230, 289);
            this.listViewVRDV.TabIndex = 0;
            this.listViewVRDV.UseCompatibleStateImageBehavior = false;
            this.listViewVRDV.SelectedIndexChanged += new System.EventHandler(this.listViewVRDV_SelectedIndexChanged);
            // 
            // buttonVRDV
            // 
            this.buttonVRDV.BackColor = System.Drawing.Color.Gold;
            this.buttonVRDV.Location = new System.Drawing.Point(630, 94);
            this.buttonVRDV.Name = "buttonVRDV";
            this.buttonVRDV.Size = new System.Drawing.Size(230, 34);
            this.buttonVRDV.TabIndex = 26;
            this.buttonVRDV.Text = "Nouveau Rendez-vous";
            this.buttonVRDV.UseVisualStyleBackColor = false;
            this.buttonVRDV.Click += new System.EventHandler(this.buttonVRDV_Click);
            // 
            // labelNoMDP
            // 
            this.labelNoMDP.AutoSize = true;
            this.labelNoMDP.BackColor = System.Drawing.Color.Transparent;
            this.labelNoMDP.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoMDP.Location = new System.Drawing.Point(85, 101);
            this.labelNoMDP.Name = "labelNoMDP";
            this.labelNoMDP.Size = new System.Drawing.Size(238, 21);
            this.labelNoMDP.TabIndex = 27;
            this.labelNoMDP.Text = "Rendez-vous du commercial :";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(329, 98);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(186, 27);
            this.textBoxLog.TabIndex = 28;
            // 
            // Popup_VoirRDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maquette_Belle_Table_Final.Properties.Resources.fond;
            this.ClientSize = new System.Drawing.Size(1047, 547);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.labelNoMDP);
            this.Controls.Add(this.buttonVRDV);
            this.Controls.Add(this.groupBoxVRDV);
            this.Controls.Add(this.monthCalendarVRDV);
            this.Controls.Add(this.panelBorderRight);
            this.Controls.Add(this.panelBorderBottom);
            this.Controls.Add(this.panelBordeLeft);
            this.Controls.Add(this.tableLayoutEntete);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Popup_VoirRDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popup_VoirRDV";
            this.tableLayoutEntete.ResumeLayout(false);
            this.panelTitre.ResumeLayout(false);
            this.panelTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBT)).EndInit();
            this.groupBoxVRDV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutEntete;
        private System.Windows.Forms.Panel panelTitre;
        private System.Windows.Forms.Label labelFermeture;
        private System.Windows.Forms.Label labelBT;
        private System.Windows.Forms.PictureBox pictureBoxBT;
        private System.Windows.Forms.Panel panelBordeLeft;
        private System.Windows.Forms.Panel panelBorderBottom;
        private System.Windows.Forms.Panel panelBorderRight;
        private System.Windows.Forms.MonthCalendar monthCalendarVRDV;
        private System.Windows.Forms.GroupBox groupBoxVRDV;
        private System.Windows.Forms.ListView listViewVRDV;
        private System.Windows.Forms.Button buttonVRDV;
        private System.Windows.Forms.Label labelNoMDP;
        private System.Windows.Forms.TextBox textBoxLog;
    }
}