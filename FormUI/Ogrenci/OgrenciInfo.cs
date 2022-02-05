using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI.Ogrenci
{
    public partial class OgrenciInfo : Form
    {
        public static int KID;
        public static int OID;

        public OgrenciInfo()
        {
            InitializeComponent();
            KID = OgrenciMain.KID;

        }
        OgrenciManager ogrenciManager = new OgrenciManager(new EfOgrenciDal());
        KullaniciManager kullaniciManager = new KullaniciManager(new EfKullaniciDal());
        private void btnParolaUpdate_Click(object sender, EventArgs e)
        {
            txtParola.Enabled = true;
            btnkayit.Enabled = true;
        }

        private void OgrenciInfo_Load(object sender, EventArgs e)
        {
            var ogrenci = ogrenciManager.GetByID(KID);
           
            var kullanici = kullaniciManager.GetByID(KID);
            txtAdi.Text = ogrenci.OgrenciAdi;
            txtSoyadi.Text = ogrenci.OgrenciSoyadi;
            txtKadi.Text = kullanici.KullaniciAdi;
            txtParola.Text = kullanici.KullaniciParola;
            txtKid.Text = ogrenci.OgrenciID.ToString();
            OID = int.Parse(txtKid.Text);
        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
            var kullaniciupdate = kullaniciManager.GetByID(KID);
            kullaniciupdate.KullaniciParola = txtParola.Text;
            kullaniciManager.Update(kullaniciupdate);
            txtParola.Enabled = false;
        }
    }
}
