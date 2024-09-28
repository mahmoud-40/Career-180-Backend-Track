namespace MovieRent
{
    public interface IMovie
    {
        void ShowDetails();
        void SetAvailability(bool status);
    }

    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }
        public int RentCount { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine($"Title: {Title}, Genre: {Genre}, Year: {Year}, Price: ${Price}, Available: {IsAvailable}");
        }

        public void SetAvailability(bool status)
        {
            IsAvailable = status;
        }
    }
}