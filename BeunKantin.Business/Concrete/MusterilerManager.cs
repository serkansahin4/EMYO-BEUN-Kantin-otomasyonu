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
    public class MusterilerManager : IMusterilerService
    {
        IMusterilerDal _musterilerDal;
        public MusterilerManager(IMusterilerDal musterilerDal)
        {
            _musterilerDal = musterilerDal;
        }
        public void Ekle(Musteriler musteriler)
        {
            _musterilerDal.Ekle(musteriler);
        }

        public Musteriler Getir(string OgrenciHesapId)
        {
            return _musterilerDal.Getir(p=>p.OgrenciHesapId==OgrenciHesapId);
        }

        public void Guncelle(Musteriler musteriler)
        {
            _musterilerDal.Guncelle(musteriler);
        }

        public List<Musteriler> HepsiniGetir(string OgrenciHesapId)
        {
            return _musterilerDal.HepsiniGetir(p=>p.OgrenciHesapId==OgrenciHesapId);
        }

        public void Sil(Musteriler musteriler)
        {
            _musterilerDal.Sil(musteriler);
        }

        
    }
}
