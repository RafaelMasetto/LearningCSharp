namespace StringsChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userString;

            Console.WriteLine("Please enter your name and press enter: ");
            userString = Console.ReadLine();

            Console.WriteLine(userString.ToUpper());

            Console.WriteLine(userString.ToLower());

            Console.WriteLine(userString.Trim());

            Console.WriteLine(userString.Substring(3,12));

            string userStringUpperCase = String.Format($"Upper case: {userString.ToUpper()}.");
            Console.WriteLine(userStringUpperCase);

            string userStringLowerCase = String.Format($"Lower case: {userString.ToLower()}.");
            Console.WriteLine(userStringLowerCase);

            string userStringTrim = String.Format($"Trimmed String: {userString.Trim()}.");
            Console.WriteLine(userStringTrim);

            string userStringSubstring = String.Format($"Substring Value: {userString.Substring(0, 8)}.");
            Console.WriteLine(userStringSubstring);


            Console.Read();
        }
    }
}
