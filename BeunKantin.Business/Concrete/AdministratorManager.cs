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
    public class AdministratorManager : IAdministratorService
    {
        IAdministratorDal _administratorDal;
        public AdministratorManager(IAdministratorDal administratorDal)
        {
            _administratorDal = administratorDal;
        }
        public Administrator Getir(string kuad, string parola)
        {
            return _administratorDal.Getir(p => p.KullaniciAdi == kuad & p.Parola == parola);
        }

        public void Guncelle(Administrator personel)
        {
            _administratorDal.Guncelle(personel);
        }

        public List<Administrator> Hepsinigetir()
        {
            return _administratorDal.HepsiniGetir();
        }
    }
}
