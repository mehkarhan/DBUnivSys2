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
    public partial class MemurAdd : Form
    {
        public static string adi, soyadi, kadi, parola;
        public MemurAdd()
        {
            InitializeComponent();
        }

        MemurManager memurManager = new MemurManager(new EfMemurDal());
        KullaniciManager KullaniciManager = new KullaniciManager(new EfKullaniciDal());
        private void btnEkle_Click(object sender, EventArgs e)
        {
            kullaniciManager.Add(
               new Kullanici
               {
                   KullaniciAdi = txtKadi.Text,
                   KullaniciParola = txtParola.Text,
                   RoleID = 3
               });
            Kullanici result = kullaniciManager.GetLogin(txtKadi.Text, txtParola.Text);
            int kid = result.KullaniciID;
            memurManager.Add(new Entities.Concrete.Memur
            {
                MemurAdi = txtAdi.Text,
                MemurSoyadi = txtSoyadi.Text,
                KullaniciID = kid
            }
                );

            txtAdi.Clear();
            txtKadi.Clear();
            txtParola.Clear();
            txtSoyadi.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = memurManager.GetMemurDetail();
        }

        KullaniciManager kullaniciManager = new KullaniciManager(new EfKullaniciDal());
        private void MemurAdd_Load(object sender, EventArgs e)
        {
            var dgv1 = memurManager.GetMemurDetail();
            dataGridView1.DataSource = dgv1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(100, 10000);
            adi = txtAdi.Text.Trim();
            soyadi = txtSoyadi.Text.Trim();
            string aditrim = adi.Replace(" ", "");
            string soyaditrim = soyadi.Replace(" ", "");


            txtKadi.Text = aditrim + "." + soyaditrim;
            txtParola.Text = aditrim + soyaditrim.ToUpper() + sayi;
        }
    }
}
