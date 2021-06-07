using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PhoneSite.Models;
namespace PhoneSite.Controllers
{
    public class PhoneController : ApiController
    {
       [HttpGet]
       [Route("api/phones")]
        public List<Phone> GetAll()
        {
            List<Phone> phones = new PhoneDAO().SelectAll();
            return phones;
        }
        [HttpGet]
        [Route("api/phones/{code}")]
        public Phone GetDetails(int code)
        {
            Phone phone = new PhoneDAO().SelectByCode(code);
            return phone;
        }
        [HttpGet]
        [Route("api/phones/search/{keyword}")]
        public List<Phone> Search(String keyword)
        {
            List<Phone> phones = new PhoneDAO().SelectByKeyword(keyword);
            return phones;
        }
        [HttpPost]
        [Route("api/phones")]
        public bool AddNew(Phone newPhone)
        {
            bool resutl = new PhoneDAO().Insert(newPhone);
            return resutl;
        }
        [HttpPut]
        [Route("api/phones/{code}")]
        public bool Update(Phone newPhone, int code)
        {
            if (code != newPhone.Code)
                return false;
            bool resutl = new PhoneDAO().Update(newPhone);
            return resutl;
        }
        [HttpDelete]
        [Route("api/phones/{code}")]
        public bool Delete(int code)
        {
            bool resutl = new PhoneDAO().Delete(code);
            return resutl;
        }
    }
}