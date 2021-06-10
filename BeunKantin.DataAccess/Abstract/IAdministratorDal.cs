using BeunKantin.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.DataAccess.Abstract
{
    public interface IAdministratorDal
    {
        List<Administrator> HepsiniGetir(Expression<Func<Administrator, bool>> filter = null);
        Administrator Getir(Expression<Func<Administrator, bool>> filter);
        void Guncelle(Administrator personel);
    }
}
