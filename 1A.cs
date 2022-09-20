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
            long n, m, a, x, y;

            string[] numList = Console.ReadLine().Split(' ');
            n = Convert.ToInt32(numList[0]);
            m = Convert.ToInt32(numList[1]);
            a = Convert.ToInt32(numList[2]);

            if(n % a == 0) { x = n / a; }
            else x = n / a + 1;

            if(m % a == 0) { y = m / a; }
            else y = m / a + 1;
            long result = x * y;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
