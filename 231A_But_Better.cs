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
            int n, count = 0;

            n = Convert.ToInt32(Console.ReadLine());
            
            while (n > 0)
            {
                string[] numList = Console.ReadLine().Split(' ');
                int Petya = Convert.ToInt32(numList[0]);
                int Vasya = Convert.ToInt32(numList[1]);
                int Tonya = Convert.ToInt32(numList[2]);

                if (Petya + Vasya + Tonya >= 2)
                    count++;
                n--;
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
