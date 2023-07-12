

using Microsoft.EntityFrameworkCore;
using MusicLibraryWebAPI.Models;

namespace MusicLibraryWebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {      
        public DbSet<Song> Songs { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        { 

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Configure the song entitity
            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    Id = 1,
                    Title = "Candy Store",
                    Artist = "Hyper Crush",
                    Album = "The Arcade",
                    ReleaseDate = 2008,
                    Genre = "Pop Rap"
                },
                new Song
                {
                    Id = 2,
                    Title = "Twisted",
                    Artist = "Hyper Crush",
                    Album = "The Arcade",
                    ReleaseDate = 2008,
                    Genre = "Pop Rap"
                },
                new Song
                {
                    Id = 3,
                    Title = "Boom Box",
                    Artist = "Hyper Crush",
                    Album = "The Arcade",
                    ReleaseDate = 2008,
                    Genre = "Pop Rap"
                },
                new Song
                {
                    Id = 4,
                    Title = "Disco Tech",
                    Artist = "Hyper Crush",
                    Album = "The Arcade",
                    ReleaseDate = 2008,
                    Genre = "Pop Rap"
                },
                new Song
                {
                    Id = 5,
                    Title = "Get Low",
                    Artist = "Lil Jon",
                    Album = "Kings of Crunk",
                    ReleaseDate = 2002,
                    Genre = "Rap"
                }
                );
        }
    }
}
