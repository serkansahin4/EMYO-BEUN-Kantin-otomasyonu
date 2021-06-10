using BeunKantin.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.DataAccess.Abstract
{
    public interface IHesapOzetleriDal
    {
        List<HesapOzetleri> hesapOzetleri(Expression<Func<HesapOzetleri,bool>> filter=null);
        void Ekle(HesapOzetleri hesapOzetleri);
    }
}
