using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI.ogretmen
{
    public partial class OgretmenDers : Form
    {
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
        public OgretmenDers()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            loadform(new OgretmenDersListele());
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            loadform(new OgretmenDersOnay());
        }
    }
}
