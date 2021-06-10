using BeunKantin.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.DataAccess.Abstract
{
    public interface IUrunlerDal
    {
        List<Urunler> UrunleriGetir(Expression<Func<Urunler,bool>> filter=null);
        void Guncelle(Urunler urun);
    }
}
