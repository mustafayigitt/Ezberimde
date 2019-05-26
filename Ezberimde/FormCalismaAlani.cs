using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;

namespace Ezberimde
{
    public partial class FormCalismaAlani : Form
    {
        DatabaseIslemleri databaseIslemleri;
        bool calismaDurumu = false;

        public FormCalismaAlani()
        {
            InitializeComponent();
            databaseIslemleri = new DatabaseIslemleri();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            calismaDurumu = true;
            // Veritabanındaki Öğrenilmemiş Kelimelerden Rastgele Kelime Seç
            databaseIslemleri.RastgeleGetir(this.txtIng);            
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            // Kelimenin Anlamı İcin Verilen Cevabı Kontrol Et
            bool durum = true;
            if (calismaDurumu == false)
            {
                MessageBox.Show("Önce Çalışmayı Başlatmalısın.");
            }
            else
            {
                durum = databaseIslemleri.Dogrula(txtIng.Text.Trim().ToString(), txtTr.Text.Trim().ToString());

                if (durum == true)
                {
                    MessageBox.Show("Tekrar Denemelisin. İyi Düşün.");
                }
                else
                {
                    databaseIslemleri.DurumGuncelle(txtIng.Text.ToString());
                    MessageBox.Show("Tebrikler! Devam Et.");
                    txtTr.Clear();
                    databaseIslemleri.RastgeleGetir(txtIng);
                }
            }
            
        }

        private void btnDur_Click(object sender, EventArgs e)
        {
            if (calismaDurumu == false)
            {
                MessageBox.Show("Önce Çalışmayı Başlatmalısın.");
            }
            else
            {
                MessageBox.Show("Seni Bekliyoruz. Çok Ara Verme.");
                calismaDurumu = false;
                txtIng.Clear();
                txtTr.Clear();
                this.Close();
            }
        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            if (calismaDurumu == false)
            {
                MessageBox.Show("Önce Çalışmaya Başlamalısın.");
            }
            else
            {
                databaseIslemleri.RastgeleGetir(this.txtIng);
            }
        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            SpeechLib.SpeechVoiceSpeakFlags flg = SpeechLib.SpeechVoiceSpeakFlags.SVSFlagsAsync;
            SpeechLib.SpVoice ses = new SpeechLib.SpVoice();
            ses.Speak(txtIng.Text);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIndir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private Point tiklanan_nokta;

        private void FormCalismaAlani_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan_nokta = new Point(e.X, e.Y);
        }

        private void FormCalismaAlani_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point Koordinatlar;
                Koordinatlar = Control.MousePosition;
                Koordinatlar.Offset(-tiklanan_nokta.X, -tiklanan_nokta.Y);
                this.Location = Koordinatlar;
            }
        }
    }
}
