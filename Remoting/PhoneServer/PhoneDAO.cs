using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using PhoneShared;

namespace PhoneServer
{
    class PhoneDAO
    {
        MyDBDataContext db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);

        public List<Phone> SelectAll()
        {
            db.ObjectTrackingEnabled = false;
            List<Phone> phones = db.Phones.ToList();
            return phones;
        }

        public Phone SelectByCode(int code)
        {
            Phone phone = db.Phones.SingleOrDefault(b => b.Code == code);
            return phone;
        }

        public List<Phone> SelectByKeyword(String keyword)
        {
            List<Phone> phones = db.Phones.Where(b => b.Name.Contains(keyword)).ToList();
            return phones;
        }

        public bool Insert(Phone newPhone)
        {
            try
            {
                db.Phones.InsertOnSubmit(newPhone);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool Update(Phone newPhone)
        {
            Phone dbPhone = db.Phones.SingleOrDefault(b => b.Code == newPhone.Code);
            if (dbPhone != null)
            {
                try
                {
                    dbPhone.Name = newPhone.Name;
                    dbPhone.Color = newPhone.Color;
                    dbPhone.Price = newPhone.Price;
                    dbPhone.Quantity = newPhone.Quantity;
                    db.SubmitChanges();
                    return true;
                }
                catch { return false; }
            }
            return false;
        }

        public bool Delete(int code)
        {
            Phone dbPhone = db.Phones.SingleOrDefault(b => b.Code == code);
            if (dbPhone != null)
            {
                try
                {
                    db.Phones.DeleteOnSubmit(dbPhone);
                    db.SubmitChanges();
                    return true;
                }
                catch { return false; }
            }
            return false;
        }
    }
}
