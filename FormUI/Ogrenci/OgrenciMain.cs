using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FormUI.Ogrenci;

namespace FormUI.Ogrenci
{
    public partial class OgrenciMain : Form
    {
        public static int KID;
        OgrenciManager ogrenciManager = new OgrenciManager(new EfOgrenciDal());
        KullaniciManager kullaniciManager = new KullaniciManager(new EfKullaniciDal());
       
        public OgrenciMain()
        {
            InitializeComponent();
            KID = Login.KID;
        }

        private void OgrenciMain_Load(object sender, EventArgs e)
        {
            var kullanicilar = kullaniciManager.GetByID(KID);
            var ogrencis = ogrenciManager.GetByID(KID);
            lblADSoyad.Text = ogrencis.OgrenciAdi + " " + ogrencis.OgrenciSoyadi;//;
            
            loadform(new OgrenciInfo());

        }
        public void loadform(object form)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKisisel_Click(object sender, EventArgs e)
        {
            loadform(new OgrenciInfo());
        }

        private void btnDers_Click(object sender, EventArgs e)
        {
            loadform(new OgrenciForum());
        }

        private void btnOturumKapat_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
