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
    public class UrunlerManager : IUrunlerService
    {
        IUrunlerDal _urunlerDal;
        public UrunlerManager(IUrunlerDal urunlerDal)
        {
            _urunlerDal = urunlerDal;
        }

        public List<Urunler> AdveMarkayaGore(string marka,string adi)
        {
            return _urunlerDal.UrunleriGetir(p =>p.Marka==marka& p.Adi == adi);
        }

        public List<Urunler> FiltreyeGore(string filtreAdi)
        {
            return _urunlerDal.UrunleriGetir(p => p.Adi.ToLower().Contains(filtreAdi.ToLower())|p.Marka.ToLower().Contains(filtreAdi.ToLower()));
        }

        public List<Urunler> HepsiniGetir()
        {
            return _urunlerDal.UrunleriGetir();
        }

        public List<Urunler> AdMarkaKategoriyeGore(string marka, string adi, int kategoriId)
        {
            return _urunlerDal.UrunleriGetir(p =>p.Marka==marka&p.Adi==adi& p.KategoriId == kategoriId);
        }

        public List<Urunler> MarkayaGore(string marka)
        {
            return _urunlerDal.UrunleriGetir(p => p.Marka == marka);
        }

        public void Guncelle(Urunler urun)
        {
            _urunlerDal.Guncelle(urun);
        }
    }
}
