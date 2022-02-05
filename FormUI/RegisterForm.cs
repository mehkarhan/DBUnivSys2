using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        KullaniciManager kullaniciManager = new KullaniciManager(new EfKullaniciDal());
        OgrenciManager ogrenciManager = new OgrenciManager(new EfOgrenciDal());
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adi = txtAdi.Text;
            string soyadi = txtSoyadi.Text;
            string kadi = txtKadi.Text;
            string parola = txtParola.Text;
            int kayitYili = DateTime.Now.Year;

            kullaniciManager.Add(new Kullanici { KullaniciAdi = kadi, KullaniciParola = parola, RoleID = 4, });
            var result = kullaniciManager.GetLogin(kadi, parola);
            ogrenciManager.Add(new Entities.Concrete.Ogrenci { OgrenciAdi = adi, OgrenciSoyadi = soyadi,KullaniciID=result.KullaniciID,KayitYili=kayitYili });
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void btnKadiPass_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(100, 10000);
            string adi = txtAdi.Text;
            string soyadi = txtSoyadi.Text;

            txtKadi.Text = adi + "." + soyadi;
            txtParola.Text = adi + soyadi.ToUpper() + sayi;
        }
    }
}
