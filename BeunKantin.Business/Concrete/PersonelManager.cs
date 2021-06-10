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
    public class PersonelManager : IPersonelService
    {
        IPersonelDal _personelDal;
        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }
        public Personel Getir(string kuad, string parola)
        {
            var a = _personelDal.Getir(p => p.KullaniciAdi == kuad & p.Parola == parola);
            
            return a;
        }

        public void Guncelle(Personel personel)
        {
            _personelDal.Guncelle(personel);
        }

        public List<Personel> Hepsinigetir()
        {
            return _personelDal.HepsiniGetir();
        }
    }
}
