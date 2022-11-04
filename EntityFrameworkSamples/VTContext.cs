using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSamples
{
    public class VTContext : DbContext
    {

        public VTContext() : base("VTConnection")
        {
            Database.SetInitializer(new DataInitializer());
        }


        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<KargoAdi> KargoAdlari { get; set; }         
    }
}
