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
    public partial class AdminGiris : Form
    {
        IAdministratorService _administratorService;
        public AdminGiris()
        {
            InitializeComponent();
            _administratorService = new AdministratorManager(new AdministratorDal());
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            Administrator gelenveri = _administratorService.Getir(txtKullaniciAdi.Text, txtParola.Text);
            if (gelenveri != null)
            {
                AdminAnasayfa admin = new AdminAnasayfa();
                admin.administrator = gelenveri;
                admin.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifreniz Yanlış.");
            }
        }
    }
}
