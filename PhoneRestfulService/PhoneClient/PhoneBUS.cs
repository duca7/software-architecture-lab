using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

namespace PhoneClient
{
    class PhoneBUS
    {
        String URI = "http://duc99.gear.host/api/phones";
        public List<Phone> GetAll()
        {
            WebClient client = new WebClient();
            String response = client.DownloadString(URI);
            return JsonConvert.DeserializeObject<List<Phone>>(response);
        }

        public Phone GetDetails(int code)
        {
            WebClient client = new WebClient();
            String response = client.DownloadString(URI + "/" + code);
            return JsonConvert.DeserializeObject<Phone>(response);
        }

        public List<Phone> Search(String keyword)
        {
            WebClient client = new WebClient();
            String response = client.DownloadString(URI + "/search/" + keyword);
            return JsonConvert.DeserializeObject<List<Phone>>(response);
        }

        public bool AddNew(Phone newPhone)
        {
            String data = JsonConvert.SerializeObject(newPhone);
            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            String response = client.UploadString(URI, "POST", data);
            return bool.Parse(response);
        }

        public bool Update(Phone newPhone)
        {
            String data = JsonConvert.SerializeObject(newPhone);
            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            String response = client.UploadString(URI+ "/" + newPhone.Code, "PUT", data);
            return bool.Parse(response);
        }

        public bool Delete(int code)
        {
            WebClient client = new WebClient();
            String response = client.UploadString(URI + "/" + code, "DELETE", "");
            return bool.Parse(response);
        }
    }
}
