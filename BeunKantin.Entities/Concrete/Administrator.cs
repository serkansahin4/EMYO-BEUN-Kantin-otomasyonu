using BeunKantin.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.Entities.Concrete
{
    public class Administrator:IEntity
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
    }
}
