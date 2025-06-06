using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt_magazin
{
    public class Fruit
    {
        [Key]
        public int NumberId {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int TypeNumberId { get; set; }

        public FruitType FruitTypes { get; set; }
    }
}
