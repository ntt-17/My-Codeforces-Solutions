using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _71A
{
    internal class Program
    {
        static void Solve(string[] s, int n)
        {
            int i = 0;
            while (n > 0)
            {
                if (s[i].Length > 10)
                    Console.WriteLine(s[i].ElementAt(0) + Convert.ToString(s[i].Length - 2) + s[i].ElementAt(s[i].Length - 1));
                else
                    Console.WriteLine(s[i]);
                i++;
                n--;
            }
        }
        static void Main(string[] args)
        {
            int n;

            n = Convert.ToInt32(Console.ReadLine());
            string[] s = new string[n];
            for (int i = 0; i < n; i++)
            {
                s[i] = Console.ReadLine();
            }

            Solve(s, n);
            Console.ReadLine();
        }
    }
}
