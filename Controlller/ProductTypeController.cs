using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt_magazin.Controlller
{
    public class ProductController
    {
        private FruitContext FruitContext = new FruitContext(); // Това е БД !!!!

        public Fruit Get(int TypeNumberId)
        {
            Fruit IdOrder = FruitContext.Fruits.Find(TypeNumberId);
            if (IdOrder != null)
            {
                FruitContext.Entry(IdOrder).Reference(x => x.FruitTypes).Load();
            }
            return IdOrder;
        }

        public List<Fruit> GetAll()
        {
             return FruitContext.Fruits.Include("FruitTypes").ToList();
             }


        public void Create(Fruit fruit)
        {
            FruitContext.Fruits.Add(fruit);
            FruitContext.SaveChanges();
        }

        public void Update(int id, Fruit fruit)
        {
            Fruit IdOrder = FruitContext.Fruits.Find(id);
            if (IdOrder == null) //
            {
                return;
            }
            fruit.TypeNumberId = IdOrder.TypeNumberId;
            fruit.Name = IdOrder.Name;
            fruit.Description = IdOrder.Description;
            fruit.Price = IdOrder.Price;
            fruit.NumberId = IdOrder.NumberId;
            
            //findedDog.Age = dog.Age;
            //findedDog.Name = dog.Name;
            //findedDog.BreedId = dog.BreedId;
            FruitContext.SaveChanges();
        }
        public void Delete(int id)
        {
            Fruit IdOrder = FruitContext.Fruits.Find(id);
            FruitContext.Fruits.Remove(IdOrder);
            FruitContext.SaveChanges();
        }
    }
}
