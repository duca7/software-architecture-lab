using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

namespace SongClient
{
    class SongBUS
    {
        String URI = "http://songsite.gear.host/api/songs";
        public List<Song> GetAll()
        {
            WebClient client = new WebClient();
            String response = client.DownloadString(URI);
            return JsonConvert.DeserializeObject<List<Song>>(response);
        }

        public Song GetDetails(int code)
        {
            WebClient client = new WebClient();
            String response = client.DownloadString(URI + "/" + code);
            return JsonConvert.DeserializeObject<Song>(response);
        }

        public List<Song> Search(String keyword)
        {
            WebClient client = new WebClient();
            String response = client.DownloadString(URI + "/search/" + keyword);
            return JsonConvert.DeserializeObject<List<Song>>(response);
        }

        public bool AddNew(Song newSong)
        {
            String data = JsonConvert.SerializeObject(newSong);
            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            String response = client.UploadString(URI, "POST", data);
            return bool.Parse(response);
        }

        public bool Update(Song newSong)
        {
            String data = JsonConvert.SerializeObject(newSong);
            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            String response = client.UploadString(URI + "/" + newSong.Id, "PUT", data);
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
