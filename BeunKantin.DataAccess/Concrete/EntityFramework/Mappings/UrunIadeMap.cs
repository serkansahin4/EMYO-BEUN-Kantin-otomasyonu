using BeunKantin.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.DataAccess.Concrete.EntityFramework.Mappings
{
    public class UrunIadeMap : EntityTypeConfiguration<UrunIade>
    {
        public UrunIadeMap()
        {
            ToTable(@"UrunIade", @"dbo");
            HasKey(x => x.Iadeid);

            Property(x => x.Iadeid).HasColumnName("Iadeid");
            Property(x => x.SatisId).HasColumnName("SatisId");
            Property(x => x.IadeAlanPersonelId).HasColumnName("IadeAlanPersonelId");
            Property(x => x.IadeAlimTarihi).HasColumnName("IadeAlimTarihi");
            Property(x => x.IadeSebebi).HasColumnName("IadeSebebi");
            Property(x=>x.IadeAdedi).HasColumnName("IadeAdedi");
        }
    }
    
}
