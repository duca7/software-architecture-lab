using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongShared
{
    public interface ISongBUS
    {
        List<Song> GetAll();
        Song GetDetails(int id);
        List<Song> Search(String keyword);
        bool AddNew(Song newSong);
        bool Update(Song newSong);
        bool Delete(int id);
    }
}
