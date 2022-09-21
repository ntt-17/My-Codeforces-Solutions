using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = 0;
            int n;

            n = Convert.ToInt32(Console.ReadLine());
            string[] a = new string[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Console.ReadLine();
                if (a[i] == "X++")
                {
                    X++;
                }
                else if (a[i] == "++X")
                {
                    X = ++X;
                }

                if (a[i] == "X--")
                {
                    X--;
                }
                else if (a[i] == "--X")
                {
                    X = --X;
                }
            }
            Console.WriteLine(X);
            Console.ReadLine();
            
        }
    }
}
