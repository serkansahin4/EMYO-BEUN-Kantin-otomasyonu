using BeunKantin.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.DataAccess.Concrete.EntityFramework.Mappings
{
    public class HesapOzetleriMap:EntityTypeConfiguration<HesapOzetleri>
    {
        public HesapOzetleriMap()
        {
            ToTable(@"HesapOzetleri", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.OgrenciHesapId).HasColumnName("OgrenciHesapId");
            Property(x => x.YuklenenBakiye).HasColumnName("YuklenenBakiye");
            Property(x => x.YuklemeTarihi).HasColumnName("YuklemeTarihi");
        }
    }
}
