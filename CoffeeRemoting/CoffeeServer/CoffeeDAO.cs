using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using CoffeeShared;
namespace CoffeeServer
{
    class CoffeeDAO
    {
        MyDBDataContext db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);

        public List<Coffee> SelectAll()
        {
            db.ObjectTrackingEnabled = false;
            List<Coffee> Coffees = db.Coffees.ToList();
            return Coffees;
        }

        public Coffee SelectByCode(int code)
        {
            Coffee Coffees = db.Coffees.SingleOrDefault(b => b.Code == code);
            return Coffees;
        }

        public List<Coffee> SelectByKeyword(String keyword)
        {
            List<Coffee> Coffees = db.Coffees.Where(b => b.Name.Contains(keyword)).ToList();
            return Coffees;
        }

        public bool Insert(Coffee newCoffee)
        {
            try
            {
                db.Coffees.InsertOnSubmit(newCoffee);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool Update(Coffee newCoffee)
        {
            Coffee dbCoffee = db.Coffees.SingleOrDefault(b => b.Code == newCoffee.Code);
            if (dbCoffee != null)
            {
                try
                {
                    dbCoffee.Name = newCoffee.Name;
                    dbCoffee.Description = newCoffee.Description;
                    dbCoffee.Price = newCoffee.Price;
                    dbCoffee.Exp = newCoffee.Exp;
                    dbCoffee.Mfg = newCoffee.Mfg;
                    db.SubmitChanges();
                    return true;
                }
                catch { return false; }
            }
            return false;
        }

        public bool Delete(int code)
        {
            Coffee dbCoffee = db.Coffees.SingleOrDefault(b => b.Code == code);
            if (dbCoffee != null)
            {
                try
                {
                    db.Coffees.DeleteOnSubmit(dbCoffee);
                    db.SubmitChanges();
                    return true;
                }
                catch { return false; }
            }
            return false;
        }
    }
}
