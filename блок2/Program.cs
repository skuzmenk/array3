using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace laba
{
    internal class Task2
    {
        static void Calculation(ref int n, ref int[][] arr)
        {
            for (int i = 1; i <= n; i++)
            {
                int s = 0;
                if (i >= 10)
                {
                    for (int k = i; k > 0; k /= 10)
                    {
                        s += k % 10;
                    }
                }
                else
                {
                    s = i;
                }
                int a = 0;
                int count = 0;
                arr[i - 1] = new int[n];
                int j = 1;
                for (; j <= n; j++)
                {
                    if (j % s == 0)
                    {
                        arr[i - 1][a] = j;
                        count++;
                        a++;
                    }
                }
                Array.Resize(ref arr[i - 1], count);
            }
        }
        static void Output(int n, int[][]arr)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] arr = new int[n][];
            Calculation(ref n, ref arr);
            Output(n, arr);
            Console.ReadLine();
        }
    }
}
