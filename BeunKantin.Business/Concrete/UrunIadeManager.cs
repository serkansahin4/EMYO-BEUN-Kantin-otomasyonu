using BeunKantin.Business.Abstract;
using BeunKantin.DataAccess.Abstract;
using BeunKantin.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.Business.Concrete
{
    public class UrunIadeManager : IUrunIadeService
    {
        IUrunIadeDal _urunIadeDal;
        public UrunIadeManager(IUrunIadeDal urunIadeDal)
        {
            _urunIadeDal = urunIadeDal;
        }
        public void iadeet(UrunIade urunIade)
        {
            _urunIadeDal.Ekle(urunIade);
        }
    }
}
