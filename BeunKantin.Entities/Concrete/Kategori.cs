using BeunKantin.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.Entities.Concrete
{
    public class Kategori:IEntity
    {
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }
    }
}
