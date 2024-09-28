namespace MovieRent
{
    public interface IRent
    {
        void RentMovie(Movie movie, Customer customer, int days);
        double CalculateTotal();
    }

    public class Rent
    {
        public Movie Movie { get; set; }
        public Customer Customer { get; set; }
        public DateTime StartDate { get; set; }
        public int Days { get; set; }

        public void RentMovie(Movie movie, Customer customer, int days)
        {
            Movie = movie;
            Customer = customer;
            StartDate = DateTime.Now;
            Days = days;

            movie.SetAvailability(false);
            movie.RentCount++;
        }

        public double CalculateTotal()
        {
            return Movie.Price * Days;
        }
    }
}