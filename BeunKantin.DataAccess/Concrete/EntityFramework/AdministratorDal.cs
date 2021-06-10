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
    public class AdministratorDal : IAdministratorDal
    {
        public Administrator Getir(Expression<Func<Administrator, bool>> filter)
        {
            using (BeunKantinContext context=new BeunKantinContext())
            {
                return context.Set<Administrator>().SingleOrDefault(filter);
            }
        }

        public void Guncelle(Administrator personel)
        {
            using (BeunKantinContext context=new BeunKantinContext())
            {
                var entry = context.Entry(personel);
                entry.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public List<Administrator> HepsiniGetir(Expression<Func<Administrator, bool>> filter = null)
        {
            using (BeunKantinContext context = new BeunKantinContext())
            {
                return filter == null ? context.Set<Administrator>().ToList()
                    : context.Set<Administrator>().Where(filter).ToList();
            }
        }
    }
}
