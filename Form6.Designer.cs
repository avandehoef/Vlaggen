namespace Vlaggen
{
    partial class alleVlaggen5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alleVlaggen5));
            this.btnSluit = new System.Windows.Forms.Button();
            this.btnVorigScherm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSluit
            // 
            this.btnSluit.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnSluit.Location = new System.Drawing.Point(1247, 790);
            this.btnSluit.Name = "btnSluit";
            this.btnSluit.Size = new System.Drawing.Size(125, 42);
            this.btnSluit.TabIndex = 107;
            this.btnSluit.Text = "Venster sluiten";
            this.btnSluit.UseVisualStyleBackColor = true;
            this.btnSluit.Click += new System.EventHandler(this.btnSluit_Click);
            // 
            // btnVorigScherm
            // 
            this.btnVorigScherm.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnVorigScherm.Location = new System.Drawing.Point(913, 790);
            this.btnVorigScherm.Name = "btnVorigScherm";
            this.btnVorigScherm.Size = new System.Drawing.Size(150, 42);
            this.btnVorigScherm.TabIndex = 109;
            this.btnVorigScherm.Text = "Vorige scherm";
            this.btnVorigScherm.UseVisualStyleBackColor = true;
            this.btnVorigScherm.Click += new System.EventHandler(this.btnVorigScherm_Click);
            // 
            // alleVlaggen5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1408, 844);
            this.Controls.Add(this.btnVorigScherm);
            this.Controls.Add(this.btnSluit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "alleVlaggen5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alle vlaggen (5/5)";
            this.Load += new System.EventHandler(this.alleVlaggen5_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSluit;
        private System.Windows.Forms.Button btnVorigScherm;
    }
}