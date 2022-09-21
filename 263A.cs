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
            int result = 0;
            int c;
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    c = Convert.ToInt32(Console.ReadLine());
                    if (c == 1)
                    {
                        result = Math.Abs(row - 2) + Math.Abs(col - 2);
                    }
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
