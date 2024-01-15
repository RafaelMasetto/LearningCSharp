using System.Runtime.Intrinsics.X86;

namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //define few variables
            int age = 32;
            string name = "Rafael";
            string role = "Game Master";
            string tabletopGame = "Pathfinder 2E";

            //1. string concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello my name is " + name + " , I am " + age + " years old.");

            //2. string formatting.
            //string formatting uses index
            Console.WriteLine("\nString Formatting");
            Console.WriteLine("Hello my name is {0}, I am {1} years old. I am a nerdy guy and love to play tabletop rpgs. Currently I play {2} as a {3}.", name, age, tabletopGame, role);

            //3. String interpolation.
            //string interpolation uses $ at the start which will allows us to write our
            //variables like this {variableName}
            Console.WriteLine("\nString Interpolation");
            Console.WriteLine($"Hello my name is {name}, I am {age} years old. I am a nerdy guy and love to play tabletop rpgs. Currently I play {tabletopGame} as a {role}.");

            //4. Verbatim Strings.
            //verbatim strings start with @ and tells the compiler to take the string
            //literally and ignore any spaces and escape characters like \n
            Console.WriteLine("\nVerbatim strings");
            Console.WriteLine(@"Lorem ipsum dolor sit amet,
            consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 
            Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
            Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.
            Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.



            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
            Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
            Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.
            Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");

            //instead of using \\ to write file paths we can use verbatim strings to make it easier
            //if you remove the @ you will get an error because \U, \A and \D are not valid escape characters
            Console.WriteLine(@"C:\User\Admin\Dog Pictures\Dog1|Super CoolDog.png");

            //with verbatim strings even valid escape characters won't work
            Console.WriteLine(@"Muahaha \n you have no powers here!.");
            Console.WriteLine("Muahaha \n you have powers here!");


        }
    }
}
