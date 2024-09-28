namespace MovieRent
{
    public interface ISystem
    {
        void ShowMenu();
    }

    public class System: ISystem
    {
        private List<Movie> Movies { get; set; }
        private List<Customer> Customers { get; set; }
        private List<Rent> Rentals { get; set; }

        public System(List<Movie> movies)
        {
            Movies = movies;
            Customers = new List<Customer>();
            Rentals = new List<Rent>();
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("----- Main Menu -----");
                Console.WriteLine("1. Search for a Movie");
                Console.WriteLine("2. Suggest a Movie by Genre");
                Console.WriteLine("3. Rent a Movie");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            SearchMovie();
                            break;
                        case 2:
                            SuggestMovie();
                            break;
                        case 3:
                            RentMovie();
                            break;
                        case 4:
                            Console.WriteLine("Exiting the application. Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
                Console.WriteLine();
            }
        }

        private void SearchMovie()
        {
            Console.Write("Enter movie title to search: ");

            string title = Console.ReadLine();
            
            var results = Movies.Where(m => m.Title.Contains(title, StringComparison.OrdinalIgnoreCase)).ToList();

            if (results.Count > 0)
            {
                Console.WriteLine("Movies Found:");
                foreach (var movie in results)
                {
                    movie.ShowDetails();
                }
            }
            else
            {
                Console.WriteLine("No movies found.");
            }
        }

        private void SuggestMovie()
        {
            Console.Write("Enter genre to suggest movies: ");
            string genre = Console.ReadLine();

            Suggester suggester = new Suggester(Movies);
            var suggestedMovies = suggester.SuggestByGenre(genre);

            if (suggestedMovies.Count > 0)
            {
                Console.WriteLine("Suggested Movies:");
                foreach (var movie in suggestedMovies)
                {
                    movie.ShowDetails();
                }
            }
            else
            {
                Console.WriteLine("No movies found for the specified genre.");
            }
        }

        private void RentMovie()
        {
            Customer customer = new Customer();
            customer.EnterDetails();
            Customers.Add(customer);

            Console.Write("Enter movie title to rent: ");
            string title = Console.ReadLine();
            var movie = Movies.FirstOrDefault(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (movie != null && movie.IsAvailable)
            {
                Console.Write("Enter rent period (days): ");
                if (int.TryParse(Console.ReadLine(), out int days))
                {
                    Rent rent = new Rent();
                    rent.RentMovie(movie, customer, days);
                    Rentals.Add(rent);

                    Payment payment = new Payment();
                    payment.Amount = (decimal)rent.CalculateTotal();

                    Console.Write("Choose payment method (Card/Cash): ");
                    string method = Console.ReadLine();
                    payment.ChooseMethod(method);

                    if (method.Equals("Card", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Write("Enter Card Number: ");
                        string cardNumber = Console.ReadLine();
                        Console.Write("Enter Expiration Date (MM/YY): ");
                        string expirationDate = Console.ReadLine();
                        Console.WriteLine($"Card Number: {cardNumber}, Expiration Date: {expirationDate} received.");
                    }

                    if (payment.Process())
                    {
                        Order order = new Order();
                        order.PlaceOrder(rent, payment);
                        order.ShowSummary();
                    }
                    else
                    {
                        Console.WriteLine("Payment failed.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid rent period.");
                }
            }
            else
            {
                Console.WriteLine("Movie not available for rent.");
            }
        }
    }
}
