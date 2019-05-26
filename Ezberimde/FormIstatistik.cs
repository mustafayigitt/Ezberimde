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

namespace Ezberimde
{
    public partial class FormIstatistik : Form
    {
        public FormIstatistik()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIndir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormIstatistik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBEzberimdeDataSet.Kelimeler' table. You can move, or remove it, as needed.
            this.kelimelerTableAdapter.Fill(this.dBEzberimdeDataSet.Kelimeler);
            IstatistikAl();

        }

        private void btnKapatIstatistik_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void IstatistikAl()
        {
            int[] aylar = new int[12];
            int[] degerler = new int[12];
            SqlConnection sql = new SqlConnection("Data Source=MUSTAFA\\SQLEXPRESS;Initial Catalog=DBEzberimde;Integrated Security=True");
            sql.Open();
            SqlCommand command = new SqlCommand("Select [EzberAy] from Kelimeler where EzberDurum = 1",sql);
            command.ExecuteNonQuery();
            SqlDataReader dr = command.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                if (dr["EzberAy"] != DBNull.Value)
                {
                    degerler[i] = Convert.ToInt32(dr["EzberAy"]);
                    aylar[degerler[i]]++;
                }
            }
            i = 0;
            foreach (int item in aylar)
            {
                chart1.Series["Ezberlenen Kelimeler"].Points.AddXY(i , aylar[i]);
                i++;
            }
            sql.Close();

        }
        private Point tiklanan_nokta;

        private void FormIstatistik_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan_nokta = new Point(e.X, e.Y);
        }

        private void FormIstatistik_MouseMove(object sender, MouseEventArgs e)
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
