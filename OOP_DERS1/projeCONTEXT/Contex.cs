using Microsoft.EntityFrameworkCore;
using OOP_DERS1.ENTİTY1;

namespace OOP_DERS1.projeCONTEXT
{
    public class Contex : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MONSTER2684TUNC\\SQLEXPRESS ; database=dbnewOOPproje ; integrated security=true ");
        }

        
            
       public DbSet<Product>products { get; set; }

      public  DbSet<Catagori> catagoris { get; set; }

        public DbSet<coustemer> coustemers { get; set;} 


    }
}
