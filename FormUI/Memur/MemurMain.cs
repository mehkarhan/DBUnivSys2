using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI.Memur
{
    public partial class MemurMain : Form
    {
        public static int KID; //KullaniciID
        MemurManager memurManager = new MemurManager(new EfMemurDal());
        public MemurMain()
        {
            InitializeComponent();
            KID = Login.KID;
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void btnOgretmen_Click(object sender, EventArgs e)
        {
            loadform(new OgretmenForm());
        }

        private void MemurMain_Load(object sender, EventArgs e)
        {
            var result = memurManager.GetbyID(KID);
        }

        private void btnOturumKapat_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
