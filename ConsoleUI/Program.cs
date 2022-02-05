using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        public static int OID;
        
        static void Main(string[] args)
        {
            
            //DersDetailTest();
            //Console.WriteLine(DateTime.Now.Year);
            DersKayitManager dersKayitManager = new DersKayitManager(new EfDersKayitDal());
            var result = dersKayitManager.GetByID(OID);
            int dsec = DateTime.Now.Month;
            Console.WriteLine(DonemSec(dsec));
            

            Console.WriteLine(DateTime.Now.Year);
            DersManager dersManager = new DersManager(new EfDersDal());
            foreach (var item in dersManager.GetBySinif(1))
            {
                Console.WriteLine(item.DersAdi);
            }

            //OgrenciManager ogrenciManager = new OgrenciManager(new EfOgrenciDal());
            //foreach (var ogrenci in ogrenciManager.GetDersDetails())
            //{
            //    Console.WriteLine(ogrenci.OgrenciID + " - " + ogrenci.OgrenciAdi + " - " +
            //        ogrenci.OgrenciSoyadi + " - " +ogrenci.KullaniciAdi + " - " +
            //        ogrenci.KullaniciParola + " - " +ogrenci.RoleAdi);
            //}
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
                    Console.WriteLine("Belirtilen dönem zamanında değilsiniz.");
                    break;
            }
            return donemsec;
        }

        private static void DersDetailTest()
        {
            DersManager dersManager = new DersManager(new EfDersDal());
            foreach (var item in dersManager.GetDersDetails())
            {
                Console.WriteLine(item.DersAdi + " - " + item.BolumAdi + "-" +
                    item.SinifAdi + "-" +
                   item.DonemAdi);
            }
        }

        private static void DersTest()
        {
            DersManager dersManager = new DersManager(new EfDersDal());
            foreach (var item in dersManager.GetAll())
            {
                Console.WriteLine(item.DersAdi);
            }
        }

        private static void RoleTest()
        {
            RoleManager roleManager = new RoleManager(new EfRoleDal());
            foreach (var item in roleManager.GetAll())
            {
                Console.WriteLine(item.RoleAdi);
            }
        }
    }
}
