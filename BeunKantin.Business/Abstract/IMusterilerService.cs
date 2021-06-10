using BeunKantin.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.Business.Abstract
{
    public interface IMusterilerService
    {
        List<Musteriler> HepsiniGetir(string OgrenciHesapId);
        Musteriler Getir(string OgrenciHesapId);
        void Ekle(Musteriler musteriler);
        void Guncelle(Musteriler musteriler);
        void Sil(Musteriler musteriler);
    
    }
}
