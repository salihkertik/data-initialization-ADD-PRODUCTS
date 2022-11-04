using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSamples
{
    public class DataInitializer: DropCreateDatabaseIfModelChanges <VTContext>
    {
        protected override void Seed(VTContext context)
        {

            List<KargoAdi> kargoadlari = new List<KargoAdi>()
            {
                new KargoAdi(){Id=1, UrunAdi="Nike Ayakkabı", StokAdeti=19},
                new KargoAdi(){Id=2, UrunAdi="Adidas Tshirt", StokAdeti=21},
                new KargoAdi(){Id=3, UrunAdi="Terlik", StokAdeti=51},
                new KargoAdi(){Id=4, UrunAdi="55 inç TV", StokAdeti=9},
                new KargoAdi(){Id=5, UrunAdi="POSTA ZARFLARI", StokAdeti=952},
                new KargoAdi(){Id=6, UrunAdi="Suluk", StokAdeti=254},
                new KargoAdi(){Id=7, UrunAdi="Kırtasiye Ürünleri", StokAdeti=65},
                new KargoAdi(){Id=8, UrunAdi="Kol Saati", StokAdeti=45},
            };

            foreach (var item in kargoadlari)
            {
                context.KargoAdlari.Add(item);
            }



            List<Kategori> kategoriler = new List<Kategori>()
            {
                new Kategori() {KategoriAdi="Mutfak Ürünleri"},
                new Kategori() {KategoriAdi="Tekstil Ürünleri"},
                new Kategori() {KategoriAdi="Elektronik Ürünler"},
                new Kategori() {KategoriAdi="Beyaz Eşya Ürünleri"},
                new Kategori() {KategoriAdi="Diğer Ürünler"},
            };

            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }


            context.SaveChanges();
            
            base.Seed(context);
        }
    }
}
