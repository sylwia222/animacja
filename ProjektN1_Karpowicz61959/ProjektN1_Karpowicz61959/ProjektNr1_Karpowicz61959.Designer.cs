namespace ProjektN1_Karpowicz61959
{
    partial class ProjektNr1_Karpowicz61959
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.SKbtnAnimacja = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SKtxtXd = new System.Windows.Forms.TextBox();
            this.SKtxtXg = new System.Windows.Forms.TextBox();
            this.SKtxth = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.SKpbRysownica = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SKpbRysownica)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Przedział wartości zmiennej niezależnej X:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SKbtnAnimacja
            // 
            this.SKbtnAnimacja.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SKbtnAnimacja.Location = new System.Drawing.Point(769, 97);
            this.SKbtnAnimacja.Name = "SKbtnAnimacja";
            this.SKbtnAnimacja.Size = new System.Drawing.Size(144, 79);
            this.SKbtnAnimacja.TabIndex = 1;
            this.SKbtnAnimacja.Text = "Animacja po linii toru\r\n(wyznaczonej przez szereg potęgowy)\r\n";
            this.SKbtnAnimacja.UseVisualStyleBackColor = true;
            this.SKbtnAnimacja.Click += new System.EventHandler(this.SKbtnAnimacja_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(396, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Xd:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(502, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Xg:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(622, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "h:";
            // 
            // SKtxtXd
            // 
            this.SKtxtXd.Location = new System.Drawing.Point(433, 36);
            this.SKtxtXd.Name = "SKtxtXd";
            this.SKtxtXd.Size = new System.Drawing.Size(53, 22);
            this.SKtxtXd.TabIndex = 5;
            // 
            // SKtxtXg
            // 
            this.SKtxtXg.Location = new System.Drawing.Point(548, 35);
            this.SKtxtXg.Name = "SKtxtXg";
            this.SKtxtXg.Size = new System.Drawing.Size(58, 22);
            this.SKtxtXg.TabIndex = 6;
            // 
            // SKtxth
            // 
            this.SKtxth.Location = new System.Drawing.Point(653, 35);
            this.SKtxth.Name = "SKtxth";
            this.SKtxth.Size = new System.Drawing.Size(58, 22);
            this.SKtxth.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SKpbRysownica
            // 
            this.SKpbRysownica.Location = new System.Drawing.Point(27, 82);
            this.SKpbRysownica.Name = "SKpbRysownica";
            this.SKpbRysownica.Size = new System.Drawing.Size(706, 415);
            this.SKpbRysownica.TabIndex = 8;
            this.SKpbRysownica.TabStop = false;
            this.SKpbRysownica.Paint += new System.Windows.Forms.PaintEventHandler(this.SKpbRysownica_Paint);
            // 
            // ProjektNr1_Karpowicz61959
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 539);
            this.Controls.Add(this.SKpbRysownica);
            this.Controls.Add(this.SKtxth);
            this.Controls.Add(this.SKtxtXg);
            this.Controls.Add(this.SKtxtXd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SKbtnAnimacja);
            this.Controls.Add(this.label1);
            this.Name = "ProjektNr1_Karpowicz61959";
            this.Text = "ProjektNr1_Karpowicz61959";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProjektNr1_Karpowicz61959_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SKpbRysownica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SKbtnAnimacja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SKtxtXd;
        private System.Windows.Forms.TextBox SKtxtXg;
        private System.Windows.Forms.TextBox SKtxth;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox SKpbRysownica;
    }
}