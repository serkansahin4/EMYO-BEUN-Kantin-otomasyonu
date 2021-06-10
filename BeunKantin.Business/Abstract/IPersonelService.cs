using BeunKantin.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.Business.Abstract
{
    public interface IPersonelService
    {
        Personel Getir(string kuad,string parola);
        void Guncelle(Personel personel);
        List<Personel> Hepsinigetir();
    }
}
