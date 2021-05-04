using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShared
{
    public interface ICoffeeBUS
    {
        List<Coffee>GetAll();
        Coffee GetDetails(int code);
        List<Coffee> Search(String keyword);
        bool AddNew(Coffee newCoffee);
        bool Update(Coffee newCoffee);
        bool Delete(int code);
    }
}
