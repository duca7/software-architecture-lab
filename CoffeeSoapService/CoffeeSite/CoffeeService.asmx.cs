using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CoffeeSite
{
    /// <summary>
    /// Summary description for CoffeeService
    /// </summary>
    [WebService(Namespace = "http://coffee.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CoffeeService : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Coffee> GetAll()
        {
            List<Coffee> phones = new CoffeeDAO().SelectAll();
            return phones;
        }
        [WebMethod]
        public Coffee GetDetails(int code)
        {
            Coffee phone = new CoffeeDAO().SelectByCode(code);
            return phone;
        }
        [WebMethod]
        public List<Coffee> Search(String keyword)
        {
            List<Coffee> phones = new CoffeeDAO().SelectByKeyword(keyword);
            return phones;
        }
        [WebMethod]
        public bool AddNew(Coffee newCoffee)
        {
            bool result = new CoffeeDAO().Insert(newCoffee);
            return result;
        }
        [WebMethod]
        public bool Update(Coffee newCoffee)
        {
            bool resutl = new CoffeeDAO().Update(newCoffee);
            return resutl;
        }
        [WebMethod]
        public bool Delete(int code)
        {
            bool result = new CoffeeDAO().Delete(code);
            return result;
        }

    }
}
