using BeunKantin.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.DataAccess.Concrete.EntityFramework.Mappings
{
    public class PersonelMap: EntityTypeConfiguration<Personel>
    {
        public PersonelMap()
        {
            ToTable(@"Personeller", @"dbo");
            HasKey(x => x.PersonelId);

            Property(x => x.PersonelId).HasColumnName("PersonelId");
            Property(x => x.Adi).HasColumnName("Adi");
            Property(x => x.Soyadi).HasColumnName("Soyadi");
            Property(x => x.TcNo).HasColumnName("TcNo");
            Property(x => x.KullaniciAdi).HasColumnName("KullaniciAdi");
            Property(x => x.Parola).HasColumnName("Parola");
        }
    }
}
