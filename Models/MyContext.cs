using Microsoft.EntityFrameworkCore;
using Naruto.Models;
using System.Linq;


namespace Naruto.Models {
    public class MyContext : DbContext {
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<Ninja> Ninjas {get;set;}
        public DbSet<Jutsu> Jutsus {get;set;}
        public DbSet<Ninjutsu> Ninjitsus {get;set;}

        public void Create(Ninja ninja)
        {
            Ninjas.Add(ninja);
            SaveChanges();
        }

        public void Create(Jutsu jutsu)
        {
            Jutsus.Add(jutsu);
            SaveChanges();
        }

        public void Create(Ninjutsu ninjutsu)
        {
            Ninjitsus.Add(ninjutsu);
            SaveChanges();
        }

        public void Remove(int NinjaId, int JutsuId)
        {
            Ninjutsu thingToRemove = Ninjitsus
                .Where(n => n.NinjaId == NinjaId)
                .FirstOrDefault(n => n.JutsuId == JutsuId);
            Ninjitsus.Remove(thingToRemove);
            SaveChanges();
        }

    }
}