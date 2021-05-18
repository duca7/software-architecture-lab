using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SongShared;

namespace SongService
{
    class SongBUS : MarshalByRefObject,ISongBUS
    {
        public List<Song> GetAll()
        {
            List<Song> songs = new SongDAO().SelectAll();
            return songs;
        }

        public Song GetDetails(int code)
        {
            Song song = new SongDAO().SelectByCode(code);
            return song;
        }

        public List<Song> Search(String keyword)
        {
            List<Song> songs = new SongDAO().SelectByKeyword(keyword);
            return songs;
        }

        public bool AddNew(Song newSong)
        {
            bool resutl = new SongDAO().Insert(newSong);
            return resutl;
        }

        public bool Update(Song newSong)
        {
            bool resutl = new SongDAO().Update(newSong);
            return resutl;
        }

        public bool Delete(int code)
        {
            bool resutl = new SongDAO().Delete(code);
            return resutl;
        }
    }
}
