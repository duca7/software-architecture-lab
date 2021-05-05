using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShared;
namespace CoffeeServer
{
    class CoffeeBUS : MarshalByRefObject, ICoffeeBUS
    {
        public List<Coffee> GetAll()
        {
            List<Coffee> phones = new CoffeeDAO().SelectAll();
            return phones;
        }

        public Coffee GetDetails(int code)
        {
            Coffee phone = new CoffeeDAO().SelectByCode(code);
            return phone;
        }

        public List<Coffee> Search(String keyword)
        {
            List<Coffee> phones = new CoffeeDAO().SelectByKeyword(keyword);
            return phones;
        }

        public bool AddNew(Coffee newCoffee)
        {
            bool resutl = new CoffeeDAO().Insert(newCoffee);
            return resutl;
        }

        public bool Update(Coffee newCoffee)
        {
            bool resutl = new CoffeeDAO().Update(newCoffee);
            return resutl;
        }

        public bool Delete(int code)
        {
            bool resutl = new CoffeeDAO().Delete(code);
            return resutl;
        }
    }
}
