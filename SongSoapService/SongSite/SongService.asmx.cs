using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SongSite
{
    /// <summary>
    /// Summary description for SongService
    /// </summary>
    [WebService(Namespace = "http://song.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SongService : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Song> GetAll()
        {
            List<Song> songs = new SongDAO().SelectAll();
            return songs;
        }
        [WebMethod]
        public Song GetDetails(int code)
        {
            Song song = new SongDAO().SelectByCode(code);
            return song;
        }
        [WebMethod]
        public List<Song> Search(String keyword)
        {
            List<Song> songs = new SongDAO().SelectByKeyword(keyword);
            return songs;
        }
        [WebMethod]
        public bool AddNew(Song newSong)
        {
            bool result = new SongDAO().Insert(newSong);
            return result;
        }
        [WebMethod]
        public bool Update(Song newSong)
        {
            bool result = new SongDAO().Update(newSong);
            return result;
        }
        [WebMethod]
        public bool Delete(int code)
        {
            bool result = new SongDAO().Delete(code);
            return result;
        }
    }
}
