using Microsoft.AspNetCore.Mvc;
using MusicLibraryWebAPI.Data;
using MusicLibraryWebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicLibraryWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SongsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Songs
        [HttpGet]
        public IActionResult Get()
        {
            var songs = _context.Songs.ToList();
            return StatusCode(200, songs);
        }

        // GET api/Songs/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            //Find the song by id. 
            var song = _context.Songs.Find(id);
            //Check if song result is null
            if (song == null)
            {
                return NotFound();
            }
            return Ok(song); 
        }

        // POST api/Songs
        [HttpPost]
        public IActionResult Post([FromBody] Song song)
        {
            _context.Songs.Add(song);
            _context.SaveChanges();
            return StatusCode(201, song);
        }

        // PUT api/Songs/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Song song)
        {
            var editedSong = _context.Songs.Find(id);
            if (song == null)
            {
                return NotFound();
            }
            //Update data in found song
            editedSong.Title = song.Title;
            editedSong.Artist = song.Artist;
            editedSong.Album = song.Album;
            editedSong.ReleaseDate = song.ReleaseDate;
            editedSong.Genre = song.Genre;

            _context.SaveChanges();
            return StatusCode(200, editedSong);
        }

        // DELETE api/Songs/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var song = _context.Songs.Find(id);
            _context.Songs.Remove(song);
            _context.SaveChanges(); 
            return NoContent();
        }

        // POST api/Songs/3/Like
        [HttpPost("{id}/Like")]
        public IActionResult LikeSong(int id)
        {
            //Find a song to like
            var song = _context.Songs.Find(id);
            if (song == null)
            {
                return NotFound();
            }
            //Increment likes for song
            song.Likes++;
            _context.SaveChanges();
            return Ok(song);
        }
    }
}
