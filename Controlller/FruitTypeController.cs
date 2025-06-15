using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt_magazin.Controlller
{
    public class FruitTypeController
    {

        private FruitContext FruitContext = new FruitContext(); // Това е БД !!!!

        public FruitType Get(int TypeNumberId)
        {
            FruitType IdOrder = FruitContext.FruitTypes.Find(TypeNumberId);
            return IdOrder;
        }

        public List<FruitType> GetAll()
        {
            return FruitContext.FruitTypes.ToList();
        }


        public void Create(FruitType fruittype)
        {
            FruitContext.FruitTypes.Add(fruittype);
            FruitContext.SaveChanges();
        }

        public void Update(int id, FruitType fruittypes)
        {
            FruitType IdOrder = FruitContext.FruitTypes.Find(id);
            if (IdOrder == null) //
            {
                return;
            }
            fruittypes.TypeNumberId = IdOrder.TypeNumberId;
            fruittypes.TypeName = IdOrder.TypeName;
            FruitContext.SaveChanges();
        }
        public void Delete(int id)
        {
            FruitType IdOrder = FruitContext.FruitTypes.Find(id);
            FruitContext.FruitTypes.Remove(IdOrder);
            FruitContext.SaveChanges();
        }
    }
}
