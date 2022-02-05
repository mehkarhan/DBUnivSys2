using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SinifManager sinifManager = new SinifManager(new EfSinifDal());
        DonemManager donemManager = new DonemManager(new EfDonemDal());
        BolumManager bolumManager = new BolumManager(new EfBolumDal());
        DersManager dersManager = new DersManager(new EfDersDal());
        private void Form1_Load(object sender, EventArgs e)
        {
            BolumTest();
            SinifTest();
            DonemTest();
            
            
            
            
            
            
        }
        private void SinifTest()
        {
            
            foreach (var item in sinifManager.GetAll())
            {
                comboBox2.Items.Add(item.SinifAdi);
            }
        }

        private void DonemTest()
        {
           
            foreach (var item in donemManager.GetAll())
            {
                comboBox3.Items.Add(item.DonemAdi);
            }
        }
        private void BolumTest()
        {
           
            foreach (var item in bolumManager.GetAll())
            {
                comboBox1.Items.Add(item.BolumAdi);
            }
        }
        private void DersTest(int a,int b,int c)
        {
            comboBox4.Items.Clear();
            comboBox4.ResetText();
            a =comboBox1.SelectedIndex + 1;
            b = comboBox3.SelectedIndex + 1;
            c = comboBox2.SelectedIndex + 1;

            foreach (var ders in dersManager.GetbyDers(a,b,c))
            {
                comboBox4.Items.Add(ders.DersAdi);
            }


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = comboBox1.SelectedIndex + 1;
            int b = comboBox2.SelectedIndex + 1;
            int c = comboBox3.SelectedIndex + 1;
            DersTest(a, b, c);
        }
    }

        //private void RoleTest()
        //{
        //    RoleManager roleManager = new RoleManager(new EfRoleDal());
        //    comboBox1.Text = "Role Seçiniz";
        //    foreach (var item in roleManager.GetAll())
        //    {
        //        comboBox1.Items.Add(item.RoleAdi);
        //    }
        //}
    }


