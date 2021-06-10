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
    public partial class PersonelAnasayfa : Form
    {
        IPersonelService _personelService;
        IUrunlerService _urunlerService;
        IKategoriService _kategoriService;
        IMusterilerService _musterilerService;
        ISatisRaporuService _satisRaporuService;
        IHesapOzetleriService _hesapOzetleriService;
        public PersonelAnasayfa()
        {
            InitializeComponent();
            _personelService = new PersonelManager(new PersonelDal());
            _urunlerService = new UrunlerManager(new UrunlerDal());
            _kategoriService = new KategoriManager(new KategoriDal());
            _musterilerService = new MusterilerManager(new MusterilerDal());
            _satisRaporuService = new SatisRaporuManager(new SatisRaporuDal());
            _hesapOzetleriService = new HesapOzetleriManager(new HesapOzetleriDal());
        }
        public Personel personel;


        private void Anasayfa_Load(object sender, EventArgs e)
        {
            //Datagridview buton ekleme


            dgwSepetlistedencikar();
            dgwSepetAdetBelirle();
            dgwSepetAdetAzalt();
            



            comboBox3.DataSource = _kategoriService.KategorileriGetir();
            comboBox3.DisplayMember = "KategoriAdi";
            comboBox3.ValueMember = "KategoriId";

            comboBox2.DataSource = _urunlerService.HepsiniGetir();
            comboBox2.DisplayMember = "Adi";
            comboBox2.ValueMember = "UrunId";

            comboBox1.DataSource = _urunlerService.HepsiniGetir();
            comboBox1.DisplayMember = "Marka";
            comboBox1.ValueMember = "UrunId";

            dgwUrunler.RowHeadersVisible = false;
            dgwUrunler.Columns[0].Visible = false;

            dgwUrunler.DataSource = _urunlerService.HepsiniGetir();



        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel3.Visible = true;
            lblPersonelAdi.Text = personel.Adi;
            lblPersonelSoyadi.Text = personel.Soyadi;
            lblPersonelKuad.Text = personel.KullaniciAdi;
            lblPersonelTC.Text = personel.TcNo;
            txtPersonelParola.Text = personel.Parola;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            personel.Parola = txtPersonelParola.Text;
            _personelService.Guncelle(personel);
            MessageBox.Show("Parolanız Güncellendi..");
        }
        private bool visibility = true;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (visibility == true)
            {
                txtPersonelParola.UseSystemPasswordChar = false;
                visibility = false;
            }
            else
            {
                txtPersonelParola.UseSystemPasswordChar = true;
                visibility = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgwUrunler.DataSource = _urunlerService.MarkayaGore(comboBox1.Text);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgwUrunler.DataSource = _urunlerService.AdveMarkayaGore(comboBox1.Text, comboBox2.Text);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwUrunler.DataSource = _urunlerService.AdMarkaKategoriyeGore(comboBox1.Text, comboBox2.Text, Convert.ToInt32(comboBox3.SelectedValue));
            }
            catch
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgwUrunler.DataSource = _urunlerService.FiltreyeGore(textBox2.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgwUrunler.DataSource = _urunlerService.HepsiniGetir();
        }
        Musteriler musteriler;
        bool kartidvarmi = false;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MusteriKontrol();
        }
        public void MusteriKontrol()
        {
            musteriler = _musterilerService.Getir(textBox1.Text.ToString());
            if (musteriler != null)
            {
                panel6.Visible = false;
                lblAdiSoyadi.Text = musteriler.OgrenciAdi + " " + musteriler.OgrenciSoyadi;
                label3.Text = musteriler.Bakiye.ToString() + " TL";
                label14.Text = musteriler.Bakiye.ToString() + " TL";
                label20.Text = musteriler.Bakiye.ToString() + " TL";
                label3.Location = new Point(btnTLYUKLE.Left - label3.Width, btnTLYUKLE.Height / 2);
                button1.Enabled = true;
                kartidvarmi = true;
                btnTLYUKLE.Enabled = true;
                linkLabel1.Enabled = true;
                if (Sepet.Count > 0)
                {
                    sepetsifirla();
                }
            }
            else if (textBox1.Text != "")
            {
                btnTLYUKLE.Enabled = false;
                linkLabel1.Enabled = false;
                button1.Enabled = false;
                lblAdiSoyadi.Text = "Adı Soyadı";
                label3.Text = "Bakiye";
                panel6.Visible = true;
                MessageBox.Show("Kayıtlar da Müşteri bulunamadı. Müşteri için kayıt oluşturun.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTLYUKLE_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            label14.Text = musteriler.Bakiye.ToString() + " TL";
            label20.Text = musteriler.Bakiye.ToString() + " TL";
            label14.Location = new Point(panel4.Width / 2 - label14.Width / 2, 55);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult yuklenecekmiktar = MessageBox.Show("Yüklemek İstediğiniz Miktar '" + textBox3.Text + "' TL", "TL Yükle", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (yuklenecekmiktar == DialogResult.OK)
            {
                musteriler.Bakiye = Convert.ToDouble(textBox3.Text) + musteriler.Bakiye;
                _musterilerService.Guncelle(musteriler);
                MessageBox.Show("Girilen Ücret Hesaba Aktarılmıştır.", "Başarılı!");
                _hesapOzetleriService.Ekle(new HesapOzetleri {
                    OgrenciHesapId = musteriler.OgrenciHesapId,
                    YuklenenBakiye = Convert.ToDecimal(textBox3.Text),
                    YuklemeTarihi=DateTime.Now
                });
                label14.Text = musteriler.Bakiye.ToString() + " TL";
                label3.Text = musteriler.Bakiye.ToString() + " TL";
                label20.Text = musteriler.Bakiye.ToString() + " TL";
                textBox3.Text = "";
                if (musteriler.Bakiye>=toplamfiyat)
                {
                    button9.Enabled = true;
                }
                label3.Location = new Point(btnTLYUKLE.Left - label3.Width, btnTLYUKLE.Height / 2);
            }
        }

        List<Urunler> Urunler = new List<Urunler>();
        List<Sepet> Sepet = new List<Sepet>();
        double toplamfiyat = 0;
        private void dgwUrunler_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (kartidvarmi == true)
            {
                toplamfiyat = 0;

                var id = dgwUrunler.CurrentRow.Cells[0].Value;
                var marka = dgwUrunler.CurrentRow.Cells[1].Value;
                var kategoriid = dgwUrunler.CurrentRow.Cells[2].Value;
                var adi = dgwUrunler.CurrentRow.Cells[3].Value;
                var stokAdedi = dgwUrunler.CurrentRow.Cells[4].Value;
                var birimFiyati = dgwUrunler.CurrentRow.Cells[5].Value;
                Urunler urun = new Urunler { Marka = marka.ToString(), UrunId = Convert.ToInt32(id), KategoriId = Convert.ToInt32(kategoriid), Adi = adi.ToString(), StokAdedi = Convert.ToInt32(stokAdedi), BirimFiyati = Convert.ToDouble(birimFiyati) };
                Urunler a = Urunler.FirstOrDefault(p => p.UrunId == Convert.ToInt32(id));
                if (Convert.ToInt32(stokAdedi)>0)
                {
                    Sepet sepets = new Sepet { Marka = marka.ToString(), adet = 1, UrunId = Convert.ToInt32(id), KategoriId = Convert.ToInt32(kategoriid), Adi = adi.ToString(), StokAdedi = Convert.ToInt32(stokAdedi) - 1, BirimFiyati = Convert.ToDouble(birimFiyati) };
                    if (a != null)
                    {
                        if (a.UrunId == urun.UrunId)
                        {
                            MessageBox.Show("Bu ürünü daha önce eklediniz.", "Mevcut Ürün", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        Urunler.Add(urun);
                        Sepet.Add(sepets);
                        dgwSepet.DataSource = null;
                        dgwSepet.DataSource = Sepet;

                        genislikayari();

                        button1.Text = "Sepet (" + Urunler.Count + ")";
                        kolongizle();
                        fiyattoplama();

                        //Satış Butonu
                        fiyatbuyukmu();
                    }
                }
                else
                {
                    MessageBox.Show("Stoklarda ürün mevcut değildir.", "Mevcut Ürün", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach (var sepettekiurun in Sepet)
            {
                _satisRaporuService.Ekle(new SatisRaporu
                {
                    OgrenciHesapId = musteriler.OgrenciHesapId,
                    PersonelId = personel.PersonelId,
                    UrunId = sepettekiurun.UrunId,
                    SatisAdedi = sepettekiurun.adet,
                    ToplamFiyati = Convert.ToDouble(sepettekiurun.adet * sepettekiurun.BirimFiyati),
                    SatisTarihi = DateTime.Now
                });
                Urunler urun = new Urunler
                {
                    UrunId = sepettekiurun.UrunId,
                    Adi = sepettekiurun.Adi,
                    BirimFiyati = sepettekiurun.BirimFiyati,
                    KategoriId = sepettekiurun.KategoriId,
                    StokAdedi = sepettekiurun.StokAdedi,
                    Marka = sepettekiurun.Marka
                };
                _urunlerService.Guncelle(urun);
            }
            musteriler.Bakiye = musteriler.Bakiye - toplamfiyat;
            _musterilerService.Guncelle(musteriler);

            label3.Text = musteriler.Bakiye.ToString() + " TL";
            label14.Text = musteriler.Bakiye.ToString() + " TL";
            label20.Text = musteriler.Bakiye.ToString() + " TL";
            toplamfiyat = 0;
            label19.Text = toplamfiyat.ToString() + " TL";
            label9.Text = toplamfiyat.ToString() + " TL";
            sepetsifirla();
            MessageBox.Show("Satış Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sepetaktif = true;
            panel5.Visible = false;
        }

        bool sepetaktif = true;

        private void button1_Click(object sender, EventArgs e)
        {
            if (sepetaktif == true)
            {
                panel5.Visible = true;
                sepetaktif = false;
            }
            else
            {
                panel5.Visible = false;
                sepetaktif = true;
            }


        }

        private void kolongizle()
        {
            dgwSepet.RowHeadersVisible = false;
            dgwSepet.Columns[3].Visible = false;
            dgwSepet.Columns[5].Visible = false;
            dgwSepet.Columns[7].Visible = false;

        }

        private void dgwSepetlistedencikar()
        {
            DataGridViewButtonColumn buton = new DataGridViewButtonColumn();
            buton.FlatStyle = FlatStyle.Popup;
            buton.DefaultCellStyle.ForeColor = Color.White;
            buton.DefaultCellStyle.BackColor = Color.Black;
            buton.HeaderText = "";
            buton.Text = "X";
            buton.UseColumnTextForButtonValue = true;
            dgwSepet.Columns.Add(buton);
        }
        private void genislikayari()
        {
            dgwSepet.Columns[0].Width = 15;
            dgwSepet.Columns[1].Width = 30;
            dgwSepet.Columns[2].Width = 30;
        }

        private void dgwSepetAdetAzalt()
        {
            DataGridViewButtonColumn buton = new DataGridViewButtonColumn();
            buton.FlatStyle = FlatStyle.Popup;
            buton.DefaultCellStyle.ForeColor = Color.White;
            buton.DefaultCellStyle.BackColor = Color.Red;
            buton.HeaderText = "";
            buton.Text = "Azalt";
            buton.UseColumnTextForButtonValue = true;
            dgwSepet.Columns.Add(buton);
        }


        private void dgwSepetAdetBelirle()
        {
            DataGridViewButtonColumn buton = new DataGridViewButtonColumn();
            buton.FlatStyle = FlatStyle.Popup;
            buton.DefaultCellStyle.ForeColor = Color.White;
            buton.DefaultCellStyle.BackColor = Color.Green;
            buton.HeaderText = "";
            buton.Text = "Arttır";
            buton.UseColumnTextForButtonValue = true;
            dgwSepet.Columns.Add(buton);
        }


        private void fiyattoplama()
        {
            toplamfiyat = 0;
            for (int i = 0; i < dgwSepet.Rows.Count; i++)
            {
                toplamfiyat += Convert.ToDouble(dgwSepet.Rows[i].Cells[9].Value) * Convert.ToDouble(dgwSepet.Rows[i].Cells[8].Value);
            }
            label19.Text = toplamfiyat.ToString() + " TL";
            label9.Text = toplamfiyat.ToString() + " TL";
        }


        private void Adet()
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Adet";
            dgwSepet.Columns.Add(column);
        }

        private void dgwSepet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try
                {
                    Urunler.RemoveAt(dgwSepet.CurrentRow.Index);
                    Sepet.RemoveAt(dgwSepet.CurrentRow.Index);
                    dgwSepet.DataSource = null;
                    dgwSepet.DataSource = Sepet;

                    kolongizle();
                    fiyattoplama();
                    button1.Text = "Sepet (" + Urunler.Count + ")";

                    if (musteriler.Bakiye >= toplamfiyat)
                    {
                        button9.Enabled = true;
                    }
                    else
                    {
                        button9.Enabled = false;
                    }
                }
                catch
                {

                }

            }
            if (e.ColumnIndex == 1)
            {
                var guncelle = Sepet.SingleOrDefault(p => p.UrunId == Convert.ToInt32(dgwSepet.CurrentRow.Cells[3].Value));
                if (guncelle.StokAdedi > 0)
                {
                    guncelle.adet = guncelle.adet + 1;
                    guncelle.StokAdedi = guncelle.StokAdedi - 1;
                    dgwSepet.DataSource = null;
                    dgwSepet.DataSource = Sepet;
                    fiyattoplama();
                    kolongizle();
                    fiyatbuyukmu();
                }
                else
                {
                    MessageBox.Show("Stoklarımızda ürün kalmadı.", "Stok Tükendi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (e.ColumnIndex == 2)
            {
                var guncelle = Sepet.SingleOrDefault(p => p.UrunId == Convert.ToInt32(dgwSepet.CurrentRow.Cells[3].Value));

                if (guncelle.adet > 1)
                {
                    guncelle.adet = guncelle.adet - 1;
                    guncelle.StokAdedi = guncelle.StokAdedi + 1;
                    dgwSepet.DataSource = null;
                    dgwSepet.DataSource = Sepet;
                    fiyattoplama();
                    kolongizle();
                    if (musteriler.Bakiye >= toplamfiyat)
                    {
                        button9.Enabled = true;
                    }
                    else
                    {
                        button9.Enabled = false;
                    }
                }
            }
        }
        private void fiyatbuyukmu()
        {
            if (musteriler.Bakiye >= toplamfiyat)
            {
                button9.Enabled = true;
            }
            else
            {
                double gerekenucret = toplamfiyat - musteriler.Bakiye;
                MessageBox.Show("Bakiye yetersiz lütfen TL Yükleyin.\n Yüklenmesi gereken ücret = " + gerekenucret, "Yetersiz Bakiye", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button9.Enabled = false;
            }
        }
        private void sepetsifirla()
        {
            Sepet.RemoveRange(0, Sepet.Count);
            Urunler.RemoveRange(0, Urunler.Count);
            dgwSepet.DataSource = null;
            dgwSepet.DataSource = Sepet;
            kolongizle();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bilgileri girilen müşteriyi eklemek istediğinize eminmisiniz ?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Information)==DialogResult.Yes)
            {
                _musterilerService.Ekle(new Musteriler
                {
                    OgrenciAdi = textBox4.Text,
                    OgrenciSoyadi = textBox5.Text,
                    OgrenciNo = textBox6.Text,
                    Bakiye = 0,
                    OgrenciHesapId = textBox1.Text
                });
                MusteriKontrol();
                panel6.Visible = false;
            }
            else
            {
                MessageBox.Show("Ekleme işlemi iptal edildi.");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonelIade.musteriid = musteriler.OgrenciHesapId;
            PersonelIade.personelid = personel.PersonelId;
            PersonelIade personelIade = new PersonelIade();
            personelIade.Show();
            
        }
    }
}

//ARTTIRMA VE AZALTMA KISMINDA FİYATBUYUKMU SORGUSU YANLIŞ İŞLİYOR.