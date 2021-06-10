using BeunKantin.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.DataAccess.Abstract
{
    public interface IPersonelDal
    {
        List<Personel> HepsiniGetir(Expression<Func<Personel, bool>> filter=null);
        Personel Getir(Expression<Func<Personel,bool>> filter);
        void Guncelle(Personel personel);
    }
}
