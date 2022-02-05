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
    public partial class FormKayit : Form
    {
        public FormKayit()
        {
            InitializeComponent();
        }
        RoleManager roleManager = new RoleManager(new EfRoleDal());
        private void FormKayit_Load(object sender, EventArgs e)
        {
            foreach (var role in roleManager.GetAll())
            {
                comboBox1.Items.Add(role.RoleAdi);
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = comboBox1.SelectedItem.ToString()+" Adı:";
        }
    }
}
