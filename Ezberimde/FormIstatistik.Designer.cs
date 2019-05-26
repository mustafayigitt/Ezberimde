namespace Ezberimde
{
    partial class FormIstatistik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIstatistik));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIndir = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKapatIstatistik = new System.Windows.Forms.Button();
            this.dBEzberimdeDataSet = new Ezberimde.DBEzberimdeDataSet();
            this.kelimelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kelimelerTableAdapter = new Ezberimde.DBEzberimdeDataSetTableAdapters.KelimelerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBEzberimdeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimelerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            this.chart1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 39);
            this.chart1.Name = "chart1";
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))))};
            series1.BorderWidth = 0;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Ezberlenen Kelimeler";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ShadowOffset = 25;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(831, 387);
            this.chart1.TabIndex = 1;
            title1.Name = "Title1";
            title1.Text = "Ezberlenen Kelimelerin Aylara Göre Dağılımı";
            this.chart1.Titles.Add(title1);
            this.chart1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormIstatistik_MouseDown);
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormIstatistik_MouseMove);
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
            this.panel1.Size = new System.Drawing.Size(831, 39);
            this.panel1.TabIndex = 11;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormIstatistik_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormIstatistik_MouseMove);
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
            this.btnIndir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnIndir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.btnIndir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIndir.FlatAppearance.BorderSize = 0;
            this.btnIndir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndir.Image = ((System.Drawing.Image)(resources.GetObject("btnIndir.Image")));
            this.btnIndir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIndir.Location = new System.Drawing.Point(749, 9);
            this.btnIndir.Name = "btnIndir";
            this.btnIndir.Size = new System.Drawing.Size(20, 20);
            this.btnIndir.TabIndex = 1;
            this.btnIndir.UseVisualStyleBackColor = false;
            this.btnIndir.Click += new System.EventHandler(this.btnIndir_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.Location = new System.Drawing.Point(799, 9);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(20, 20);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKapatIstatistik
            // 
            this.btnKapatIstatistik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapatIstatistik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.btnKapatIstatistik.FlatAppearance.BorderSize = 0;
            this.btnKapatIstatistik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapatIstatistik.Image = ((System.Drawing.Image)(resources.GetObject("btnKapatIstatistik.Image")));
            this.btnKapatIstatistik.Location = new System.Drawing.Point(705, 429);
            this.btnKapatIstatistik.Name = "btnKapatIstatistik";
            this.btnKapatIstatistik.Size = new System.Drawing.Size(115, 50);
            this.btnKapatIstatistik.TabIndex = 13;
            this.btnKapatIstatistik.Text = "Kapat";
            this.btnKapatIstatistik.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKapatIstatistik.UseVisualStyleBackColor = false;
            this.btnKapatIstatistik.Click += new System.EventHandler(this.btnKapatIstatistik_Click);
            // 
            // dBEzberimdeDataSet
            // 
            this.dBEzberimdeDataSet.DataSetName = "DBEzberimdeDataSet";
            this.dBEzberimdeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kelimelerBindingSource
            // 
            this.kelimelerBindingSource.DataMember = "Kelimeler";
            this.kelimelerBindingSource.DataSource = this.dBEzberimdeDataSet;
            // 
            // kelimelerTableAdapter
            // 
            this.kelimelerTableAdapter.ClearBeforeFill = true;
            // 
            // FormIstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(831, 488);
            this.Controls.Add(this.btnKapatIstatistik);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormIstatistik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormIstatistik";
            this.Load += new System.EventHandler(this.FormIstatistik_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormIstatistik_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormIstatistik_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBEzberimdeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimelerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIndir;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKapatIstatistik;
        private DBEzberimdeDataSet dBEzberimdeDataSet;
        private System.Windows.Forms.BindingSource kelimelerBindingSource;
        private DBEzberimdeDataSetTableAdapters.KelimelerTableAdapter kelimelerTableAdapter;
    }
}