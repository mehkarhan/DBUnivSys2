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
    
    public partial class MemurUpdate : Form
    {
        public MemurUpdate()
        {
            InitializeComponent();
        }

        MemurManager memurManager = new MemurManager(new EfMemurDal());
        KullaniciManager kullaniciManager = new KullaniciManager(new EfKullaniciDal());
        private void MemurUpdate_Load(object sender, EventArgs e)
        {
            var dgv1 = memurManager.GetMemurDetail();
            dataGridView1.DataSource = dgv1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(100, 10000);
            string adi = txtAdi.Text.Trim();
            string soyadi = txtSoyadi.Text.Trim();
            string aditrim = adi.Replace(" ", "");
            string soyaditrim = soyadi.Replace(" ", "");


            txtKadi.Text = aditrim + "." + soyaditrim;
            txtParola.Text = aditrim + soyaditrim.ToUpper() + sayi;
        }

        private void HucreSec()
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int secindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow secsatir = dataGridView1.Rows[secindex];
                txtAdi.Text = secsatir.Cells["MemurAdi"].Value.ToString();
                txtSoyadi.Text = secsatir.Cells["MemurSoyadi"].Value.ToString();
                txtKadi.Text = secsatir.Cells["KullaniciAdi"].Value.ToString();
                txtParola.Text = secsatir.Cells["KullaniciParola"].Value.ToString();
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int secindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow secsat = dataGridView1.Rows[secindex];
            int kid = int.Parse(secsat.Cells["KullaniciID"].Value.ToString());

            var memur = memurManager.GetbyID(kid);
            var kullanici = kullaniciManager.GetByID(kid);

            memur.MemurAdi = txtAdi.Text;
            memur.MemurSoyadi = txtSoyadi.Text;
            kullanici.KullaniciAdi = txtKadi.Text;
            kullanici.KullaniciParola = txtParola.Text;

            memurManager.Update(memur);
            kullaniciManager.Update(kullanici);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = memurManager.GetMemurDetail();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int secindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow secsat = dataGridView1.Rows[secindex];
            int kid = int.Parse(secsat.Cells["KullaniciID"].Value.ToString());

            Entities.Concrete.Memur memurDelete = memurManager.GetbyID(kid);
            Kullanici kullaniciDelete = kullaniciManager.GetByID(kid);

            memurManager.Delete(memurDelete);
            kullaniciManager.Delete(kullaniciDelete);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = memurManager.GetMemurDetail();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            HucreSec();
        
        }
    }
}
