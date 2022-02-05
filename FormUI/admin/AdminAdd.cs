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
    public partial class AdminAdd : Form
    {
        public static string adi, soyadi, kadi, parola;
        public AdminAdd()
        {
            InitializeComponent();
        }
        KullaniciManager kullaniciManager = new KullaniciManager(new EfKullaniciDal());
        OgretmenManager ogretmenManager = new OgretmenManager(new EfOgretmenDal());
        private void btnEkle_Click(object sender, EventArgs e)
        {
            kullaniciManager.Add(
                new Kullanici
                {
                    KullaniciAdi = txtKadi.Text,
                    KullaniciParola = txtParola.Text,
                    RoleID = 2
                }) ;
            Kullanici result = kullaniciManager.GetLogin(txtKadi.Text,txtParola.Text);
            int kid = result.KullaniciID;
            ogretmenManager.Add(new Ogretmen
                            {
                                OgretmenAdi=txtAdi.Text,OgretmenSoyadi=txtSoyadi.Text,KullaniciID=kid
                            }
                );

            txtAdi.Clear();
            txtKadi.Clear();
            txtParola.Clear();
            txtSoyadi.Clear();
            dataGridView1.DataSource = null;
            veriCek();

        }

        
        private void AdminAdd_Load(object sender, EventArgs e)
        {
            veriCek();

            //dataGridView1.Columns[0].HeaderText = "Kullanıcı ID";
            //dataGridView1.Columns[1].HeaderText = "Kullanıcı Adı";
            //dataGridView1.Columns[2].HeaderText = "Kullanıcı Soyadı";
            //dataGridView1.Columns[3].HeaderText = "Kullanıcı Role";

            //foreach (var role in roleManager.GetAll())
            //{
            //    comboBox1.Items.Add(role.RoleAdi);
            //}
        }

        private void veriCek()
        {
            dataGridView1.DataSource = ogretmenManager.GetOgretmenDetails();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(100, 10000);
            adi = txtAdi.Text.Trim();
            soyadi = txtSoyadi.Text.Trim();
            string aditrim = adi.Replace(" ","");
            string soyaditrim = soyadi.Replace(" ","");
            

            txtKadi.Text = aditrim + "." + soyaditrim;
            txtParola.Text = aditrim + soyaditrim.ToUpper() + sayi;
        }
    }
}
