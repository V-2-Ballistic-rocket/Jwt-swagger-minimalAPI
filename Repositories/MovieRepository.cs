using minimalAPI2.Models;

namespace minimalAPI2.Repositories
{
    public class MovieRepository
    {
        public static List<Movie> Movies = new()
        {
            new() { Id = 1, Title = "Brat", Description = "Nautilus Pompilius - the best band", Rating = 9.5 },
            new() { Id = 2, Title = "Brat 2", Description = "Good songs", Rating = 9.9 },
            new() { Id = 3, Title = "Muhtar", Description = "a detective thriller that plays on" +
                "the nerves from the first seconds", Rating = 7.7},
            new() { Id = 4, Title = "The Return of Muhtar 2", Description = "The return of the " +
                "legendary series. Everything is the same as last season, only 2 times better.", Rating = 8.9},
        };
    }
}
