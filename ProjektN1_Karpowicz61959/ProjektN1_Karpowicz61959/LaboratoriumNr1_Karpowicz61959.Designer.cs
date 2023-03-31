namespace ProjektN1_Karpowicz61959
{
    partial class LaboratoriumNr1_Karpowicz61959
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtXd = new System.Windows.Forms.TextBox();
            this.txtXg = new System.Windows.Forms.TextBox();
            this.txth = new System.Windows.Forms.TextBox();
            this.pbRysownica = new System.Windows.Forms.PictureBox();
            this.btnAnimacja = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koloryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrybutyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kształtObiektuAnimowanegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Przedział wartości zmiennej niezależnej X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(379, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Xd:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(480, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xg:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(593, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "h:";
            // 
            // txtXd
            // 
            this.txtXd.Location = new System.Drawing.Point(415, 31);
            this.txtXd.Name = "txtXd";
            this.txtXd.Size = new System.Drawing.Size(49, 22);
            this.txtXd.TabIndex = 4;
            this.txtXd.TextChanged += new System.EventHandler(this.txtXd_TextChanged);
            // 
            // txtXg
            // 
            this.txtXg.Location = new System.Drawing.Point(525, 32);
            this.txtXg.Name = "txtXg";
            this.txtXg.Size = new System.Drawing.Size(49, 22);
            this.txtXg.TabIndex = 5;
            this.txtXg.TextChanged += new System.EventHandler(this.txtXg_TextChanged);
            // 
            // txth
            // 
            this.txth.Location = new System.Drawing.Point(614, 33);
            this.txth.Name = "txth";
            this.txth.Size = new System.Drawing.Size(49, 22);
            this.txth.TabIndex = 6;
            this.txth.TextChanged += new System.EventHandler(this.txth_TextChanged);
            // 
            // pbRysownica
            // 
            this.pbRysownica.Location = new System.Drawing.Point(16, 75);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(665, 394);
            this.pbRysownica.TabIndex = 7;
            this.pbRysownica.TabStop = false;
            this.pbRysownica.Paint += new System.Windows.Forms.PaintEventHandler(this.pbRysownica_Paint);
            // 
            // btnAnimacja
            // 
            this.btnAnimacja.Location = new System.Drawing.Point(699, 75);
            this.btnAnimacja.Name = "btnAnimacja";
            this.btnAnimacja.Size = new System.Drawing.Size(137, 71);
            this.btnAnimacja.TabIndex = 8;
            this.btnAnimacja.Text = "Animacja po linii toru\r\n(wyznaczonej przez szereg potęgowy)";
            this.btnAnimacja.UseVisualStyleBackColor = true;
            this.btnAnimacja.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.koloryToolStripMenuItem,
            this.atrybutyToolStripMenuItem,
            this.kształtObiektuAnimowanegoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // koloryToolStripMenuItem
            // 
            this.koloryToolStripMenuItem.Name = "koloryToolStripMenuItem";
            this.koloryToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.koloryToolStripMenuItem.Text = "Kolory";
            // 
            // atrybutyToolStripMenuItem
            // 
            this.atrybutyToolStripMenuItem.Name = "atrybutyToolStripMenuItem";
            this.atrybutyToolStripMenuItem.Size = new System.Drawing.Size(299, 24);
            this.atrybutyToolStripMenuItem.Text = "Atrybuty linii toru i obiektu animowanego";
            // 
            // kształtObiektuAnimowanegoToolStripMenuItem
            // 
            this.kształtObiektuAnimowanegoToolStripMenuItem.Name = "kształtObiektuAnimowanegoToolStripMenuItem";
            this.kształtObiektuAnimowanegoToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.kształtObiektuAnimowanegoToolStripMenuItem.Text = "Kształt obiektu animowanego";
            // 
            // LaboratoriumNr1_Karpowicz61959
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 513);
            this.Controls.Add(this.btnAnimacja);
            this.Controls.Add(this.pbRysownica);
            this.Controls.Add(this.txth);
            this.Controls.Add(this.txtXg);
            this.Controls.Add(this.txtXd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LaboratoriumNr1_Karpowicz61959";
            this.Text = "LaboratoriumNr1_Karpowicz61959";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LaboratoriumNr1_Karpowicz61959_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnAnimacja;
        private System.Windows.Forms.PictureBox pbRysownica;
        private System.Windows.Forms.TextBox txth;
        private System.Windows.Forms.TextBox txtXg;
        private System.Windows.Forms.TextBox txtXd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koloryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrybutyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kształtObiektuAnimowanegoToolStripMenuItem;
    }
}