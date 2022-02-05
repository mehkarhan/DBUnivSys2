using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI.Ogrenci
{
    public partial class OgrenciDers : Form
    {
        public static int KID;
        public static int OID;

        OgrenciManager ogrenciManager = new OgrenciManager(new EfOgrenciDal());
        KullaniciManager kullaniciManager = new KullaniciManager(new EfKullaniciDal());
        DersKayitManager dersKayitManager = new DersKayitManager(new EfDersKayitDal());
        DersManager dersManager = new DersManager(new EfDersDal());
        
        public OgrenciDers()
        {
            InitializeComponent();
            KID = OgrenciMain.KID;
            OID = OgrenciInfo.OID;

        }

        private void OgrenciDers_Load(object sender, EventArgs e)
        {
            var ogrenci = ogrenciManager.GetByID(KID);
            
            var dersler = dersKayitManager.GetByID(OID);
            

            
            
        }

        
    }
}
