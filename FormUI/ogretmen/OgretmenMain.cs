using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI.ogretmen
{
    public partial class OgretmenMain : Form
    {
        public static int KID;
        OgretmenManager ogretmenManager = new OgretmenManager(new EfOgretmenDal());
        KullaniciManager kullaniciManager = new KullaniciManager(new EfKullaniciDal());
        public OgretmenMain()
        {
            InitializeComponent();
            KID = Login.KID;
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

        private void btnOgretmen_Click(object sender, EventArgs e)
        {
            loadform(new OgretmenDers());
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            loadform(new OgretmenOgrenci());
        }

        private void btnNot_Click(object sender, EventArgs e)
        {
            loadform(new OgretmenNot());
        }

        private void OgretmenMain_Load(object sender, EventArgs e)
        {
            var kullanicilar = kullaniciManager.GetByID(KID);
            var ogretmenler = ogretmenManager.GetbyID(KID);
            lblAdSoyad.Text = ogretmenler.OgretmenAdi + " " + ogretmenler.OgretmenSoyadi;//;
        }

        private void btnOturumKapat_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
