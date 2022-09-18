using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 50A
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int n, m;

            string[] numList = Console.ReadLine().Split(' ');
            n = Convert.ToInt32(numList[0]);
            m = Convert.ToInt32(numList[1]);

            int result = (n * m) / 2;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
