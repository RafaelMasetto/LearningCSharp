namespace ChallengeStringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string charInput;

            Console.WriteLine("Please write something cool: ");
            userInput = Console.ReadLine();
            Console.WriteLine("Now please enter one characater to search: ");
            charInput = Console.ReadLine();

            int charInputIndex = userInput.IndexOf(charInput);

            Console.WriteLine($"The character \"{charInput}\" first appears at position {charInputIndex}.");

            string firstName;
            string lastName;

            Console.WriteLine("Could you please enter your first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Now enter your last name please: ");
            lastName = Console.ReadLine();

            string fullName = firstName + " " + lastName;

            Console.WriteLine($"Oh, great! So your name is {fullName}. Hey, it's got a nice ring to it!");
        }
    }
}
