using BeunKantin.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.Entities.Concrete
{
    public class Urunler:IEntity
    {
        public int UrunId { get; set; }
        public string Marka { get; set; }
        public int KategoriId { get; set; }
        public string Adi { get; set; }
        public int StokAdedi { get; set; }
        public double BirimFiyati { get; set; }
    }
}
