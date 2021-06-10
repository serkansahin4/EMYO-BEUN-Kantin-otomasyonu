using BeunKantin.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.Business.Abstract
{
    public interface IUrunlerService
    {
        List<Urunler> HepsiniGetir();
        List<Urunler> FiltreyeGore(string filtreAdi);
        List<Urunler> MarkayaGore(string marka);
        List<Urunler> AdveMarkayaGore(string marka,string adi);
        List<Urunler> AdMarkaKategoriyeGore(string marka, string adi,int kategoriId);
        void Guncelle(Urunler urun);
    }
}
