using System;
using System.Collections.Generic;

namespace StringCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "AAAAAAA";
            string b = "AAAAAAA";
            string c = "CCCCCCC";
            string d = "DDDDDDD";
            string e = "EEEEEEE";

            List<string> list = new List<string>()
            {
                a,
                b,
                c,
                d,
                e,
            };

            Stack<string> stack = new Stack<string>()
            {
                Push.a,
                Push.b,
                Push.c,
                Push.d,
                Push.e,
            };

            Queue<string> queue = new Queue<string>()
            {
                Enqueue.a;
                b;
                c;
                d;
                e;
            };

            HashSet<string> hash = new HashSet<string>()
            {
                a;
                b;
                c;
                d;
                e;
            };

            foreach (string l in list)
            {
                Console.WriteLine(l);
            }
            foreach (string s in stack)
            {
                Console.WriteLine(s);
            }
            foreach (string q in queue)
            {
                Console.WriteLine(q);
            }
            foreach (string h in hash)
            {
                Console.WriteLine(h);
            }
        }
    }
}
