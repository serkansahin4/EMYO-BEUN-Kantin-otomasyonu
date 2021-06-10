using BeunKantin.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.DataAccess.Abstract
{
    public interface IKategoriDal
    {
        List<Kategori> HepsiniGetir(Expression<Func<Kategori,bool>> filter=null);
        void Ekle(Kategori kategori);
        void Sil(Kategori kategori);
        void Guncelle(Kategori kategori);
    }
}
