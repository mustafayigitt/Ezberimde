using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ezberimde
{
    public class DatabaseIslemleri : IDatabaseIslem
    {
        SqlConnection sql;
        DataGridView dataGridView;

        public DatabaseIslemleri(DataGridView gridView)
        {
            dataGridView = gridView;
        }
        public DatabaseIslemleri()
        {

        }

        public void Baglan()
        {
            sql = new SqlConnection("Data Source=MUSTAFA\\SQLEXPRESS;Initial Catalog=DBEzberimde;Integrated Security=True");
        }

        public void Ekle(Kelime eklenecek)
        {
            Baglan();
            sql.Open();
            SqlCommand command = new SqlCommand("insert into Kelimeler (Ad,Tür,Anlam,Cümle) values (@ad,@tur,@anlam,@cumle) ", sql);
            command.Parameters.AddWithValue("@ad", eklenecek.Ad);
            command.Parameters.AddWithValue("@tur", eklenecek.Tur);
            command.Parameters.AddWithValue("@anlam", eklenecek.Anlam);
            command.Parameters.AddWithValue("@cumle", eklenecek.Cumle);
            command.ExecuteNonQuery();
            sql.Close();
            Listele();
        }

        public void Ara(Kelime aranan)
        {
            Baglan();
            sql.Open();
            SqlCommand command = new SqlCommand("Select * from Kelimeler where Ad = @ad or Tür = @tur or Anlam = @anlam", sql);
            command.Parameters.AddWithValue("@ad", aranan.Ad);
            command.Parameters.AddWithValue("@tur", aranan.Tur);
            command.Parameters.AddWithValue("@anlam", aranan.Anlam);
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }

        public void Guncelle(Kelime eski, Kelime yeni)
        {
            Baglan();
            sql.Open();
            SqlCommand command = new SqlCommand("update kelimeler set Ad=@ad,Tür=@tür,Anlam=@anlam,Cümle=@cümle where ID=@id",sql);
            command.Parameters.AddWithValue("@ad", yeni.Ad);
            command.Parameters.AddWithValue("@tür", yeni.Tur);
            command.Parameters.AddWithValue("@anlam", yeni.Anlam);
            command.Parameters.AddWithValue("@cümle", yeni.Cumle);
            command.Parameters.AddWithValue("@id", eski.ID);
            command.ExecuteNonQuery();
            sql.Close();
            Listele();
        }

        public void Sil(Kelime silinecek)
        {
            Baglan();
            sql.Open();
            SqlCommand command = new SqlCommand("delete from Kelimeler where ID = @id", sql);
            command.Parameters.AddWithValue("@id", silinecek.ID);
            command.ExecuteNonQuery();
            sql.Close();
            Listele();
        }

        public void Listele()
        {
            List<Kelime> kelimeListesi = new List<Kelime>();
            Baglan();
            sql.Open();
            SqlCommand command = new SqlCommand("select * from Kelimeler", sql);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            sql.Close();
        }

        public void RastgeleGetir(Control control)
        {
            //Eklenme Tarihine Göre 1 gün 1 hafta 1 ay 6 ay sürelerde hatırlatma yapılacak her aşamayı tamamlayan kelime ezberlenmiş sayılacak.
            Baglan();
            sql.Open();

            SqlCommand command = new SqlCommand("Update Kelimeler set HatırlatmaTarihi = DATEADD(d, 1,  GETDATE()) , EzberDurum = 0 , EzberSeviye = 1 , EzberTarihi = NULL where HatırlatmaTarihi < DATEADD(d, -1,  GETDATE()) ", sql);
            command.ExecuteNonQuery();
            SqlCommand command2 = new SqlCommand("Select * from Kelimeler where (EzberDurum = 0) and " +
                "((HatırlatmaTarihi >= @dun and HatırlatmaTarihi <= @bugun) or " +
                "(HatırlatmaTarihi >= @birHaftaDun and HatırlatmaTarihi <= @birHaftaYarin) or" +
                "(HatırlatmaTarihi >= @birAyDun and HatırlatmaTarihi <= @birAyYarin) or" +
                "(HatırlatmaTarihi >= @altiAyYarin and HatırlatmaTarihi <= @altiAyYarin)) order by newid() ", sql);
            command2.Parameters.AddWithValue("@dun", DateTime.Now.AddDays(-1));
            command2.Parameters.AddWithValue("@bugun", DateTime.Now.AddDays(+1));
            command2.Parameters.AddWithValue("@birHaftaDun", DateTime.Now.AddDays(+6));
            command2.Parameters.AddWithValue("@birHaftaYarin", DateTime.Now.AddDays(+7));
            command2.Parameters.AddWithValue("@birAyDun", DateTime.Now.AddDays(+29));
            command2.Parameters.AddWithValue("@birAyYarin", DateTime.Now.AddDays(+30));
            command2.Parameters.AddWithValue("@altiAyDun", DateTime.Now.AddDays(+179));
            command2.Parameters.AddWithValue("@altiAyYarin", DateTime.Now.AddDays(+180));
            SqlDataReader dr = command2.ExecuteReader();
            if (dr.Read())
            {
                control.Text = dr["Ad"].ToString();
            }
            else
            {
                MessageBox.Show("Günlük Başarıya Ulaştın! Yarın Tekrar Etmeyi Unutma.");
            }
            sql.Close();
        }
        
        public bool Dogrula(string ing,string tr)
        {
            int kontrol=1;
            Baglan();
            sql.Open();
            SqlCommand command = new SqlCommand("select * from Kelimeler where Ad = @ad ", sql);
            command.Parameters.AddWithValue("@ad", ing);
            command.ExecuteNonQuery();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                kontrol = string.Compare(tr, dr["Anlam"].ToString(), true);
            }
            dr.Close();
            return Convert.ToBoolean(kontrol);
        }
        
        public void DurumGuncelle(string ezberlenen)
        {
            Baglan();
            sql.Open();
            SqlCommand command = new SqlCommand("Update Kelimeler set [EzberSeviye] += 1 where [Ad] = @ad", sql);
            command.Parameters.AddWithValue("@ad", ezberlenen);
            command.ExecuteNonQuery();

            int durumOnceki = DurumGetir(ezberlenen);
            SqlCommand command2 = new SqlCommand("Update Kelimeler set [EzberDurum] = 1 where [EzberSeviye] >= 5 ", sql);
            command2.ExecuteNonQuery();

            int durumSonraki = DurumGetir(ezberlenen);

            if (durumOnceki!=durumSonraki)
            {
                SqlCommand commandDurum = new SqlCommand("Update Kelimeler set [EzberTarihi] = GETDATE() where [Ad] = @ad", sql);
                commandDurum.Parameters.AddWithValue("@ad", ezberlenen);
                commandDurum.ExecuteNonQuery();
            }

            HatirlaticiAyari(ezberlenen);
            sql.Close();
        }

        public int DurumGetir(string ezber)
        {
            int durum;
            SqlCommand command = new SqlCommand("select EzberDurum from Kelimeler where Ad = @ad ", sql);
            command.Parameters.AddWithValue("@ad", ezber);
            durum = Convert.ToInt32(command.ExecuteScalar());
            return durum;
        }

        public void HatirlaticiAyari(string calisilan)
        {
            SqlCommand command = new SqlCommand("Select * from Kelimeler where Ad = @ad", sql);
            command.Parameters.AddWithValue("@ad", calisilan);
            command.ExecuteNonQuery();

            SqlDataReader dr = command.ExecuteReader();
            SqlCommand command2 = null;
            if (dr.Read())
            {
                switch (Convert.ToInt32(dr["EzberSeviye"]))
                {
                    case 1:
                        command2 = new SqlCommand("Update Kelimeler set HatırlatmaTarihi = DATEADD(d, 1,  HatırlatmaTarihi) where [Ad] = @ad", sql);
                        command2.Parameters.AddWithValue("@ad", calisilan);
                        break;

                    case 2:
                        command2 = new SqlCommand("Update Kelimeler set HatırlatmaTarihi = DATEADD(ww, 1,  HatırlatmaTarihi) where [Ad] = @ad", sql);
                        command2.Parameters.AddWithValue("@ad", calisilan);
                        break;

                    case 3:
                        command2 = new SqlCommand("Update Kelimeler set HatırlatmaTarihi = DATEADD(m, 1,  HatırlatmaTarihi) where [Ad] = @ad", sql);
                        command2.Parameters.AddWithValue("@ad", calisilan);
                        break;

                    case 4:
                        command2 = new SqlCommand("Update Kelimeler set HatırlatmaTarihi = DATEADD(m, 6,  HatırlatmaTarihi) where [Ad] = @ad", sql);
                        command2.Parameters.AddWithValue("@ad", calisilan);
                        break;

                    default:
                        command2 = new SqlCommand("Update Kelimeler set HatırlatmaTarihi = GETDATE() where [Ad] = @ad", sql);
                        command2.Parameters.AddWithValue("@ad", calisilan);
                        break;
                }
            }
            dr.Close();
            command2.ExecuteNonQuery();
        }
    }
}
