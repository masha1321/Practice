namespace Task3
{
    class Program
    {
        delegate string StringDelegate(string s);
        static string ToUpper(string s)
        {
            return s.ToUpper();
        }

          static string ToLower(string s)
        {
            return s.ToLower();
        }

        
        static string Reverse(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        static void Main(string[] args)
        {
            
            StringDelegate myDelegate = ToUpper;
            Console.WriteLine(myDelegate("Hello, World!"));  

            myDelegate += ToLower;
            Console.WriteLine(myDelegate("Hello, World!"));  

            myDelegate += Reverse;
            Console.WriteLine(myDelegate("Hello, World!"));  
        }
    }
}