using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI
{
    public partial class OgretmenForm : Form
    {
        public OgretmenForm()
        {
            InitializeComponent();
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
        private void btnEkle_Click(object sender, EventArgs e)
        {
            loadform(new AdminAdd());
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            loadform(new AdminUpdate());
        }

        private void OgretmenForm_Load(object sender, EventArgs e)
        {
            loadform(new AdminAdd());
        }
    }
}
