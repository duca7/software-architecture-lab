using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace SongSite.Models
{
    public class SongDAO
    {
        MyDBDataContext db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);

        public List<Song> SelectAll()
        {
            db.ObjectTrackingEnabled = false;
            List<Song> songs = db.Songs.ToList();
            return songs;
        }

        public Song SelectByCode(int id)
        {
            Song song = db.Songs.SingleOrDefault(b => b.Id == id);
            return song;
        }

        public List<Song> SelectByKeyword(String keyword)
        {
            List<Song> songs = db.Songs.Where(b => b.Title.Contains(keyword)).ToList();
            return songs;
        }

        public bool Insert(Song newSong)
        {
            try
            {
                db.Songs.InsertOnSubmit(newSong);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool Update(Song newSong)
        {
            Song dbSong = db.Songs.SingleOrDefault(b => b.Id == newSong.Id);
            if (dbSong != null)
            {
                try
                {
                    dbSong.Title = newSong.Title;
                    dbSong.Singer = newSong.Singer;
                    dbSong.Genre = newSong.Genre;
                    dbSong.Album = newSong.Album;
                    db.SubmitChanges();
                    return true;
                }
                catch { return false; }
            }
            return false;
        }

        public bool Delete(int id)
        {
            Song dbSong = db.Songs.SingleOrDefault(b => b.Id == id);
            if (dbSong != null)
            {
                try
                {
                    db.Songs.DeleteOnSubmit(dbSong);
                    db.SubmitChanges();
                    return true;
                }
                catch { return false; }
            }
            return false;
        }
    }
}