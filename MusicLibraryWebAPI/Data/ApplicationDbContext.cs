

using Microsoft.EntityFrameworkCore;
using MusicLibraryWebAPI.Models;

namespace MusicLibraryWebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Configure the song entitity
            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    Id = 1,
                    Title = "Title",
                    Artist = "",
                    Album = "Album",
                    ReleaseDate = 2000,
                    Genre = "Rock"
                },
                new Song
                {
                    Id = 2,
                    Title = "Title",
                    Artist = "Artist",
                    Album = "Album",
                    ReleaseDate = 2000,
                    Genre = "Rock"
                },
                new Song
                {
                    Id = 3,
                    Title = "Title",
                    Artist = "Artist",
                    Album = "Album",
                    ReleaseDate = 2000,
                    Genre = "Rock"
                },
                new Song
                {
                    Id = 2,
                    Title = "Title",
                    Artist = "Artist",
                    Album = "Album",
                    ReleaseDate = 2000,
                    Genre = "Rock"
                },
                new Song
                {
                    Id = 2,
                    Title = "Title",
                    Artist = "Artist",
                    Album = "Album",
                    ReleaseDate = 2000,
                    Genre = "Rock"
                }
                );
        }


    }
}
