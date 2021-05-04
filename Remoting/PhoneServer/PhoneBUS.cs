
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneShared;


namespace PhoneServer
{
    class PhoneBUS : MarshalByRefObject, IPhoneBUS
    {
        public List<Phone> GetAll()
        {
            List<Phone> phones = new PhoneDAO().SelectAll();
            return phones;
        }

        public Phone GetDetails(int code)
        {
            Phone phone = new PhoneDAO().SelectByCode(code);
            return phone;
        }

        public List<Phone> Search(String keyword)
        {
            List<Phone> phones = new PhoneDAO().SelectByKeyword(keyword);
            return phones;
        }

        public bool AddNew(Phone newPhone)
        {
            bool resutl = new PhoneDAO().Insert(newPhone);
            return resutl;
        }

        public bool Update(Phone newPhone)
        {
            bool resutl = new PhoneDAO().Update(newPhone);
            return resutl;
        }

        public bool Delete(int code)
        {
            bool resutl = new PhoneDAO().Delete(code);
            return resutl;
        }

    }
}
