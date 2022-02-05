using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace FormUI.ogretmen
{
    public partial class OgretmenDersOnay : Form
    {
        public static int KID;
        DersKayitManager dersKayitManager = new DersKayitManager(new EfDersKayitDal());
        public OgretmenDersOnay()
        {
            InitializeComponent();
            KID = Login.KID;
        }

        private void OgretmenDersOnay_Load(object sender, EventArgs e)
        {
            txtAdi.Enabled = false;
            txtSoyadi.Enabled = false;
            txtDers.Enabled = false;
            var derskayit = dersKayitManager.GetOgrenciDers();
            dataGridView1.DataSource = derskayit;


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int secindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow secsatir = dataGridView1.Rows[secindex];
                txtAdi.Text = secsatir.Cells["OgrenciAdi"].Value.ToString();
                txtSoyadi.Text = secsatir.Cells["OgrenciSoyadi"].Value.ToString();
                txtDers.Text = secsatir.Cells["DersAdi"].Value.ToString();
                
                
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var ogrenci = dersKayitManager.GetByID(KID);
            if (cbOnay.SelectedIndex==0)
            {
                ogrenci.DersKayitOnay = true;
                
                dersKayitManager.Update(ogrenci);  

            }
            else
            {
                ogrenci.DersKayitOnay = false;
            }
        }
    }
}
