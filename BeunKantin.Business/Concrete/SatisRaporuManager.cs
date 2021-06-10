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
    public class SatisRaporuManager : ISatisRaporuService
    {
        ISatisRaporuDal _satisRaporuDal;
        public SatisRaporuManager(ISatisRaporuDal satisRaporuDal)
        {
            _satisRaporuDal = satisRaporuDal;
        }
        public void Ekle(SatisRaporu satisRaporu)
        {
            _satisRaporuDal.Ekle(satisRaporu);
        }

        public void Guncelle(SatisRaporu satisRaporu)
        {
            _satisRaporuDal.Guncelle(satisRaporu);
        }

        public List<SatisRaporu> HepsiniGetir()
        {
           return _satisRaporuDal.HepsiniGetir();
        }

        public List<SatisRaporu> IdveTariheGoreGetir(string id, DateTime dateTime)
        {
            return _satisRaporuDal.HepsiniGetir(p => p.OgrenciHesapId == id&&p.SatisTarihi==dateTime);
        }

        public List<SatisRaporu> IdyeGoreGetir(string id)
        {
            return _satisRaporuDal.HepsiniGetir(p => p.OgrenciHesapId == id);
        }

        public SatisRaporu SatisRaporu(int satisid)
        {
            return _satisRaporuDal.Getir(p => p.SatisId == satisid);
        }

        public void Sil(SatisRaporu satisRaporu)
        {
            _satisRaporuDal.Sil(satisRaporu);
        }
    }
}
