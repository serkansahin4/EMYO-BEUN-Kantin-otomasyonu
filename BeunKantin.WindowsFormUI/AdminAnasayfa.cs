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
    public partial class AdminAnasayfa : Form
    {
        public AdminAnasayfa()
        {
            InitializeComponent();
        }
        public Administrator administrator;
        private void AdminAnasayfa_Load(object sender, EventArgs e)
        {
            MessageBox.Show(administrator.KullaniciAdi+" "+administrator.Parola);
        }
    }
}
