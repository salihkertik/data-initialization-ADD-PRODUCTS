using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSamples
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" ****************** MNG KARGO DATA ANALİZER  ****************** ");

            VTContext db = new VTContext();

            var KargoAdi = db.KargoAdlari.ToList();

            foreach (var item in KargoAdi)
            {
                Console.WriteLine("Urun Adı: {0}", item.UrunAdi);
            }



            Console.WriteLine("Veritabanı Oluştu!");

            Console.ReadLine();



            //List<Kategori> kategoriler = context.Kategoriler.ToList();

            //var kategoriler = context.Kategoriler.ToList();
            // Select 
            //foreach (var kategori in kategoriler)
            //{
            //    Console.WriteLine("Kategori Id : {0} Kategori Adı : {1}", kategori.Id, kategori.KategoriAdi);
            //}

            // --------------------------------------------------------------------------------------------------------------

            //var kategori = context.Kategoriler.Find(4);
            //Console.WriteLine("Kategori Id : {0} Kategori Adı : {1}", kategori.Id, kategori.KategoriAdi);

            //kategori.KategoriAdi = "Hassas Ürünler";
            // UPDATE
            //context.SaveChanges();
            //Console.WriteLine("--------------------------------");
            // kategori = context.Kategoriler.Find(4);
            //Console.WriteLine("Kategori Id : {0} Kategori Adı : {1}", kategori.Id, kategori.KategoriAdi);

            //----------------------------------------------------------------------------------------------------------------

            //VTContext db = new VTContext();

            //var kategori = db.Kategoriler.Find(1);

            //if (kategori != null)     
            //{
            //    db.Kategoriler.Remove(kategori);    
            //}   
            //                                                                            //DELETE  

            //db.SaveChanges();

            //foreach (var item in db.Kategoriler)
            //{
            //    Console.WriteLine("Sipariş Id: {0} Sipariş Adı: {1}", item.Id, item.KategoriAdi);
            //}

        }
    }
}
