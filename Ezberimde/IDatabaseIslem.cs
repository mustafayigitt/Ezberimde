using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ezberimde
{
    public interface IDatabaseIslem
    {
        void Baglan();
        void Listele();
        void Ekle(Kelime eklenecek);
        void Ara(Kelime aranan);
        void Guncelle(Kelime eski, Kelime yeni);
        void Sil(Kelime silinecek);
    }
}
