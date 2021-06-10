using BeunKantin.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.Entities.Concrete
{
    public class Musteriler:IEntity
    {
        public string OgrenciHesapId { get; set; }
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set; }
        public string OgrenciNo { get; set; }
        public double Bakiye { get; set; }
    }
}
