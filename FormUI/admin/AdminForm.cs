using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI
{
    public partial class AdminForm : Form
    {
        public static int KID; //KullaniciID
        AdminManager adminManager = new AdminManager(new EfAdminDal());
        public AdminForm()
        {
            InitializeComponent();
            KID = Login.KID;
        }
        public void AdminForm_Load(object sender, EventArgs e)
        {
            var result = adminManager.GetbyKullaniciID(KID);
           label1.Text = result.AdminAdi + " "+result.AdminSoyadi;
            
        }
        public void loadform(object form)
        {
            if (this.mainpanel.Controls.Count>0)
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
            loadform(new OgretmenForm());
        }

        private void btnMemur_Click(object sender, EventArgs e)
        {
            loadform(new MemurForm());
        }

        private void btnOturumKapat_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
