using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Windows.Forms;
namespace PhoneClient
{
    class PhoneBUS
    {

        static IFirebaseConfig config = new FirebaseConfig { BasePath = "https://sellphone-9bae1-default-rtdb.asia-southeast1.firebasedatabase.app/" };

        static FirebaseClient client = new FirebaseClient(config);

        public async void ListenFireBase(DataGridView gridPhone)
        {
            EventStreamResponse response = await client.OnAsync("phones",
                added: (sender, args, context) => { UpdateDataGridView(gridPhone); },
                changed: (sender, args, context) => { UpdateDataGridView(gridPhone); },
                removed: (sender, args, context) => { UpdateDataGridView(gridPhone); });
        }

        private void UpdateDataGridView(DataGridView gridPhone)
        {
            List<Phone> phones = GetAll();
            gridPhone.BeginInvoke(new MethodInvoker(delegate { gridPhone.DataSource = phones; }));
        }

        public string GetKeyByCode(int code)
        {
            FirebaseResponse response = client.Get("phones");
            Dictionary<string, Phone> dictPhone = response.ResultAs<Dictionary<string, Phone>>();
            string key = dictPhone.FirstOrDefault(x => x.Value.Code == code).Key;
            return key;
        }



        public List<Phone> GetAll()
        {
            FirebaseResponse response = client.Get("phones");
            Dictionary<string, Phone> dictPhone = response.ResultAs<Dictionary<string, Phone>>();
            return dictPhone.Values.ToList();
        }

        public Phone GetDetails(int code)
        {
            FirebaseResponse response = client.Get("phones/" + GetKeyByCode(code));
            Phone phones = response.ResultAs<Phone>();
            return phones;
        }
        public bool Update(Phone newPhone)
        {
            try
            {
                string key = GetKeyByCode(newPhone.Code);
                if (string.IsNullOrEmpty(key)) return false;
                client.Set("phones/" + key, newPhone);
                return true;
            }
            catch { return false; }
        }

        public bool AddNew(Phone newPhone)
        {
            try
            {
                client.Push("phones", newPhone);
                return true;
            }
            catch { return false; }
        }

        public bool Delete(int code)
        {
            try
            {
                string key = GetKeyByCode(code);
                if (string.IsNullOrEmpty(key)) return false;
                client.Delete("phones/" + key);
                return true;
            }
            catch { return false; }
        }

        public List<Phone> Search(string keyword)
        {
            List<Phone> phones = new List<Phone>();
            foreach (var item in GetAll())
            {
                if (item.Name.ToLower().Contains(keyword.ToLower()))
                {
                    phones.Add(item);
                }
            }
            return phones;
        }



    }

}
