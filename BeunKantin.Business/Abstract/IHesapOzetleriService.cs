using BeunKantin.DataAccess.Abstract;
using BeunKantin.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.Business.Abstract
{
    public interface IHesapOzetleriService
    {
        List<HesapOzetleri> HepsiniGetir();
        void Ekle(HesapOzetleri hesapOzetleri);
    }
}
