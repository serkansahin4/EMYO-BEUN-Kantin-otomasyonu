using BeunKantin.DataAccess.Abstract;
using BeunKantin.DataAccess.Concrete.EntityFramework;
using BeunKantin.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.DataAccess.Concrete
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : BeunKantinContext, new()
    {
        public void Ekle(TEntity entity)
        {
            using (TContext context=new TContext())
            {
                var entry = context.Entry(entity);
                entry.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Sil(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var entry = context.Entry(entity);
                entry.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Getir(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> HepsiniGetir(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter==null
                    ?context.Set<TEntity>().ToList()
                    :context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Guncelle(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var entry = context.Entry(entity);
                entry.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
