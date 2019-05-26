namespace Ezberimde
{
    partial class FormCalismaAlani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalismaAlani));
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnGec = new System.Windows.Forms.Button();
            this.btnDur = new System.Windows.Forms.Button();
            this.txtIng = new System.Windows.Forms.TextBox();
            this.txtTr = new System.Windows.Forms.TextBox();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnOku = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIndir = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.btnBasla.FlatAppearance.BorderSize = 0;
            this.btnBasla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasla.Image = ((System.Drawing.Image)(resources.GetObject("btnBasla.Image")));
            this.btnBasla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBasla.Location = new System.Drawing.Point(37, 313);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(115, 50);
            this.btnBasla.TabIndex = 2;
            this.btnBasla.Text = "Başla";
            this.btnBasla.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnGec
            // 
            this.btnGec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnGec.FlatAppearance.BorderSize = 0;
            this.btnGec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGec.Image = ((System.Drawing.Image)(resources.GetObject("btnGec.Image")));
            this.btnGec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGec.Location = new System.Drawing.Point(178, 264);
            this.btnGec.Name = "btnGec";
            this.btnGec.Size = new System.Drawing.Size(115, 50);
            this.btnGec.TabIndex = 3;
            this.btnGec.Text = "Geç";
            this.btnGec.UseVisualStyleBackColor = false;
            this.btnGec.Click += new System.EventHandler(this.btnGec_Click);
            // 
            // btnDur
            // 
            this.btnDur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDur.FlatAppearance.BorderSize = 0;
            this.btnDur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDur.Image = ((System.Drawing.Image)(resources.GetObject("btnDur.Image")));
            this.btnDur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDur.Location = new System.Drawing.Point(312, 313);
            this.btnDur.Name = "btnDur";
            this.btnDur.Size = new System.Drawing.Size(115, 50);
            this.btnDur.TabIndex = 4;
            this.btnDur.Text = "Bitir";
            this.btnDur.UseVisualStyleBackColor = false;
            this.btnDur.Click += new System.EventHandler(this.btnDur_Click);
            // 
            // txtIng
            // 
            this.txtIng.Enabled = false;
            this.txtIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIng.Location = new System.Drawing.Point(166, 101);
            this.txtIng.Name = "txtIng";
            this.txtIng.Size = new System.Drawing.Size(142, 22);
            this.txtIng.TabIndex = 6;
            this.txtIng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTr
            // 
            this.txtTr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTr.Location = new System.Drawing.Point(166, 147);
            this.txtTr.Name = "txtTr";
            this.txtTr.Size = new System.Drawing.Size(142, 22);
            this.txtTr.TabIndex = 7;
            this.txtTr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnKontrol
            // 
            this.btnKontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(166)))));
            this.btnKontrol.FlatAppearance.BorderSize = 0;
            this.btnKontrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKontrol.Image = ((System.Drawing.Image)(resources.GetObject("btnKontrol.Image")));
            this.btnKontrol.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnKontrol.Location = new System.Drawing.Point(178, 208);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnKontrol.Size = new System.Drawing.Size(115, 50);
            this.btnKontrol.TabIndex = 8;
            this.btnKontrol.Text = "Kontrol Et";
            this.btnKontrol.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnKontrol.UseVisualStyleBackColor = false;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnOku
            // 
            this.btnOku.FlatAppearance.BorderSize = 0;
            this.btnOku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOku.Image = ((System.Drawing.Image)(resources.GetObject("btnOku.Image")));
            this.btnOku.Location = new System.Drawing.Point(215, 45);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(50, 50);
            this.btnOku.TabIndex = 9;
            this.btnOku.UseVisualStyleBackColor = false;
            this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnIndir);
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 39);
            this.panel1.TabIndex = 10;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormCalismaAlani_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormCalismaAlani_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ezberimde";
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
            // FormCalismaAlani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(480, 402);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOku);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.txtTr);
            this.Controls.Add(this.txtIng);
            this.Controls.Add(this.btnDur);
            this.Controls.Add(this.btnGec);
            this.Controls.Add(this.btnBasla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCalismaAlani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışma Alanı";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormCalismaAlani_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormCalismaAlani_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnGec;
        private System.Windows.Forms.Button btnDur;
        private System.Windows.Forms.TextBox txtIng;
        private System.Windows.Forms.TextBox txtTr;
        private System.Windows.Forms.Button btnKontrol;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnOku;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnIndir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}