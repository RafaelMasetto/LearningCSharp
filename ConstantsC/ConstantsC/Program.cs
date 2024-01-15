using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantsC
{
    // Constants are imutable values which are known
    //at compile time and do not change for the life of the program.
    
    class Program
    {
        // constants at fields
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;

        const string myBirthday = "02.10.1991";
        static void Main(string[] args)
        {
            Console.WriteLine($"Hi there, my birthday will always be {myBirthday}.");
            Console.ReadKey();
            
        }
    }
}
