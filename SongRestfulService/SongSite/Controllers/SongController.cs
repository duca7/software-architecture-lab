using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SongSite.Models;

namespace SongSite.Controllers
{
    public class SongController : ApiController
    {
        [HttpGet]
        [Route("api/songs")]
        public List<Song> GetAll()
        {
            List<Song> songs = new SongDAO().SelectAll();
            return songs;
        }
        [HttpGet]
        [Route("api/songs/{code}")]
        public Song GetDetails(int code)
        {
            Song song = new SongDAO().SelectByCode(code);
            return song;
        }
        [HttpGet]
        [Route("api/songs/search/{keyword}")]
        public List<Song> Search(String keyword)
        {
            List<Song> songs = new SongDAO().SelectByKeyword(keyword);
            return songs;
        }
        [HttpPost]
        [Route("api/songs")]
        public bool AddNew(Song newSong)
        {
            bool result = new SongDAO().Insert(newSong);
            return result;
        }
        [HttpPut]
        [Route("api/songs/{code}")]
        public bool Update(Song newSong)
        {
            bool result = new SongDAO().Update(newSong);
            return result;
        }
        [HttpDelete]
        [Route("api/songs/{code}")]
        public bool Delete(int code)
        {
            bool result = new SongDAO().Delete(code);
            return result;
        } 
    }
}