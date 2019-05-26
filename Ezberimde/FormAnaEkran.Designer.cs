namespace Ezberimde
{
    partial class FormAnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnaEkran));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalismaAlani = new System.Windows.Forms.Button();
            this.btnKelimeDeposu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIndir = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnIstatistikler = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.label1.Location = new System.Drawing.Point(92, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ezberimde Dünyasına \r\n Hoşgeldiniz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormAnaEkran_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormAnaEkran_MouseMove);
            // 
            // btnCalismaAlani
            // 
            this.btnCalismaAlani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnCalismaAlani.FlatAppearance.BorderSize = 0;
            this.btnCalismaAlani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalismaAlani.Image = ((System.Drawing.Image)(resources.GetObject("btnCalismaAlani.Image")));
            this.btnCalismaAlani.Location = new System.Drawing.Point(92, 248);
            this.btnCalismaAlani.Name = "btnCalismaAlani";
            this.btnCalismaAlani.Size = new System.Drawing.Size(115, 50);
            this.btnCalismaAlani.TabIndex = 1;
            this.btnCalismaAlani.Text = "Çalışma Alanı";
            this.btnCalismaAlani.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalismaAlani.UseVisualStyleBackColor = false;
            this.btnCalismaAlani.Click += new System.EventHandler(this.btnCalismaAlani_Click);
            // 
            // btnKelimeDeposu
            // 
            this.btnKelimeDeposu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnKelimeDeposu.FlatAppearance.BorderSize = 0;
            this.btnKelimeDeposu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKelimeDeposu.Image = ((System.Drawing.Image)(resources.GetObject("btnKelimeDeposu.Image")));
            this.btnKelimeDeposu.Location = new System.Drawing.Point(265, 248);
            this.btnKelimeDeposu.Name = "btnKelimeDeposu";
            this.btnKelimeDeposu.Size = new System.Drawing.Size(115, 50);
            this.btnKelimeDeposu.TabIndex = 2;
            this.btnKelimeDeposu.Text = "Kelime Deposu";
            this.btnKelimeDeposu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKelimeDeposu.UseVisualStyleBackColor = false;
            this.btnKelimeDeposu.Click += new System.EventHandler(this.btnKelimeDeposu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnIndir);
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 39);
            this.panel1.TabIndex = 11;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormAnaEkran_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormAnaEkran_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.label2.Location = new System.Drawing.Point(57, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ezberimde";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnIndir
            // 
            this.btnIndir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.btnIndir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIndir.FlatAppearance.BorderSize = 0;
            this.btnIndir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndir.Image = ((System.Drawing.Image)(resources.GetObject("btnIndir.Image")));
            this.btnIndir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIndir.Location = new System.Drawing.Point(398, 7);
            this.btnIndir.Name = "btnIndir";
            this.btnIndir.Size = new System.Drawing.Size(20, 20);
            this.btnIndir.TabIndex = 1;
            this.btnIndir.UseVisualStyleBackColor = false;
            this.btnIndir.Click += new System.EventHandler(this.btnIndir_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.Location = new System.Drawing.Point(448, 7);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(20, 20);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnIstatistikler
            // 
            this.btnIstatistikler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnIstatistikler.FlatAppearance.BorderSize = 0;
            this.btnIstatistikler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIstatistikler.Image = ((System.Drawing.Image)(resources.GetObject("btnIstatistikler.Image")));
            this.btnIstatistikler.Location = new System.Drawing.Point(179, 319);
            this.btnIstatistikler.Name = "btnIstatistikler";
            this.btnIstatistikler.Size = new System.Drawing.Size(115, 50);
            this.btnIstatistikler.TabIndex = 12;
            this.btnIstatistikler.Text = "İstatistikler";
            this.btnIstatistikler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIstatistikler.UseVisualStyleBackColor = false;
            this.btnIstatistikler.Click += new System.EventHandler(this.btnIstatistikler_Click);
            // 
            // FormAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(480, 402);
            this.Controls.Add(this.btnIstatistikler);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnKelimeDeposu);
            this.Controls.Add(this.btnCalismaAlani);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ezberimde";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormAnaEkran_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormAnaEkran_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalismaAlani;
        private System.Windows.Forms.Button btnKelimeDeposu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIndir;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnIstatistikler;
    }
}

