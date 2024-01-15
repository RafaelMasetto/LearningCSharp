using System.ComponentModel;
using System.Diagnostics;

namespace UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {;
            Add();
            
            
            Console.Read();
        }

        public static void Add()
        {
            Console.WriteLine("Please, enter the first number we're going to add: ");
            string num1Input = Console.ReadLine();
            Console.WriteLine("Now enter the second number: ");
            string num2Input = Console.ReadLine();

            int num1 = int.Parse(num1Input);
            int num2 = int.Parse(num2Input);
            
            
            int result = num1 + num2;

            Console.WriteLine($"The total is {result}.");
        }




    }
}
