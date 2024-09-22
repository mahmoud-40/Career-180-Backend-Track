namespace StringEncoderDecoder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";

            string encoded = StringEncoder.Encode(word);

            string decoded = StringEncoder.Decode(encoded);

            Console.WriteLine("Original: " + word);
            Console.WriteLine("Encoded: " + encoded);
            Console.WriteLine("Decoded: " + decoded);
        }

        public static class StringEncoder
        {
            public static string Encode(string word)
            {
                char[] array = word.ToCharArray();
                int key = 20;

                for (int i = 0; i < array.Length; i++)
                {
                    int number = (int)array[i];
                    
                    number ^= key;
                    array[i] = (char)number;
                }
                return new string(array);
            }

            public static string Decode(string word)
            {
                char[] array = word.ToCharArray();
                int key = 20;
                for (int i = 0; i < array.Length; i++)
                {
                    int number = (int)array[i];
                    number ^= key;
                    array[i] = (char)number;
                }
                return new string(array);
            }
        }
    }
}
