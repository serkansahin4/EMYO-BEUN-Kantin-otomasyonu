using BeunKantin.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.Entities.Concrete
{
    public class UrunIade:IEntity
    {
        public int Iadeid { get; set; }
        public int SatisId { get; set; }
        public int IadeAlanPersonelId { get; set; }
        public DateTime IadeAlimTarihi { get; set; }
        public string IadeSebebi { get; set; }
        public int IadeAdedi { get; set; }
    }
}
