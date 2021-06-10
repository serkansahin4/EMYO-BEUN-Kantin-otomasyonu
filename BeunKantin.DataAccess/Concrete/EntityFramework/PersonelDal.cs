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
    public class PersonelDal : IPersonelDal
    {
        public Personel Getir(Expression<Func<Personel, bool>> filter)
        {
            using (BeunKantinContext context=new BeunKantinContext())
            {
                return context.Set<Personel>().FirstOrDefault(filter);
            }
        }

        public void Guncelle(Personel personel)
        {
            using (BeunKantinContext context=new BeunKantinContext())
            {
                var entry = context.Entry(personel);
                entry.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public List<Personel> HepsiniGetir(Expression<Func<Personel, bool>> filter = null)
        {
            using (BeunKantinContext context = new BeunKantinContext())
            {
                return filter == null ? context.Set<Personel>().ToList()
                    : context.Set<Personel>().Where(filter).ToList();                    ;
            }
        }
    }
}
