using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace FormUI.Ogrenci
{
    public partial class OgrenciDersKayit : Form
    {
        public static int KID; //KullaniciID
        public static int OID;//OgrenciID
        public OgrenciDersKayit()
        {
            InitializeComponent();
            KID = Login.KID;
            OID = OgrenciInfo.OID;
        }
        DersKayitManager dersKayitManager = new DersKayitManager(new EfDersKayitDal());
        OgrenciManager ogrenciManager = new OgrenciManager(new EfOgrenciDal());
        DersManager dersManager = new DersManager(new EfDersDal());

        private void OgrenciDersKayit_Load(object sender, EventArgs e)
        {
            var ogrenci = ogrenciManager.GetByID(KID);
            int ogrenciid = OID;
            int sinif = (DateTime.Now.Year - ogrenci.KayitYili);
            int dsec = DateTime.Now.Month;
            int donem = DonemSec(dsec);
            var kayitdersler = dersKayitManager.GetOgrenciDetail(ogrenci);
            
            if (kayitdersler!=null)
            {
                foreach (var ders in kayitdersler)
                {
                    listBox2.Items.Add(ders.DersAdi);
                }

                btnCikar.Enabled = false;
                btnEkle.Enabled = false;
                btnGonder.Enabled = false;
                if (listBox2.Items.Count != 0)
                {
                    MessageBox.Show("Ders seçiminizi yaptınız. Danışman Onaylamasını bekleyiniz...");
                }

            }
            
                if (sinif == 1)
                {
                    if (donem == 1)
                    {
                        var dersler = dersManager.GetbyDers(1, sinif, donem);
                        foreach (var ders in dersler)
                        {
                            listBox1.Items.Add(ders.DersAdi);
                        }
                    }
                    else if (donem == 1)
                    {
                        var dersler = dersManager.GetbyDers(1, sinif, donem);
                        foreach (var ders in dersler)
                        {
                            listBox1.Items.Add(ders.DersAdi);
                        }
                    }

                }
                else if (sinif == 2)
                {
                    if (donem == 1)
                    {
                        var dersler = dersManager.GetbyDers(1, sinif, donem);
                        foreach (var ders in dersler)
                        {
                            listBox1.Items.Add(ders.DersAdi);
                        }
                    }
                    else if (donem == 2)
                    {
                        var dersler = dersManager.GetbyDers(1, sinif, donem);
                        foreach (var ders in dersler)
                        {
                            listBox1.Items.Add(ders.DersAdi);
                        }
                    }
                }
                else if (sinif == 3)
                {
                    if (donem == 1)
                    {
                        var dersler = dersManager.GetbyDers(1, sinif, donem);
                        foreach (var ders in dersler)
                        {
                            listBox1.Items.Add(ders.DersAdi);
                        }
                    }
                    else if (donem == 2)
                    {
                        var dersler = dersManager.GetbyDers(1, sinif, donem);
                        foreach (var ders in dersler)
                        {
                            listBox1.Items.Add(ders.DersAdi);
                        }
                    }
                }
                else if (sinif == 4)
                {
                    if (donem == 1)
                    {
                        var dersler = dersManager.GetbyDers(1, sinif, donem);
                        foreach (var ders in dersler)
                        {
                            listBox1.Items.Add(ders.DersAdi);
                        }
                    }
                    else if (donem == 2)
                    {
                        var dersler = dersManager.GetbyDers(1, sinif, donem);
                        foreach (var ders in dersler)
                        {
                            listBox1.Items.Add(ders.DersAdi);
                        }
                    }
                }
            

        }




        private static int DonemSec(int donemsec)
        {
            int donem = DateTime.Now.Month;

            switch (donem)
            {

                case 9:
                case 10:
                case 11:
                case 12:
                case 1:
                    donemsec = 1;
                    break;

                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    donemsec = 2;
                    break;
                default:
                    MessageBox.Show("Belirtilen dönem zamanında değilsiniz.");
                    break;
            }
            return donemsec;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem!=null)
            {
               
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Eklenecek Ders Yok");
            }
            
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem!=null)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            else
            {
                MessageBox.Show("Çıkarılacak Ders Yok");
            }

            


        }

        private void btnGonder_Click(object sender, EventArgs e)
        {

            var ogrenci = ogrenciManager.GetByID(KID);
            //var derskayit=

            if (listBox2.Items.Count != 0)
            {
                foreach (var dersListe in listBox2.Items)
                {
                    var dersid = dersManager.GetbyAdi(dersListe.ToString());
                    dersKayitManager.Add(new DersKayit { OgrenciID = KID, DersID = dersid.DersID, DersKayitOnay = false });
                }
                MessageBox.Show("Ders kaydınızı tamamladınız.");
            }
            else
            {
                MessageBox.Show("Kayıt için ders seçmediniz.");
            }

            listBox2.Enabled = false;
            btnEkle.Enabled = false;
            btnCikar.Enabled = false;

        }
    }
}

