namespace Maquette_Belle_Table_Final
{
    partial class Confirm
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
            this.labelConfirm = new System.Windows.Forms.Label();
            this.buttonNon = new System.Windows.Forms.Button();
            this.buttonOui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelConfirm
            // 
            this.labelConfirm.AutoSize = true;
            this.labelConfirm.Location = new System.Drawing.Point(7, 51);
            this.labelConfirm.Name = "labelConfirm";
            this.labelConfirm.Size = new System.Drawing.Size(107, 17);
            this.labelConfirm.TabIndex = 0;
            this.labelConfirm.Text = "Etes-vous sur ?";
            // 
            // buttonNon
            // 
            this.buttonNon.Location = new System.Drawing.Point(84, 172);
            this.buttonNon.Name = "buttonNon";
            this.buttonNon.Size = new System.Drawing.Size(75, 23);
            this.buttonNon.TabIndex = 1;
            this.buttonNon.Text = "Non";
            this.buttonNon.UseVisualStyleBackColor = true;
            this.buttonNon.Click += new System.EventHandler(this.buttonNon_Click);
            // 
            // buttonOui
            // 
            this.buttonOui.Location = new System.Drawing.Point(264, 172);
            this.buttonOui.Name = "buttonOui";
            this.buttonOui.Size = new System.Drawing.Size(75, 23);
            this.buttonOui.TabIndex = 2;
            this.buttonOui.Text = "Oui";
            this.buttonOui.UseVisualStyleBackColor = true;
            this.buttonOui.Click += new System.EventHandler(this.buttonOui_Click);
            // 
            // Confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 253);
            this.Controls.Add(this.buttonOui);
            this.Controls.Add(this.buttonNon);
            this.Controls.Add(this.labelConfirm);
            this.Name = "Confirm";
            this.Text = "Confirm";
            this.Load += new System.EventHandler(this.Confirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConfirm;
        private System.Windows.Forms.Button buttonNon;
        private System.Windows.Forms.Button buttonOui;
    }
}