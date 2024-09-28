namespace MovieRent
{
    public interface IOrder
    {
        void PlaceOrder(Rent rent, Payment payment);
        void ShowSummary();
    }

    public class Order
    {
        public Rent Rent { get; set; }
        public Payment Payment { get; set; }

        public void PlaceOrder(Rent rent, Payment payment)
        {
            Rent = rent;
            Payment = payment;
        }

        public void ShowSummary()
        {
            Console.WriteLine($"Order Summary: Movie - {Rent.Movie.Title}, Customer - {Rent.Customer.Name}, Total Amount - ${Rent.CalculateTotal()}, Payment Successful - {Payment.IsSuccessful}");
        }
    }
}