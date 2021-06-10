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
    public class HesapOzetleriDal : IHesapOzetleriDal
    {
        public void Ekle(HesapOzetleri hesapOzetleri)
        {
            using (BeunKantinContext context=new BeunKantinContext())
            {
                var entry = context.Entry(hesapOzetleri);
                entry.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public List<HesapOzetleri> hesapOzetleri(Expression<Func<HesapOzetleri, bool>> filter = null)
        {
            using (BeunKantinContext context=new BeunKantinContext())
            {
                return filter == null ? context.Set<HesapOzetleri>().ToList()
                    : context.Set<HesapOzetleri>().Where(filter).ToList();
            }
        }
    }
}
