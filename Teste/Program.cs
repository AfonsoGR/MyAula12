using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            // Returns 0 - instance 3 other 3
            // Instance and other come at same time therefore returns 0
            Console.WriteLine((3).CompareTo(3));
            // Returns 1 - instance 3 other 2
            // Instance comes after other therefore returns 1
            Console.WriteLine((3).CompareTo(2));
            // Returns -1 - instance 3 other 4
            // Instance comes before other therefore returns -1
            Console.WriteLine((3).CompareTo(4));

            // CompareTo in strings 
            // Alphabetical order

            // Returns -1
            Console.WriteLine("ABC".CompareTo("DEF"));
            // Returns 1
            Console.WriteLine("D".CompareTo("ABC"));
            // Returns 0
            Console.WriteLine("ABC".CompareTo("ABC"));

            Console.WriteLine("Olá".GetHashCode());
            Console.WriteLine("Olé".GetHashCode());
            Console.WriteLine("Olá".GetHashCode());
        }
    }
}
