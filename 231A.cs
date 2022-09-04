using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _231A
{
    internal class Program
    {
        static int Solve(int[,] arr, int n)
        {
            int count = 0;
            for(int i = 0; i < arr.GetLength(0); i++) 
            { 
                int s = 0;
                for(int j = 0; j < 3; j++)
                {
                    s = s + arr[i, j];
                }
                if(s >= 2)
                    count++;
                n--;
            }
            return count;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, 3];

            for (int i = 0; i < n; i++)
            {
                string[] numList = new string[n * 3];
                numList = Console.ReadLine().Split();
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = Convert.ToInt32(numList[j]);
                }
            }
            int result = Solve(arr, n);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
