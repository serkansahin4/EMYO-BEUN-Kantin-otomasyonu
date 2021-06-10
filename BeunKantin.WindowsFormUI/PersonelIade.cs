using BeunKantin.Business.Abstract;
using BeunKantin.Business.Concrete;
using BeunKantin.DataAccess.Concrete.EntityFramework;
using BeunKantin.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeunKantin.WindowsFormUI
{
    public partial class PersonelIade : Form
    {
        IUrunIadeService _urunIadeService;
        ISatisRaporuService _satisRaporuService;
        IUrunlerService _urunlerService;
        IPersonelService _personelService;
        public PersonelIade()
        {
            InitializeComponent();
            _urunIadeService = new UrunIadeManager(new UrunIadeDal());
            _satisRaporuService = new SatisRaporuManager(new SatisRaporuDal());
            _urunlerService = new UrunlerManager(new UrunlerDal());
            _personelService = new PersonelManager(new PersonelDal());
        }
        public static string musteriid;
        public static int personelid;
        private void PersonelIade_Load(object sender, EventArgs e)
        {
            IadeTabloDoldur(_satisRaporuService.IdyeGoreGetir(musteriid));

            var tarihler = from tarih in _satisRaporuService.IdyeGoreGetir(musteriid)
                           orderby tarih.SatisTarihi descending
                           group tarih by tarih.SatisTarihi into tarihs
                           select new { tarihs = tarihs.Key };
            foreach (var item in tarihler)
            {
                comboBox1.Items.Add(item.tarihs);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem!=null)
            {
                _urunIadeService.iadeet(new UrunIade
                {
                    SatisId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value),
                    IadeAlanPersonelId = personelid,
                    IadeAlimTarihi = DateTime.Now,
                    IadeAdedi = Convert.ToInt16(comboBox2.SelectedItem),
                    IadeSebebi = textBox1.Text
                });
                satisRaporu.SatisAdedi = satisRaporu.SatisAdedi - Convert.ToInt16(comboBox2.SelectedItem);
                satisRaporu.ToplamFiyati = satisRaporu.SatisAdedi * birimfiyati;
                _satisRaporuService.Guncelle(satisRaporu);
                IadeTabloDoldur(_satisRaporuService.IdyeGoreGetir(musteriid));
                comboBox2.DataSource = null;
                comboBox2.Items.Clear();
            }
            else
            {
                MessageBox.Show("Ürün daha önce iade edilmiş.","Dikkat");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IadeTabloDoldur(_satisRaporuService.IdveTariheGoreGetir(musteriid, Convert.ToDateTime(comboBox1.SelectedItem)));
        }
        int adetsayaci;
        SatisRaporu satisRaporu;
        double birimfiyati;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            adetsayaci = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);
            comboBox2.Items.Clear();
            comboBox2.DataSource = null;
            for (int i = 1; i <= adetsayaci; i++)
            {
                comboBox2.Items.Add(i);
            }
            satisRaporu = _satisRaporuService.SatisRaporu(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            birimfiyati = Convert.ToDouble(satisRaporu.ToplamFiyati) / satisRaporu.SatisAdedi;
            if (comboBox2.DataSource == null)
            {
                button1.Enabled = false;
            }
        }
        public void IadeTabloDoldur(List<SatisRaporu> gelenler)
        {
            var SatisRaporlari = from rapor in gelenler
                                 join urunler in _urunlerService.HepsiniGetir() on rapor.UrunId equals urunler.UrunId
                                 join personel in _personelService.Hepsinigetir() on rapor.PersonelId equals personel.PersonelId
                                 select new
                                 {
                                     SatışId = rapor.SatisId,
                                     ÜrünAdı = urunler.Adi,
                                     ÜrünMarkası = urunler.Marka,
                                     ÖgrenciHesapİd = rapor.OgrenciHesapId,
                                     Personel = personel.Adi + " " + personel.Soyadi,
                                     SatışAdedi = rapor.SatisAdedi,
                                     BirimFiyatı = urunler.BirimFiyati,
                                     ToplamFiyatı = rapor.ToplamFiyati,
                                     SatışTarihi = rapor.SatisTarihi
                                 };
            dataGridView1.DataSource = SatisRaporlari.ToList();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
//İadesi yapılacak ürünler satış raporlarından azaltılacak.