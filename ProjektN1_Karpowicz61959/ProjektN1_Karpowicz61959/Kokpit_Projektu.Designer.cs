namespace ProjektN1_Karpowicz61959
{
    partial class Kokpit_Projektu
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
            this.btnLaboratorium = new System.Windows.Forms.Button();
            this.btnProjekt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLaboratorium
            // 
            this.btnLaboratorium.Location = new System.Drawing.Point(93, 227);
            this.btnLaboratorium.Name = "btnLaboratorium";
            this.btnLaboratorium.Size = new System.Drawing.Size(75, 23);
            this.btnLaboratorium.TabIndex = 0;
            this.btnLaboratorium.Text = "button1";
            this.btnLaboratorium.UseVisualStyleBackColor = true;
            this.btnLaboratorium.Click += new System.EventHandler(this.btnLaboratorium_Click);
            // 
            // btnProjekt
            // 
            this.btnProjekt.Location = new System.Drawing.Point(519, 226);
            this.btnProjekt.Name = "btnProjekt";
            this.btnProjekt.Size = new System.Drawing.Size(75, 23);
            this.btnProjekt.TabIndex = 1;
            this.btnProjekt.Text = "button2";
            this.btnProjekt.UseVisualStyleBackColor = true;
            this.btnProjekt.Click += new System.EventHandler(this.btnProjekt_Click);
            // 
            // Kokpit_Projektu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProjekt);
            this.Controls.Add(this.btnLaboratorium);
            this.Name = "Kokpit_Projektu";
            this.Text = "Kokpit_Projektu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kokpit_Projektu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLaboratorium;
        private System.Windows.Forms.Button btnProjekt;
    }
}