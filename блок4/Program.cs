using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba
{
    internal class Task4
    {
        static void Input(int k,ref int[][]c,ref int count)
        {
            Random rand = new Random();
            int a = 1;
            for (int i = 0; i < k; i++)
            {
                int b = rand.Next(1, 11);
                c[i] = new int[b];
                for (int j = 0; j < b; j++)
                {
                    c[i][j] = rand.Next(0, 10);
                    count++;
                }
            }
        }
        static void Rewrite(ref int count,int k, int[][]c,ref int[]arr)
        {
            count = 0;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < c[i].Length; j++)
                {
                    Console.Write(c[i][j] + " ");
                    arr[count] = c[i][j];
                    count++;
                }
                Console.WriteLine();
            }
        }
        static void Round(int count, ref int k)
        {
            for (; count > 0; count--)
            {
                if (Math.Sqrt(count) % 1 == 0)
                {
                    k = (int)Math.Sqrt(count);
                    break;
                }
            }
        }
        static void Output(int k, int[]arr,int count)
        {
            int[,] newarr = new int[k, k];
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    newarr[i, j] = arr[count];
                    count++;
                    Console.Write(newarr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 
            int count = 0;
            
            Console.WriteLine("Введіть кількість рядків");
            int k = Convert.ToInt32(Console.ReadLine());
            if (k > 0)
            {
                int[][] c = new int[k][];
                Input(k,ref c,ref count);
                int[] arr = new int[count];
                Rewrite(ref count,k,c,ref arr);
                Array.Sort(arr);
                Round(count, ref k);
                Console.WriteLine("Виводимо вже відсортований квадратний масив");
                count = 0;
                Output(k,arr,count);
            }
            else
            {
                Console.WriteLine("Матриці не існує");
            }
            Console.ReadLine();
        }
    }
}
