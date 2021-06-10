using BeunKantin.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.DataAccess.Concrete.EntityFramework.Mappings
{
    public class MusterilerMap : EntityTypeConfiguration<Musteriler>
    {
        public MusterilerMap()
        {
            ToTable(@"Musteriler", @"dbo");
            HasKey(x => x.OgrenciHesapId);

            Property(x => x.OgrenciHesapId).HasColumnName("OgrenciHesapId");
            Property(x => x.OgrenciAdi).HasColumnName("OgrenciAdi");
            Property(x => x.OgrenciSoyadi).HasColumnName("OgrenciSoyadi");
            Property(x => x.OgrenciNo).HasColumnName("OgrenciNo");
            Property(x => x.Bakiye).HasColumnName("Bakiye");
        }
    }
}
