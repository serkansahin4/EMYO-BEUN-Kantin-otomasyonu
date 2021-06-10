using BeunKantin.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.Entities.Concrete
{
    public class SatisRaporu:IEntity
    {
        public int SatisId { get; set; }
        public int UrunId { get; set; }
        public string OgrenciHesapId { get; set; }
        public int PersonelId { get; set; }
        public int SatisAdedi { get; set; }
        public double ToplamFiyati { get; set; }
        public DateTime SatisTarihi { get; set; }
    }
}
