using BeunKantin.DataAccess.Abstract;
using BeunKantin.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.DataAccess.Concrete.EntityFramework
{
    public class UrunlerDal : IUrunlerDal
    {
        public void Guncelle(Urunler urun)
        {
            using (BeunKantinContext context=new BeunKantinContext())
            {
                var entry = context.Entry(urun);
                entry.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public List<Urunler> UrunleriGetir(Expression<Func<Urunler, bool>> filter = null)
        {
            using (BeunKantinContext context=new BeunKantinContext())
            {
                return filter == null ? context.Set<Urunler>().ToList()
                    : context.Set<Urunler>().Where(filter).ToList();
            }
        }
    }
}
