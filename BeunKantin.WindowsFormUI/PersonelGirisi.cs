using BeunKantin.Business.Abstract;
using BeunKantin.Business.Concrete;
using BeunKantin.DataAccess.Abstract;
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
    public partial class PersonelGirisi : Form
    {
        IPersonelService _personelService;
        public PersonelGirisi()
        {
            InitializeComponent();
            _personelService = new PersonelManager(new PersonelDal());
        }

        private void PersonelGirisi_Load(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Personel gelenveri = _personelService.Getir(txtKullaniciAdi.Text, txtParola.Text);
            if (gelenveri != null)
            {
                PersonelAnasayfa satisYap = new PersonelAnasayfa();
                satisYap.personel = gelenveri;
                satisYap.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifreniz Yanlış.");
            }
        }
    }
}
