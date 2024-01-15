namespace ReturnValueMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(15, 31));
            Console.WriteLine(Multiply(4, 5));
            Console.WriteLine(Divide(15, 7));
            Console.Read();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
