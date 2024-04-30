using System.Text;
using System;

namespace main1
{
    public class Task4
    {
        public static void Input(int a1, int b1, int k, ref int[][] c, ref int count)
        {
            Random rand = new Random();
            int a = 1;
            for (int i = 0; i < k; i++)
            {
                int b = rand.Next(a1, b1);
                c[i] = new int[b];
                for (int j = 0; j < b; j++)
                {
                    c[i][j] = rand.Next(0, 10);
                    count++;
                }
            }
        }
        public static void Rewrite(ref int count, int k, int[][] c, ref int[] arr)
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
        public static void Round(int count, ref int k)
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
        public static void Output(int k, int[] arr, int count)
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
            Console.WriteLine("Press enter");
        }

        public void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int count = 0;
            Console.WriteLine("Введіть межі a i b через enter");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of lines");
            int k = Convert.ToInt32(Console.ReadLine());
            if (k > 0)
            {
                int[][] c = new int[k][];
                Input(a, b, k, ref c, ref count);
                int[] arr = new int[count];
                Rewrite(ref count, k, c, ref arr);
                Array.Sort(arr);
                Round(count, ref k);
                Console.WriteLine("The result of sorted matrix");
                count = 0;
                Output(k, arr, count);
            }
            else
            {
                Console.WriteLine("Matrix doesn't exist");
            }
            Console.ReadLine();
        }
    }
}