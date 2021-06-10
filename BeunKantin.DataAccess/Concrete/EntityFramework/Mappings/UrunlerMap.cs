using BeunKantin.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.DataAccess.Concrete.EntityFramework.Mappings
{
    public class UrunlerMap:EntityTypeConfiguration<Urunler>
    {
        public UrunlerMap()
        {
            ToTable(@"Urunler", @"dbo");
            HasKey(x => x.UrunId);

            Property(x => x.UrunId).HasColumnName("UrunId");
            Property(x => x.Marka).HasColumnName("Marka");
            Property(x => x.KategoriId).HasColumnName("KategoriId");
            Property(x => x.Adi).HasColumnName("Adi");
            Property(x => x.StokAdedi).HasColumnName("StokAdedi");
            Property(x => x.BirimFiyati).HasColumnName("BirimFiyati");

        }
    }
}
