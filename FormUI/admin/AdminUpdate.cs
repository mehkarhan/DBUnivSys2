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
    public partial class AdminUpdate : Form
    {
        public AdminUpdate()
        {
            InitializeComponent();
        }
        KullaniciManager kullaniciManager = new KullaniciManager(new EfKullaniciDal());
        OgretmenManager ogretmenManager = new OgretmenManager(new EfOgretmenDal());
        MemurManager memurManager = new MemurManager(new EfMemurDal());
        OgrenciManager ogrenciManager = new OgrenciManager(new EfOgrenciDal());

        private void AdminUpdate_Load(object sender, EventArgs e)
        {
            var dgv1 = ogretmenManager.GetOgretmenDetails();
            dataGridView1.DataSource = dgv1;
        }

        

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int secindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow secsat = dataGridView1.Rows[secindex];
            int kid = int.Parse(secsat.Cells["KullaniciID"].Value.ToString());

            var ogretmen = ogretmenManager.GetbyID(kid);
            var kullanici = kullaniciManager.GetByID(kid);

            ogretmen.OgretmenAdi = txtAdi.Text;
            ogretmen.OgretmenSoyadi = txtSoyadi.Text;
            kullanici.KullaniciAdi = txtKadi.Text;
            kullanici.KullaniciParola = txtParola.Text;

            ogretmenManager.Update(ogretmen);
            kullaniciManager.Update(kullanici);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ogretmenManager.GetOgretmenDetails();
            txtAdi.Clear();
            txtKadi.Clear();
            txtParola.Clear();
            txtSoyadi.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(100, 10000);
            string adi = txtAdi.Text;
            string soyadi = txtSoyadi.Text;

            txtKadi.Text = adi + "." + soyadi;
            txtParola.Text = adi + soyadi.ToUpper() + sayi;
        }

        

        private void HucreSec()
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int secindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow secsatir = dataGridView1.Rows[secindex];
                txtAdi.Text = secsatir.Cells["OgretmenAdi"].Value.ToString();
                txtSoyadi.Text = secsatir.Cells["OgretmenSoyadi"].Value.ToString();
                txtKadi.Text = secsatir.Cells["KullaniciAdi"].Value.ToString();
                txtParola.Text = secsatir.Cells["KullaniciParola"].Value.ToString();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            HucreSec();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int secindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow secsat = dataGridView1.Rows[secindex];
            int kid = int.Parse(secsat.Cells["KullaniciID"].Value.ToString());

            Ogretmen ogrtDelete = ogretmenManager.GetbyID(kid);
            Kullanici kullaniciDelete = kullaniciManager.GetByID(kid);

            ogretmenManager.Delete(ogrtDelete);
            kullaniciManager.Delete(kullaniciDelete);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ogretmenManager.GetOgretmenDetails();
            txtAdi.Clear();
            txtKadi.Clear();
            txtParola.Clear();
            txtSoyadi.Clear();
            
            
        }
    }
}
