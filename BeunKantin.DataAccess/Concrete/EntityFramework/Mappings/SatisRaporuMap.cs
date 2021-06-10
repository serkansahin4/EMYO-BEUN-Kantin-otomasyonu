using BeunKantin.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.DataAccess.Concrete.EntityFramework.Mappings
{
    public class SatisRaporuMap:EntityTypeConfiguration<SatisRaporu>
    {
        public SatisRaporuMap()
        {
            ToTable(@"SatisRaporu", @"dbo");
            HasKey(x => x.SatisId);

            Property(x => x.SatisId).HasColumnName("SatisId");
            Property(x => x.UrunId).HasColumnName("UrunId");
            Property(x => x.OgrenciHesapId).HasColumnName("OgrenciHesapId");
            Property(x => x.PersonelId).HasColumnName("PersonelId");
            Property(x => x.SatisAdedi).HasColumnName("SatisAdedi");
            Property(x => x.ToplamFiyati).HasColumnName("ToplamFiyati");
            Property(x => x.SatisTarihi).HasColumnName("SatisTarihi");
        }
    }
}
