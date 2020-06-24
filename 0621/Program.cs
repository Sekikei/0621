using System;

namespace _0621
{
    class Program
    {
        static void Main(string[] args)
        {
           char a= char.Parse(Console.ReadLine());
            if (char.IsLower(a))
            {
                Console.WriteLine("a");
            }
            else
            {
                Console.WriteLine("A");
            }
        }
    }
}
