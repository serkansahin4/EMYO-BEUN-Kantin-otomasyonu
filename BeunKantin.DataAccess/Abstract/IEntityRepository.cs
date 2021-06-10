using BeunKantin.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> HepsiniGetir(Expression<Func<T,bool>> filter=null);
        T Getir(Expression<Func<T, bool>> filter);
        void Ekle(T entity);
        void Guncelle(T entity);
        void Sil(T entity);
    }
}
