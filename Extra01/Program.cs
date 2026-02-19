using System;
using System.Text;

namespace Extra01
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            char Trademark = '\u00AE';

            Console.WriteLine(Trademark);
        }
    }
}
