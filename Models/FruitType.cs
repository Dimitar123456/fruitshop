using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt_magazin
{
    public class FruitType
    {
        [Key]
        public int TypeNumberId {  get; set; }
        public string TypeName {  get; set; }

        public ICollection<Fruit> Fruits { get; set; }
    }
}
