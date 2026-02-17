using System;
using System.Text;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
        
        Console.OutputEncoding = Encoding.UTF8;

        //Integer variables of different types
            int i = 8;
            uint j = 10u;
            long k = 12L;
            ulong n = 45UL;
        //Display the value on the screen 
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);
            Console.WriteLine(n);
        //Char variables with different Unicode values
            char sword = '\u2694';
            char scissors = '\u2702';
            char shamrock = '\u2618';

        //Display the value on the screen
            Console.WriteLine(sword);
            Console.WriteLine(scissors);
            Console.WriteLine(shamrock);
        }
    }
}
