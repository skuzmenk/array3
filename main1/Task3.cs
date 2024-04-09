using System.Text;
using System;

namespace main1
{
    public class Task3
    {
        public static void Input(ref int[][] arr, int k)
        {
            Console.WriteLine("Your array");
            Random rand = new Random();
            int a = 1;
            for (int i = 0; i < k; i++)
            {
                int b = rand.Next(1, 11);
                arr[i] = new int[b];
                for (int j = 0; j < b; j++)
                {
                    arr[i][j] = rand.Next(0, 10);
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
        public static void Calculations(ref int[][] newarr, int[][] arr, int k)
        {
            int a = 0;
            for (int i = 1; i < k; i += 2)
            {
                newarr[a] = arr[i];
                a++;
            }
        }
        public static void Output(int[][] arr, int[][] newarr)
        {
            Console.WriteLine("The result");
            for (int i = 0; i < arr.Length / 2; i++)
            {
                for (int j = 0; j < newarr[i].Length; j++)
                {
                    Console.Write(newarr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press enter");
        }
        public void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Enter the number of lines");
            int k = Convert.ToInt32(Console.ReadLine());
            int[][] arr = new int[k][];
            Input(ref arr, k);
            int[][] newarr = new int[arr.Length / 2][];
            Calculations(ref newarr, arr, k);
            Output(arr, newarr);
            Console.ReadLine();
        }
    }
}