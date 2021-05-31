using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PhoneSite
{
    /// <summary>
    /// Summary description for PhoneService
    /// </summary>
    [WebService(Namespace = "http://sellphone.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PhoneService : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Phone> GetAll()
        {
            List<Phone> phones = new PhoneDAO().SelectAll();
            return phones;
        }

        [WebMethod]
        public Phone GetDetails(int code)
        {
            Phone phone = new PhoneDAO().SelectByCode(code);
            return phone;
        }

        [WebMethod]
        public List<Phone> Search(String keyword)
        {
            List<Phone> phones = new PhoneDAO().SelectByKeyword(keyword);
            return phones;
        }
        [WebMethod]
        public bool AddNew(Phone newPhone)
        {
            bool resutl = new PhoneDAO().Insert(newPhone);
            return resutl;
        }
        [WebMethod]
        public bool Update(Phone newPhone)
        {
            bool resutl = new PhoneDAO().Update(newPhone);
            return resutl;
        }
        [WebMethod]
        public bool Delete(int code)
        {
            bool resutl = new PhoneDAO().Delete(code);
            return resutl;
        }
    }
}
