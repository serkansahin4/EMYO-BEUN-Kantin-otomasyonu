using BeunKantin.Business.Abstract;
using BeunKantin.DataAccess.Abstract;
using BeunKantin.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.Business.Concrete
{
    public class KategoriManager : IKategoriService
    {
        IKategoriDal _kategoriDal;
        public KategoriManager(IKategoriDal kategoriDal)
        {
            _kategoriDal = kategoriDal;
        }

        public void Ekle(Kategori kategori)
        {
            _kategoriDal.Ekle(kategori);
        }

        public void Guncelle(Kategori kategori)
        {
            _kategoriDal.Guncelle(kategori);
        }

        public List<Kategori> KategorileriGetir()
        {
              return _kategoriDal.HepsiniGetir().ToList();
        }

        public void Sil(Kategori kategori)
        {
            _kategoriDal.Sil(kategori);
        }
    }
}
