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
    public class HesapOzetleriManager:IHesapOzetleriService
    {
        IHesapOzetleriDal _hesapOzetleriDal;
        public HesapOzetleriManager(IHesapOzetleriDal hesapOzetleriDal)
        {
            _hesapOzetleriDal = hesapOzetleriDal;
        }

        public void Ekle(HesapOzetleri hesapOzetleri)
        {
            _hesapOzetleriDal.Ekle(hesapOzetleri);
        }

        public List<HesapOzetleri> HepsiniGetir()
        {
            return _hesapOzetleriDal.hesapOzetleri();
        }
    }
}
