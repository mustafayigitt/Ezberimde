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
    public partial class FormAnaEkran : Form
    {
        public FormAnaEkran()
        {
            InitializeComponent();
        }

        private void btnCalismaAlani_Click(object sender, EventArgs e)
        {
            FormCalismaAlani formCalisma = new FormCalismaAlani();
            formCalisma.Show();
        }

        private void btnKelimeDeposu_Click(object sender, EventArgs e)
        {
            FormKelimeler formKelimeler = new FormKelimeler();
            formKelimeler.Show();
        }

        private void btnIndir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIstatistikler_Click(object sender, EventArgs e)
        {
            FormIstatistik formIstatistik = new FormIstatistik();
            formIstatistik.Show();
        }

        private Point tiklanan_nokta;

        private void FormAnaEkran_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point Koordinatlar;
                Koordinatlar = Control.MousePosition;
                Koordinatlar.Offset(-tiklanan_nokta.X, -tiklanan_nokta.Y);
                this.Location = Koordinatlar;
            }
        }

        private void FormAnaEkran_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan_nokta = new Point(e.X, e.Y);
        }
    }
}
