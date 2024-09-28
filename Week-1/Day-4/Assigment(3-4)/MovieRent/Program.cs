namespace MovieRent
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie { Title = "The Shawshank Redemption", Genre = "Drama", Year = 1994, Price = 15.0, IsAvailable = true },
                new Movie { Title = "The Godfather", Genre = "Crime", Year = 1972, Price = 20.0, IsAvailable = true },
                new Movie { Title = "The Dark Knight", Genre = "Action", Year = 2008, Price = 10.0, IsAvailable = true },
                new Movie { Title = "Inception", Genre = "Sci-Fi", Year = 2010, Price = 12.0, IsAvailable = true },
                new Movie { Title = "Pulp Fiction", Genre = "Crime", Year = 1994, Price = 14.0, IsAvailable = true },
                new Movie { Title = "Forrest Gump", Genre = "Drama", Year = 1994, Price = 15.0, IsAvailable = true },
                new Movie { Title = "The Matrix", Genre = "Sci-Fi", Year = 1999, Price = 11.0, IsAvailable = true },
                new Movie { Title = "Fight Club", Genre = "Drama", Year = 1999, Price = 13.0, IsAvailable = true },
                new Movie { Title = "The Lord of the Rings: The Fellowship of the Ring", Genre = "Fantasy", Year = 2001, Price = 18.0, IsAvailable = true },
                new Movie { Title = "Avatar", Genre = "Sci-Fi", Year = 2009, Price = 22.0, IsAvailable = true },
                new Movie { Title = "The Avengers", Genre = "Action", Year = 2012, Price = 16.0, IsAvailable = true },
                new Movie { Title = "Parasite", Genre = "Thriller", Year = 2019, Price = 17.0, IsAvailable = true },
                new Movie { Title = "Spirited Away", Genre = "Animation", Year = 2001, Price = 14.0, IsAvailable = true },
                new Movie { Title = "Gladiator", Genre = "Action", Year = 2000, Price = 15.0, IsAvailable = true },
                new Movie { Title = "The Silence of the Lambs", Genre = "Thriller", Year = 1991, Price = 16.0, IsAvailable = true },
                new Movie { Title = "Zootopia", Genre = "Animation", Year = 2016, Price = 12.0, IsAvailable = true },
            };

            System system = new System(movies);
            system.ShowMenu();
        }
    }
}