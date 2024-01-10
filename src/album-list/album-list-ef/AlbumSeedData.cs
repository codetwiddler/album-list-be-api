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
                    new Album { Title = "Recharge", Artist = "Robot 3", ReleaseYear = 1972, Genre = "Electro-Swing", Rating = 5 },
                    new Album { Title = "Walk home", Artist = "Robot 4", ReleaseYear = 1972, Genre = "Psychedelic Circus", Rating = 2 },
                    new Album { Title = "Shutdown", Artist = "Robot 5", ReleaseYear = 1972, Genre = "Noise", Rating = 1 },
                    new Album { Title = "Silent Wave", Artist = "Sound Bender", ReleaseYear = 1980, Genre = "Ambient", Rating = 2 },
                    new Album { Title = "Echoes of the Unknown", Rating = 0 },
                    new Album { Title = "Neon Dreams", Artist = "City Lights", ReleaseYear = 1978, Genre = "Synth-Pop", Rating = 5 },
                    new Album { Title = "Retro Future", Artist = "Time Traveler", ReleaseYear = 1990, Genre = "RetroWave", Rating = 3 },
                    new Album { Title = "Solar Flares", Artist = "Star Voyager", ReleaseYear = 2000, Genre = "Electronic", Rating = 4 },
                    new Album { Title = "Deep Blue", Artist = "Ocean Explorer", ReleaseYear = 2005, Genre = "Chill", Rating = 5 },
                    new Album { Title = "Mountain Echo", Artist = "Nature's Voice", ReleaseYear = 2010, Genre = "Instrumental", Rating = 3 },
                    new Album { Title = "Urban Jungle", Artist = "City Roamer", ReleaseYear = 2015, Genre = "Hip-Hop", Rating = 4 },
                    new Album { Title = "Desert Mirage", Artist = "Sandy Sound", ReleaseYear = 2018, Genre = "World", Rating = 2 },
                    new Album { Title = "Frozen Notes", Artist = "Winter Melody", ReleaseYear = 2020, Genre = "Acoustic", Rating = 5 },
                    new Album { Title = "Festival of Lights", Artist = "Cultural Beats", ReleaseYear = 1995, Genre = "Folk", Rating = 3 },
                    new Album { Title = "Space Odyssey", Artist = "Astro", ReleaseYear = 1977, Genre = "Sci-Fi Rock", Rating = 4 },
                    new Album { Title = "Rainy Days", Artist = "Cloudy Melancholy", ReleaseYear = 1985, Genre = "Blues", Rating = 4 },
                    new Album { Title = "Summer Breeze", Artist = "Sunny Tunes", ReleaseYear = 1992, Genre = "Pop", Rating = 3 },
                    new Album { Title = "Autumn Leaves", Artist = "Golden Era", ReleaseYear = 2003, Genre = "Jazz", Rating = 5 },
                    new Album { Title = "Windy Nights", Artist = "Gale Force", ReleaseYear = 1998, Genre = "Classical", Rating = 2 },
                    new Album { Artist = "Galactic Traveler", ReleaseYear = 1989, Genre = "Psychedelic", Rating = 4 },
                    new Album { Title = "Underwater Realm", Artist = "Aqua World", ReleaseYear = 2012, Genre = "New Age", Rating = 5 },
                    new Album { Title = "Dreams", Artist = "Illusion", ReleaseYear = 2011, Genre = "Ambient", Rating = 3 },
                    new Album { Title = "Rhythm & Blues", Artist = "The Classics", ReleaseYear = 1990, Genre = "R&B", Rating = 4 },
                    new Album { Title = "BoopBeep", Artist = "Der Roboten", ReleaseYear = 1990, Genre = "Chiptunes", Rating = 0 },
                    new Album { Title = "Whut", Artist = "Memery", ReleaseYear = 2023, Genre = "MS Word Docs", Rating = 1 }
                //Add more albums as needed
                );

                context.SaveChanges();
            }
        }
    }
}
