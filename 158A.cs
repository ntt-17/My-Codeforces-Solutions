using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 158A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            int count = 0;
            string[] numList = Console.ReadLine().Split(' ');
            n = Convert.ToInt32(numList[0]);
            k = Convert.ToInt32(numList[1]);

            int[] a = new int[n];
            string[] numList1 = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(numList1[i]);
            }

            for(int i = 0; i < n; i++)
            {
                if (a[i] >= a[k - 1] && a[i] != 0)
                    count++;
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
