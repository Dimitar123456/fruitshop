using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt_magazin
{
    public class FruitContext:DbContext
    {
        public FruitContext() : base("FruitShop")
        {
        
        }
        public DbSet<Fruit> Fruits { get; set; }
        public DbSet<FruitType> FruitTypes { get; set;}
    }
}
