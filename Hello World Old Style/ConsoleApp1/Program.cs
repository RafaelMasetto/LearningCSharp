namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaring a variable
            int num1;
            // assigning a value to a variable
            num1 = 13;

            // declaring and initializing a variable in one go
            int num2 = 23;
            int sum = num1 + num2;

            // using concatenation

            Console.WriteLine("the sum of " + num1 + " and " + num2 + " is " + sum);

            // declaring multiple variables at once
            int num3, num4, num5;

            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine(d1 + " / " + d2 + " = " + dDiv);

            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;
            Console.WriteLine(f1 + " / " + f2  + " = " + fDiv);

            // Datatype string

            string myName = "Rafael Masetto";
            Console.WriteLine("Hello there, my name is " + myName);

            string greeting = "Hello there, my name is " + myName;
            Console.WriteLine(greeting);

            // using String methods
            Console.WriteLine(greeting.ToUpper());


            Console.Read();
        }
    }
}
