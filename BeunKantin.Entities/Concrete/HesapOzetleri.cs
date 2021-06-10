using BeunKantin.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.Entities.Concrete
{
    public class HesapOzetleri:IEntity
    {
        public int Id { get; set; }
        public string OgrenciHesapId { get; set; }
        public decimal YuklenenBakiye { get; set; }
        public DateTime YuklemeTarihi { get; set; }
    }
}
