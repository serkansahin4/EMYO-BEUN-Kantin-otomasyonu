using BeunKantin.DataAccess.Concrete.EntityFramework.Mappings;
using BeunKantin.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeunKantin.DataAccess.Concrete.EntityFramework
{
    public class BeunKantinContext:DbContext
    {
        public BeunKantinContext()
        {
            Database.SetInitializer<BeunKantinContext>(null);
        }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<HesapOzetleri> Hesaplar { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Musteriler> Musteriler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<SatisRaporu> satisRaporu { get; set; }
        public DbSet<Urunler> Urunler { get; set; }
        public DbSet<UrunIade> UrunIadeleri { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AdministratorMap());
            modelBuilder.Configurations.Add(new KategoriMap());
            modelBuilder.Configurations.Add(new HesapOzetleriMap());
            modelBuilder.Configurations.Add(new MusterilerMap());
            modelBuilder.Configurations.Add(new PersonelMap());
            modelBuilder.Configurations.Add(new UrunlerMap());
            modelBuilder.Configurations.Add(new SatisRaporuMap());
            modelBuilder.Configurations.Add(new UrunIadeMap());
            
        }
    }
}
