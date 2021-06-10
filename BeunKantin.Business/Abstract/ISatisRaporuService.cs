using BeunKantin.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.Business.Abstract
{
    public interface ISatisRaporuService
    {
        List<SatisRaporu> HepsiniGetir();
        List<SatisRaporu> IdyeGoreGetir(string id);
        List<SatisRaporu> IdveTariheGoreGetir(string id,DateTime dateTime);
        SatisRaporu SatisRaporu(int satisid);        
        void Ekle(SatisRaporu satisRaporu);
        void Guncelle(SatisRaporu satisRaporu);
        void Sil(SatisRaporu satisRaporu);
    }
}
