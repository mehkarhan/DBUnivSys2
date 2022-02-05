using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbFormUI.Admin
{
    public partial class AdminMain : Form
    {
        public static int KID;
        AdminManager adminManager = new AdminManager(new EfAdminDal());
        KullaniciManager kullaniciManager = new KullaniciManager(new EfKullaniciDal());
        public AdminMain()
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
        private void AdminMain_Load(object sender, EventArgs e)
        {
            loadform(new AdminPanel());
            var result=adminManager.GetbyKullaniciID(KID);
            if (result != null)
            {
                lblAdi.Text = result.AdminAdi;
                lblSoyadi.Text = result.AdminSoyadi;
            }
        }
    }
}
