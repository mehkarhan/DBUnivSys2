using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using FormUI.Memur;
using FormUI.Ogrenci;
using FormUI.ogretmen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Login : Form
    {

        public static int KID;
        public Login()
        {
            InitializeComponent();
            
        }
        KullaniciManager kullaniciManager = new KullaniciManager(new EfKullaniciDal());

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string kadi = txtKadi.Text;
            string pass = txtParola.Text;
            
            
            var result = kullaniciManager.GetLogin(kadi, pass);
            
            if (result != null)
            {
                KID = result.KullaniciID;
                if (result.RoleID == 1)
                {

                    
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    this.Hide();
                }
                else if (result.RoleID == 2)
                {
                    
                    OgretmenMain ogretmenMain = new OgretmenMain();
                    ogretmenMain.Show();
                    this.Hide();
                }
                else if (result.RoleID == 3)
                {
                    
                    MemurMain memurMain = new MemurMain();
                    memurMain.Show();
                    this.Hide();
                }
                else if (result.RoleID == 4)
                {
                   
                    OgrenciMain ogrenciMain = new OgrenciMain();
                    ogrenciMain.Show();
                    this.Hide();

                }
            }
            else
            {
                label3.Visible = true;
                label3.ForeColor = Color.Red;
                label3.Text = "Hatalı Kullanıcı Adı veya Parola";
            }
            
        }

       

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
