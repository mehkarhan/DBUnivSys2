using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DbFormUI.Admin;

namespace DbFormUI
{
    public partial class Login : Form
    {
        public static int KID;
        KullaniciManager kullaniciManager = new KullaniciManager(new EfKullaniciDal());
        AdminManager adminManager = new AdminManager(new EfAdminDal());
        OgrenciManager ogrenciManager=new OgrenciManager(new EfOgrenciDal());
        OgretmenManager ogretmenManager=new OgretmenManager(new EfOgretmenDal());
        public Login()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var result = kullaniciManager.GetLogin(txtKadi.Text,txtParola.Text);
            if (result != null)
            {
                KID = result.KullaniciID;

                if (result.RoleID==1)
                {
                    var admin = adminManager.GetbyKullaniciID(KID);

                    MessageBox.Show(admin.AdminAdi +" "+ admin.AdminSoyadi+" Hoþgeldiniz");

                    AdminMain adminMain = new AdminMain();
                    adminMain.Show();
                    this.Hide();

                }
            }
        }
    }
}