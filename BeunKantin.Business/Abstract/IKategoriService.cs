using BeunKantin.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.Business.Abstract
{
    public interface IKategoriService
    {
        List<Kategori> KategorileriGetir();
        void Ekle(Kategori kategori);
        void Sil(Kategori kategori);
        void Guncelle(Kategori kategori);
    }
}
