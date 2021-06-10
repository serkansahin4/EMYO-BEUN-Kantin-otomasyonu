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
    public class MusterilerDal : EfEntityRepositoryBase<Musteriler,BeunKantinContext>,IMusterilerDal
    {
       
    }
}
