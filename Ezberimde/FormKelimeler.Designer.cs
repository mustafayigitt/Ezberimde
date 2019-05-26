namespace Ezberimde
{
    partial class FormKelimeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKelimeler));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kelimelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBEzberimdeDataSet = new Ezberimde.DBEzberimdeDataSet();
            this.kelimelerTableAdapter = new Ezberimde.DBEzberimdeDataSetTableAdapters.KelimelerTableAdapter();
            this.panelButon = new System.Windows.Forms.Panel();
            this.btnGoster = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.panelEkle = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkleOnay = new System.Windows.Forms.Button();
            this.btnEkleIptal = new System.Windows.Forms.Button();
            this.txtEkleCumle = new System.Windows.Forms.TextBox();
            this.txtEkleAnlam = new System.Windows.Forms.TextBox();
            this.txtEkleTur = new System.Windows.Forms.TextBox();
            this.txtEkleAd = new System.Windows.Forms.TextBox();
            this.lblArama = new System.Windows.Forms.Label();
            this.panelArama = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAramaOnay = new System.Windows.Forms.Button();
            this.btnAramaIptal = new System.Windows.Forms.Button();
            this.txtAramaAnlam = new System.Windows.Forms.TextBox();
            this.txtAramaTur = new System.Windows.Forms.TextBox();
            this.txtAramaAd = new System.Windows.Forms.TextBox();
            this.panelGuncelle = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGuncelleCumle = new System.Windows.Forms.TextBox();
            this.txtGuncelleAnlam = new System.Windows.Forms.TextBox();
            this.txtGuncelleTur = new System.Windows.Forms.TextBox();
            this.txtGuncelleAd = new System.Windows.Forms.TextBox();
            this.btnGuncelleOnay = new System.Windows.Forms.Button();
            this.btnGuncelleIptal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panelSil = new System.Windows.Forms.Panel();
            this.btnSilOnay = new System.Windows.Forms.Button();
            this.btnSilIptal = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIndir = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.dbEzberimdeDataSet1 = new Ezberimde.DBEzberimdeDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBEzberimdeDataSet)).BeginInit();
            this.panelButon.SuspendLayout();
            this.panelEkle.SuspendLayout();
            this.panelArama.SuspendLayout();
            this.panelGuncelle.SuspendLayout();
            this.panelSil.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEzberimdeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1,
            this.tarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kelimelerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(920, 241);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormKelimeler_MouseDown);
            this.dataGridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormKelimeler_MouseMove);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tür";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tür";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Anlam";
            this.dataGridViewTextBoxColumn4.HeaderText = "Anlam";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cümle";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cümle";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "EzberDurum";
            this.dataGridViewCheckBoxColumn1.HeaderText = "EzberDurum";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 85;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            this.tarihDataGridViewTextBoxColumn.Width = 127;
            // 
            // kelimelerBindingSource
            // 
            this.kelimelerBindingSource.DataMember = "Kelimeler";
            this.kelimelerBindingSource.DataSource = this.dBEzberimdeDataSet;
            // 
            // dBEzberimdeDataSet
            // 
            this.dBEzberimdeDataSet.DataSetName = "DBEzberimdeDataSet";
            this.dBEzberimdeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kelimelerTableAdapter
            // 
            this.kelimelerTableAdapter.ClearBeforeFill = true;
            // 
            // panelButon
            // 
            this.panelButon.Controls.Add(this.btnGoster);
            this.panelButon.Controls.Add(this.btnSil);
            this.panelButon.Controls.Add(this.btnGuncelle);
            this.panelButon.Controls.Add(this.btnAra);
            this.panelButon.Controls.Add(this.btnEkle);
            this.panelButon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButon.Location = new System.Drawing.Point(0, 505);
            this.panelButon.Name = "panelButon";
            this.panelButon.Size = new System.Drawing.Size(921, 64);
            this.panelButon.TabIndex = 1;
            this.panelButon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormKelimeler_MouseDown);
            this.panelButon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormKelimeler_MouseMove);
            // 
            // btnGoster
            // 
            this.btnGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnGoster.FlatAppearance.BorderSize = 0;
            this.btnGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoster.Image = ((System.Drawing.Image)(resources.GetObject("btnGoster.Image")));
            this.btnGoster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoster.Location = new System.Drawing.Point(71, 8);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(155, 50);
            this.btnGoster.TabIndex = 6;
            this.btnGoster.Text = "Listele";
            this.btnGoster.UseVisualStyleBackColor = false;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.Location = new System.Drawing.Point(690, 8);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(155, 50);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.Location = new System.Drawing.Point(536, 8);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(155, 50);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(166)))));
            this.btnAra.FlatAppearance.BorderSize = 0;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Image = ((System.Drawing.Image)(resources.GetObject("btnAra.Image")));
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.Location = new System.Drawing.Point(381, 8);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(155, 50);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.Location = new System.Drawing.Point(226, 8);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(155, 50);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // panelEkle
            // 
            this.panelEkle.Controls.Add(this.label14);
            this.panelEkle.Controls.Add(this.label4);
            this.panelEkle.Controls.Add(this.label3);
            this.panelEkle.Controls.Add(this.label2);
            this.panelEkle.Controls.Add(this.label1);
            this.panelEkle.Controls.Add(this.btnEkleOnay);
            this.panelEkle.Controls.Add(this.btnEkleIptal);
            this.panelEkle.Controls.Add(this.txtEkleCumle);
            this.panelEkle.Controls.Add(this.txtEkleAnlam);
            this.panelEkle.Controls.Add(this.txtEkleTur);
            this.panelEkle.Controls.Add(this.txtEkleAd);
            this.panelEkle.Location = new System.Drawing.Point(231, 93);
            this.panelEkle.Name = "panelEkle";
            this.panelEkle.Size = new System.Drawing.Size(426, 280);
            this.panelEkle.TabIndex = 2;
            this.panelEkle.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(65, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(315, 16);
            this.label14.TabIndex = 20;
            this.label14.Text = "Eklemek istediğiniz kaydın parametlerini doldurunuz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(75, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cümle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(75, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Anlam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(93, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tür";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(96, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ad";
            // 
            // btnEkleOnay
            // 
            this.btnEkleOnay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.btnEkleOnay.FlatAppearance.BorderSize = 0;
            this.btnEkleOnay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkleOnay.Location = new System.Drawing.Point(264, 226);
            this.btnEkleOnay.Name = "btnEkleOnay";
            this.btnEkleOnay.Size = new System.Drawing.Size(79, 46);
            this.btnEkleOnay.TabIndex = 14;
            this.btnEkleOnay.Text = "✓";
            this.btnEkleOnay.UseVisualStyleBackColor = false;
            this.btnEkleOnay.Click += new System.EventHandler(this.btnEkleOnay_Click);
            // 
            // btnEkleIptal
            // 
            this.btnEkleIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnEkleIptal.FlatAppearance.BorderSize = 0;
            this.btnEkleIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkleIptal.Location = new System.Drawing.Point(89, 226);
            this.btnEkleIptal.Name = "btnEkleIptal";
            this.btnEkleIptal.Size = new System.Drawing.Size(79, 46);
            this.btnEkleIptal.TabIndex = 13;
            this.btnEkleIptal.Text = "X";
            this.btnEkleIptal.UseVisualStyleBackColor = false;
            this.btnEkleIptal.Click += new System.EventHandler(this.btnEkleIptal_Click);
            // 
            // txtEkleCumle
            // 
            this.txtEkleCumle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEkleCumle.Location = new System.Drawing.Point(121, 151);
            this.txtEkleCumle.Multiline = true;
            this.txtEkleCumle.Name = "txtEkleCumle";
            this.txtEkleCumle.Size = new System.Drawing.Size(211, 61);
            this.txtEkleCumle.TabIndex = 12;
            // 
            // txtEkleAnlam
            // 
            this.txtEkleAnlam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEkleAnlam.Location = new System.Drawing.Point(121, 113);
            this.txtEkleAnlam.Name = "txtEkleAnlam";
            this.txtEkleAnlam.Size = new System.Drawing.Size(211, 22);
            this.txtEkleAnlam.TabIndex = 10;
            // 
            // txtEkleTur
            // 
            this.txtEkleTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEkleTur.Location = new System.Drawing.Point(121, 75);
            this.txtEkleTur.Name = "txtEkleTur";
            this.txtEkleTur.Size = new System.Drawing.Size(211, 22);
            this.txtEkleTur.TabIndex = 9;
            // 
            // txtEkleAd
            // 
            this.txtEkleAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEkleAd.Location = new System.Drawing.Point(121, 37);
            this.txtEkleAd.Name = "txtEkleAd";
            this.txtEkleAd.Size = new System.Drawing.Size(211, 22);
            this.txtEkleAd.TabIndex = 8;
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblArama.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblArama.Location = new System.Drawing.Point(134, 26);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(260, 16);
            this.lblArama.TabIndex = 19;
            this.lblArama.Text = "Aramak istediğiniz parametreyi doldurunuz";
            // 
            // panelArama
            // 
            this.panelArama.Controls.Add(this.label6);
            this.panelArama.Controls.Add(this.label7);
            this.panelArama.Controls.Add(this.label8);
            this.panelArama.Controls.Add(this.btnAramaOnay);
            this.panelArama.Controls.Add(this.btnAramaIptal);
            this.panelArama.Controls.Add(this.txtAramaAnlam);
            this.panelArama.Controls.Add(this.txtAramaTur);
            this.panelArama.Controls.Add(this.txtAramaAd);
            this.panelArama.Controls.Add(this.lblArama);
            this.panelArama.Location = new System.Drawing.Point(181, 122);
            this.panelArama.Name = "panelArama";
            this.panelArama.Size = new System.Drawing.Size(518, 237);
            this.panelArama.TabIndex = 19;
            this.panelArama.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(123, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Anlam";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(141, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Tür";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(144, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Ad";
            // 
            // btnAramaOnay
            // 
            this.btnAramaOnay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.btnAramaOnay.FlatAppearance.BorderSize = 0;
            this.btnAramaOnay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAramaOnay.Location = new System.Drawing.Point(318, 182);
            this.btnAramaOnay.Name = "btnAramaOnay";
            this.btnAramaOnay.Size = new System.Drawing.Size(79, 46);
            this.btnAramaOnay.TabIndex = 25;
            this.btnAramaOnay.Text = "✓";
            this.btnAramaOnay.UseVisualStyleBackColor = false;
            this.btnAramaOnay.Click += new System.EventHandler(this.btnAramaOnay_Click);
            // 
            // btnAramaIptal
            // 
            this.btnAramaIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnAramaIptal.FlatAppearance.BorderSize = 0;
            this.btnAramaIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAramaIptal.Location = new System.Drawing.Point(143, 182);
            this.btnAramaIptal.Name = "btnAramaIptal";
            this.btnAramaIptal.Size = new System.Drawing.Size(79, 46);
            this.btnAramaIptal.TabIndex = 24;
            this.btnAramaIptal.Text = "X";
            this.btnAramaIptal.UseVisualStyleBackColor = false;
            this.btnAramaIptal.Click += new System.EventHandler(this.btnAramaIptal_Click);
            // 
            // txtAramaAnlam
            // 
            this.txtAramaAnlam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAramaAnlam.Location = new System.Drawing.Point(169, 130);
            this.txtAramaAnlam.Name = "txtAramaAnlam";
            this.txtAramaAnlam.Size = new System.Drawing.Size(211, 22);
            this.txtAramaAnlam.TabIndex = 22;
            // 
            // txtAramaTur
            // 
            this.txtAramaTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAramaTur.Location = new System.Drawing.Point(169, 92);
            this.txtAramaTur.Name = "txtAramaTur";
            this.txtAramaTur.Size = new System.Drawing.Size(211, 22);
            this.txtAramaTur.TabIndex = 21;
            // 
            // txtAramaAd
            // 
            this.txtAramaAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAramaAd.Location = new System.Drawing.Point(169, 54);
            this.txtAramaAd.Name = "txtAramaAd";
            this.txtAramaAd.Size = new System.Drawing.Size(211, 22);
            this.txtAramaAd.TabIndex = 20;
            // 
            // panelGuncelle
            // 
            this.panelGuncelle.Controls.Add(this.label9);
            this.panelGuncelle.Controls.Add(this.label10);
            this.panelGuncelle.Controls.Add(this.label11);
            this.panelGuncelle.Controls.Add(this.label12);
            this.panelGuncelle.Controls.Add(this.txtGuncelleCumle);
            this.panelGuncelle.Controls.Add(this.txtGuncelleAnlam);
            this.panelGuncelle.Controls.Add(this.txtGuncelleTur);
            this.panelGuncelle.Controls.Add(this.txtGuncelleAd);
            this.panelGuncelle.Controls.Add(this.btnGuncelleOnay);
            this.panelGuncelle.Controls.Add(this.btnGuncelleIptal);
            this.panelGuncelle.Controls.Add(this.label5);
            this.panelGuncelle.Location = new System.Drawing.Point(169, 280);
            this.panelGuncelle.Name = "panelGuncelle";
            this.panelGuncelle.Size = new System.Drawing.Size(580, 227);
            this.panelGuncelle.TabIndex = 29;
            this.panelGuncelle.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(144, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Cümle";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(144, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 33;
            this.label10.Text = "Anlam";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(162, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 16);
            this.label11.TabIndex = 32;
            this.label11.Text = "Tür";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(165, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 16);
            this.label12.TabIndex = 31;
            this.label12.Text = "Ad";
            // 
            // txtGuncelleCumle
            // 
            this.txtGuncelleCumle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuncelleCumle.Location = new System.Drawing.Point(190, 137);
            this.txtGuncelleCumle.Multiline = true;
            this.txtGuncelleCumle.Name = "txtGuncelleCumle";
            this.txtGuncelleCumle.Size = new System.Drawing.Size(211, 42);
            this.txtGuncelleCumle.TabIndex = 30;
            // 
            // txtGuncelleAnlam
            // 
            this.txtGuncelleAnlam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuncelleAnlam.Location = new System.Drawing.Point(190, 99);
            this.txtGuncelleAnlam.Name = "txtGuncelleAnlam";
            this.txtGuncelleAnlam.Size = new System.Drawing.Size(211, 22);
            this.txtGuncelleAnlam.TabIndex = 29;
            // 
            // txtGuncelleTur
            // 
            this.txtGuncelleTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuncelleTur.Location = new System.Drawing.Point(190, 61);
            this.txtGuncelleTur.Name = "txtGuncelleTur";
            this.txtGuncelleTur.Size = new System.Drawing.Size(211, 22);
            this.txtGuncelleTur.TabIndex = 28;
            // 
            // txtGuncelleAd
            // 
            this.txtGuncelleAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuncelleAd.Location = new System.Drawing.Point(190, 23);
            this.txtGuncelleAd.Name = "txtGuncelleAd";
            this.txtGuncelleAd.Size = new System.Drawing.Size(211, 22);
            this.txtGuncelleAd.TabIndex = 27;
            // 
            // btnGuncelleOnay
            // 
            this.btnGuncelleOnay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.btnGuncelleOnay.FlatAppearance.BorderSize = 0;
            this.btnGuncelleOnay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelleOnay.Location = new System.Drawing.Point(326, 185);
            this.btnGuncelleOnay.Name = "btnGuncelleOnay";
            this.btnGuncelleOnay.Size = new System.Drawing.Size(75, 32);
            this.btnGuncelleOnay.TabIndex = 26;
            this.btnGuncelleOnay.Text = "✓";
            this.btnGuncelleOnay.UseVisualStyleBackColor = false;
            this.btnGuncelleOnay.Click += new System.EventHandler(this.btnGuncelleOnay_Click);
            // 
            // btnGuncelleIptal
            // 
            this.btnGuncelleIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnGuncelleIptal.FlatAppearance.BorderSize = 0;
            this.btnGuncelleIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelleIptal.Location = new System.Drawing.Point(190, 185);
            this.btnGuncelleIptal.Name = "btnGuncelleIptal";
            this.btnGuncelleIptal.Size = new System.Drawing.Size(75, 32);
            this.btnGuncelleIptal.TabIndex = 25;
            this.btnGuncelleIptal.Text = "X";
            this.btnGuncelleIptal.UseVisualStyleBackColor = false;
            this.btnGuncelleIptal.Click += new System.EventHandler(this.btnGuncelleIptal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(171, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Güncellemek istediğiniz kelimeyi seçiniz";
            // 
            // panelSil
            // 
            this.panelSil.Controls.Add(this.btnSilOnay);
            this.panelSil.Controls.Add(this.btnSilIptal);
            this.panelSil.Controls.Add(this.label13);
            this.panelSil.Location = new System.Drawing.Point(84, 342);
            this.panelSil.Name = "panelSil";
            this.panelSil.Size = new System.Drawing.Size(682, 100);
            this.panelSil.TabIndex = 30;
            this.panelSil.Visible = false;
            // 
            // btnSilOnay
            // 
            this.btnSilOnay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.btnSilOnay.FlatAppearance.BorderSize = 0;
            this.btnSilOnay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSilOnay.Location = new System.Drawing.Point(366, 52);
            this.btnSilOnay.Name = "btnSilOnay";
            this.btnSilOnay.Size = new System.Drawing.Size(75, 32);
            this.btnSilOnay.TabIndex = 28;
            this.btnSilOnay.Text = "✓";
            this.btnSilOnay.UseVisualStyleBackColor = false;
            this.btnSilOnay.Click += new System.EventHandler(this.btnSilOnay_Click);
            // 
            // btnSilIptal
            // 
            this.btnSilIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnSilIptal.FlatAppearance.BorderSize = 0;
            this.btnSilIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSilIptal.Location = new System.Drawing.Point(236, 52);
            this.btnSilIptal.Name = "btnSilIptal";
            this.btnSilIptal.Size = new System.Drawing.Size(75, 32);
            this.btnSilIptal.TabIndex = 27;
            this.btnSilIptal.Text = "X";
            this.btnSilIptal.UseVisualStyleBackColor = false;
            this.btnSilIptal.Click += new System.EventHandler(this.btnSilIptal_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(233, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(208, 16);
            this.label13.TabIndex = 20;
            this.label13.Text = "Silmek istediğiniz kelimeyi seçiniz";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnIndir);
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 39);
            this.panel1.TabIndex = 31;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormKelimeler_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormKelimeler_MouseMove);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.label15.Location = new System.Drawing.Point(57, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "Ezberimde";
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
            this.btnIndir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIndir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.btnIndir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIndir.FlatAppearance.BorderSize = 0;
            this.btnIndir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndir.Image = ((System.Drawing.Image)(resources.GetObject("btnIndir.Image")));
            this.btnIndir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIndir.Location = new System.Drawing.Point(846, 10);
            this.btnIndir.Name = "btnIndir";
            this.btnIndir.Size = new System.Drawing.Size(20, 20);
            this.btnIndir.TabIndex = 1;
            this.btnIndir.UseVisualStyleBackColor = false;
            this.btnIndir.Click += new System.EventHandler(this.btnIndir_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.Location = new System.Drawing.Point(878, 10);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(20, 20);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // dbEzberimdeDataSet1
            // 
            this.dbEzberimdeDataSet1.DataSetName = "DBEzberimdeDataSet";
            this.dbEzberimdeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormKelimeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(921, 569);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelButon);
            this.Controls.Add(this.panelSil);
            this.Controls.Add(this.panelGuncelle);
            this.Controls.Add(this.panelArama);
            this.Controls.Add(this.panelEkle);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKelimeler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime Deposu";
            this.Load += new System.EventHandler(this.FormKelimeler_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormKelimeler_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormKelimeler_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBEzberimdeDataSet)).EndInit();
            this.panelButon.ResumeLayout(false);
            this.panelEkle.ResumeLayout(false);
            this.panelEkle.PerformLayout();
            this.panelArama.ResumeLayout(false);
            this.panelArama.PerformLayout();
            this.panelGuncelle.ResumeLayout(false);
            this.panelGuncelle.PerformLayout();
            this.panelSil.ResumeLayout(false);
            this.panelSil.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEzberimdeDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DBEzberimdeDataSet dBEzberimdeDataSet;
        private System.Windows.Forms.BindingSource kelimelerBindingSource;
        private DBEzberimdeDataSetTableAdapters.KelimelerTableAdapter kelimelerTableAdapter;
        private System.Windows.Forms.Panel panelButon;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Panel panelEkle;
        private System.Windows.Forms.Button btnEkleOnay;
        private System.Windows.Forms.Button btnEkleIptal;
        private System.Windows.Forms.TextBox txtEkleCumle;
        private System.Windows.Forms.TextBox txtEkleAnlam;
        private System.Windows.Forms.TextBox txtEkleTur;
        private System.Windows.Forms.TextBox txtEkleAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn türDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anlamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cümleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ezberDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.Panel panelArama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAramaOnay;
        private System.Windows.Forms.Button btnAramaIptal;
        private System.Windows.Forms.TextBox txtAramaAnlam;
        private System.Windows.Forms.TextBox txtAramaTur;
        private System.Windows.Forms.TextBox txtAramaAd;
        private System.Windows.Forms.Panel panelGuncelle;
        private System.Windows.Forms.Button btnGuncelleOnay;
        private System.Windows.Forms.Button btnGuncelleIptal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGuncelleCumle;
        private System.Windows.Forms.TextBox txtGuncelleAnlam;
        private System.Windows.Forms.TextBox txtGuncelleTur;
        private System.Windows.Forms.TextBox txtGuncelleAd;
        private System.Windows.Forms.Panel panelSil;
        private System.Windows.Forms.Button btnSilOnay;
        private System.Windows.Forms.Button btnSilIptal;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIndir;
        private System.Windows.Forms.Button btnKapat;
        private DBEzberimdeDataSet dbEzberimdeDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
    }
}