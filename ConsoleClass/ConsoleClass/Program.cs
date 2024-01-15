namespace ConsoleClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Hi {0}, nice to meet you!", userName);

            Console.Write("{0}, please, enter your age: ", userName);
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}? Well {1}, it's the perfect age to start learning coding!", userAge, userName);

        }
    }
}
