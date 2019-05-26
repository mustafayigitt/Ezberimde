using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ezberimde
{
    public partial class FormKelimeler : Form
    {
        DatabaseIslemleri databaseIslemleri;
        public FormKelimeler()
        {
            InitializeComponent();
            databaseIslemleri = new DatabaseIslemleri(dataGridView1);
        }
        
        private void FormKelimeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBEzberimdeDataSet.Kelimeler' table. You can move, or remove it, as needed.
            //this.kelimelerTableAdapter.Fill(this.dBEzberimdeDataSet.Kelimeler);
            databaseIslemleri.Listele();
        }
        
        public void TemizleTextBox(Control kontrol)
        {
            foreach (Control child in kontrol.Controls)
            {
                if (child is TextBox)
                {
                    (child as TextBox).Text = "";
                }
                else
                {
                    TemizleTextBox(child);
                }
            }
        }
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            panelButon.Visible = false;
            panelEkle.Visible = true;
        }

        private void btnEkleIptal_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            panelButon.Visible = true;
            panelEkle.Visible = false;
            TemizleTextBox(this);
        }

        private void btnEkleOnay_Click(object sender, EventArgs e)
        {
            //TODO: Veritabanına Yeni Kelime Ekle
            Kelime eklenecek = new Kelime();
            eklenecek.Ad = txtEkleAd.Text;
            eklenecek.Tur = txtEkleTur.Text;
            eklenecek.Anlam = txtEkleAnlam.Text;
            eklenecek.Cumle = txtEkleCumle.Text;

            databaseIslemleri.Ekle(eklenecek);

            dataGridView1.Visible = true;
            panelButon.Visible = true;
            panelEkle.Visible = false;
            TemizleTextBox(this);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            panelButon.Visible = false;
            panelArama.Visible = true;
        }

        private void btnAramaIptal_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            panelButon.Visible = true;
            panelArama.Visible = false;
            TemizleTextBox(this);
        }

        private void btnAramaOnay_Click(object sender, EventArgs e)
        {
            //TODO: Veritabanından Sorgula
            Kelime aranan = new Kelime();
            aranan.Ad = txtAramaAd.Text;
            aranan.Tur = txtAramaTur.Text;
            aranan.Anlam = txtAramaAnlam.Text;

            databaseIslemleri.Ara(aranan);

            dataGridView1.Visible = true;
            panelButon.Visible = true;
            panelArama.Visible = false;
            TemizleTextBox(this);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            panelButon.Visible = false;
            panelGuncelle.Visible = true;
            txtGuncelleAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtGuncelleTur.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtGuncelleAnlam.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtGuncelleCumle.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnGuncelleIptal_Click(object sender, EventArgs e)
        {
            panelButon.Visible = true;
            panelGuncelle.Visible = false;
            TemizleTextBox(this);
        }

        private void btnGuncelleOnay_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    //TODO: DataGridViewde Seçili Indexi Güncelle
                    Kelime yeni = new Kelime();
                    Kelime eski = new Kelime();

                    
                    eski.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    eski.Ad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    eski.Tur = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    eski.Anlam = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    eski.Cumle = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                    yeni.ID = eski.ID;
                    yeni.Ad = txtGuncelleAd.Text.ToString();
                    yeni.Tur = txtGuncelleTur.Text.ToString();
                    yeni.Anlam = txtGuncelleAnlam.Text.ToString();
                    yeni.Cumle = txtGuncelleCumle.Text.ToString();

                    databaseIslemleri.Guncelle(eski, yeni);

                    panelButon.Visible = true;
                    panelGuncelle.Visible = false;
                    TemizleTextBox(this);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme İşleminde Hata Oluştu.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            panelButon.Visible = false;
            panelSil.Visible = true;
        }

        private void btnSilIptal_Click(object sender, EventArgs e)
        {
            panelButon.Visible = true;
            panelSil.Visible = false;
        }

        private void btnSilOnay_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO: Veritabanından Sil
                Kelime silinecek = new Kelime();
                silinecek.ID=Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                databaseIslemleri.Sil(silinecek);

                panelButon.Visible = true;
                panelSil.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Silme İşleminde Bir Hata Oluştu.");
            }
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            databaseIslemleri.Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIndir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnTamEkran_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private Point tiklanan_nokta;

        private void FormKelimeler_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point Koordinatlar;
                Koordinatlar = Control.MousePosition;
                Koordinatlar.Offset(-tiklanan_nokta.X, -tiklanan_nokta.Y);
                this.Location = Koordinatlar;
            }
        }

        private void FormKelimeler_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan_nokta = new Point(e.X, e.Y);
        }
    }
}
