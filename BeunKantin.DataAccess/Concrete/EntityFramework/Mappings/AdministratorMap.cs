using BeunKantin.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.DataAccess.Concrete.EntityFramework.Mappings
{
    public class AdministratorMap:EntityTypeConfiguration<Administrator>
    {
        public AdministratorMap()
        {
            ToTable(@"Administrators", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.KullaniciAdi).HasColumnName("KullaniciAdi");
            Property(x => x.Parola).HasColumnName("Parola");
        }
    }
}
