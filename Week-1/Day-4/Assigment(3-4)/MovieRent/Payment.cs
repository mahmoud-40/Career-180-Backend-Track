namespace MovieRent
{
    public interface IPayment
    {
        void ChooseMethod(string method);
        bool Process();
    }

    public class Payment
    {
        public decimal Amount { get; set; }
        public string Method { get; set; }
        public bool IsSuccessful { get; private set; }

        public void ChooseMethod(string method)
        {
            Method = method;
        }

        public bool Process()
        {
            IsSuccessful = true; 
            return IsSuccessful;
        }
    }
}