using BeunKantin.DataAccess.Abstract;
using BeunKantin.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.DataAccess.Concrete.EntityFramework
{
    public class UrunIadeDal : IUrunIadeDal
    {
        public void Ekle(UrunIade urunIade)
        {
            using (BeunKantinContext context=new BeunKantinContext())
            {
                context.Set<UrunIade>().Add(urunIade);
                context.SaveChanges();
            }
        }
    }
}
