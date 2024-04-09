using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba
{
    internal class Task3
    {
        static void Input(ref int[][] arr, int k)
        {
            Console.WriteLine("Початковий масив");
            Random rand = new Random();
            int a = 1;
            for (int i = 0; i < k; i++)
            {
                int b = rand.Next(1, 11);
                arr[i] = new int[b];
                for (int j = 0; j < b; j++)
                {
                    arr[i][j] = rand.Next(0, 10);
                    Console.Write(arr[i][j]+" ");
                }
                Console.WriteLine();
            }

        }
        static void Calculations(ref int[][] newarr,int[][]arr, int k)
        {
            int a = 0;
            for (int i = 1; i < k; i += 2)
            {
                newarr[a] = arr[i];
                a++;
            }
        }
        static void Output(int[][] arr, int[][]newarr)
        {
            Console.WriteLine("Виведення відредагованого масиву");
            for (int i = 0; i < arr.Length / 2; i++)
            {
                for (int j = 0; j < newarr[i].Length; j++)
                {
                    Console.Write(newarr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть кількість рядків");
            int k = Convert.ToInt32(Console.ReadLine());
            int[][] arr = new int[k][];
            Input(ref arr, k);
            int[][]newarr = new int[arr.Length/2][];
            Calculations(ref newarr, arr,k);
            Output(arr, newarr);
            Console.ReadLine();
        }
    }
}
