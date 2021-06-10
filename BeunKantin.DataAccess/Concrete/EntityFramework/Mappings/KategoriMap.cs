using BeunKantin.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.DataAccess.Concrete.EntityFramework.Mappings
{
    public class KategoriMap : EntityTypeConfiguration<Kategori>
    {
        public KategoriMap()
        {
            ToTable(@"Kategoriler", @"dbo");
            HasKey(x => x.KategoriId);

            Property(x => x.KategoriId).HasColumnName("KategoriId");
            Property(x => x.KategoriAdi).HasColumnName("KategoriAdi");

        }
    }
}
