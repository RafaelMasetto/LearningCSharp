namespace TryAndCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string userInput1 = Console.ReadLine();

            Console.WriteLine("Now enter the number by which to divide");
            string userInput2 = Console.ReadLine();

            try
            {
                int userInputAsInt2 = int.Parse(userInput2);
                int userInputAsInt1 = int.Parse(userInput1);
                int result = userInputAsInt1 / userInputAsInt2;
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter the correct format.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZeroException, please enter a number other than 0");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, the number was too long or too short for an int32");
            }
            finally
            {
                Console.WriteLine("This is called anyways!");
            }

            


            Console.ReadKey();
        }
    }
}
