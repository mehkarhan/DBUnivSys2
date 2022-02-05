using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class UnivContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=DbUniv;Trusted_Connection=true");
        }
        public DbSet<Bolum> Bolums { get; set; } 
        public DbSet<Ders> Derss { get; set; } 
        public DbSet<DersKayit> DersKayits { get; set; } 
        public DbSet<Donem> Donems { get; set; } 
        public DbSet<Kullanici> Kullanicis { get; set; } 
        public DbSet<Memur> Memurs { get; set; } 
        public DbSet<Not> Nots { get; set; } 
        public DbSet<Ogrenci> Ogrencis { get; set; } 
        public DbSet<Ogretmen> Ogretmens { get; set; } 
        public DbSet<Role> Roles { get; set; } 
        public DbSet<Sinif> Sinifs { get; set; } 
        public DbSet<Admin> Admins { get; set; } 
    }
}
