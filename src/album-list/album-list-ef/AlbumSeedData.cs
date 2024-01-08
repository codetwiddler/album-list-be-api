using album_list_model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace album_list_ef
{
    public class AlbumSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AlbumDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AlbumDbContext>>()))
            {
                //Check to see if any albums are already present in the database.
                if (context.Albums.Any())
                {
                    return; //DB has already been seeded
                }

                context.Albums.AddRange(
                    new Album { Title = "The Dark Side of the Moon", Artist = "Pink Floyd", ReleaseYear = 1973, Genre = "Rock", Rating = 5 },
                    new Album { Title = "Thriller", Artist = "Michael Jackson", ReleaseYear = 1982, Genre = "Pop", Rating = 5 },
                    new Album { Id = 3, Title = "Recharge", Artist = "Robot 3", ReleaseYear = 1972, Genre = "Electro-Swing", Rating = 5 },
                    new Album { Id = 4, Title = "Walk home", Artist = "Robot 4", ReleaseYear = 1972, Genre = "Psychedelic Circus", Rating = 2 },
                    new Album { Id = 5, Title = "Shutdown", Artist = "Robot 5", ReleaseYear = 1972, Genre = "Noise", Rating = 1 },
                    new Album { Id = 6, Title = "Silent Wave", Artist = "Sound Bender", ReleaseYear = 1980, Genre = "Ambient", Rating = 2 },
                    new Album { Id = 7, Title = "Echoes of the Unknown", Artist = "Mystery Band", ReleaseYear = 1982, Genre = "Rock" },
                    new Album { Id = 8, Title = "Neon Dreams", Artist = "City Lights", ReleaseYear = 1978, Genre = "Synth-Pop", Rating = 5 },
                    new Album { Id = 9, Title = "Retro Future", Artist = "Time Traveler", ReleaseYear = 1990, Genre = "RetroWave", Rating = 3 },
                    new Album { Id = 10, Title = "Solar Flares", Artist = "Star Voyager", ReleaseYear = 2000, Genre = "Electronic", Rating = 4 },
                    new Album { Id = 11, Title = "Deep Blue", Artist = "Ocean Explorer", ReleaseYear = 2005, Genre = "Chill", Rating = 5 },
                    new Album { Id = 12, Title = "Mountain Echo", Artist = "Nature's Voice", ReleaseYear = 2010, Genre = "Instrumental", Rating = 3 },
                    new Album { Id = 13, Title = "Urban Jungle", Artist = "City Roamer", ReleaseYear = 2015, Genre = "Hip-Hop", Rating = 4 },
                    new Album { Id = 14, Title = "Desert Mirage", Artist = "Sandy Sound", ReleaseYear = 2018, Genre = "World", Rating = 2 },
                    new Album { Id = 15, Title = "Frozen Notes", Artist = "Winter Melody", ReleaseYear = 2020, Genre = "Acoustic", Rating = 5 },
                    new Album { Id = 16, Title = "Festival of Lights", Artist = "Cultural Beats", ReleaseYear = 1995, Genre = "Folk", Rating = 3 },
                    new Album { Id = 17, Title = "Space Odyssey", Artist = "Astro", ReleaseYear = 1977, Genre = "Sci-Fi Rock", Rating = 4 },
                    new Album { Id = 18, Title = "Rainy Days", Artist = "Cloudy Melancholy", ReleaseYear = 1985, Genre = "Blues", Rating = 4 },
                    new Album { Id = 19, Title = "Summer Breeze", Artist = "Sunny Tunes", ReleaseYear = 1992, Genre = "Pop", Rating = 3 },
                    new Album { Id = 20, Title = "Autumn Leaves", Artist = "Golden Era", ReleaseYear = 2003, Genre = "Jazz", Rating = 5 },
                    new Album { Id = 21, Title = "Windy Nights", Artist = "Gale Force", ReleaseYear = 1998, Genre = "Classical", Rating = 2 },
                    new Album { Id = 22, Title = "Stellar Journey", Artist = "Galactic Traveler", ReleaseYear = 1989, Genre = "Psychedelic", Rating = 4 },
                    new Album { Id = 23, Title = "Underwater Realm", Artist = "Aqua World", ReleaseYear = 2012, Genre = "New Age", Rating = 5 },
                    new Album { Id = 24, Title = "Dreams", Artist = "Illusion", ReleaseYear = 2011, Genre = "Ambient", Rating = 3 },
                    new Album { Id = 25, Title = "Rhythm & Blues", Artist = "The Classics", ReleaseYear = 1990, Genre = "R&B", Rating = 4 },
                    new Album { Id = 26, Title = "BoopBeep", Artist = "Der Roboten", ReleaseYear = 1990, Genre = "Chiptunes", Rating = 3 },
                    new Album { Id = 27, Title = "Whut", Artist = "Memery", ReleaseYear = 2023, Genre = "MS Word Docs", Rating = 1 }
                //Add more albums as needed
                );

                context.SaveChanges();
            }
        }
    }
}
