using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShare
{
    public interface IPhoneBUS
    {
        List<Phone> GetAll();
        Phone GetDetails(int code);
        List<Phone> Search(String keyword);
        bool AddNew(Phone newPhone);
        bool Update(Phone newPhone);
        bool Delete(int code);
    }
}
