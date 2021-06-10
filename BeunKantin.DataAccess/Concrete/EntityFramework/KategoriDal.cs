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
    public class KategoriDal : IKategoriDal
    {
        public void Ekle(Kategori kategori)
        {
            using (BeunKantinContext context=new BeunKantinContext())
            {
                var entry = context.Entry(kategori);
                entry.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public List<Kategori> HepsiniGetir(Expression<Func<Kategori, bool>> filter = null)
        {
            using (BeunKantinContext context = new BeunKantinContext())
            {
                return filter == null
                    ? context.Set<Kategori>().ToList()
                    : context.Set<Kategori>().Where(filter).ToList();
            }
        }

        public void Guncelle(Kategori kategori)
        {
            using (BeunKantinContext context = new BeunKantinContext())
            {
                var entry = context.Entry(kategori);
                entry.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Sil(Kategori kategori)
        {
            using (BeunKantinContext context = new BeunKantinContext())
            {
                var entry = context.Entry(kategori);
                entry.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
