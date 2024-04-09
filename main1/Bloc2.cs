using System;

namespace main1
{
    public class Bloc2
    {
        public void Main()
        {
        Start:
            Console.WriteLine("Enter a natural number");

            int N = int.Parse(Console.ReadLine());

            if (N <= 0)
            {
                Console.WriteLine("Oops! Something went wrong.. Check your input");
                goto Start;
            }

            int[][] array = new int[N][];

            ArrayFilling(N, ref array);
            ShowArray(array);

            Console.ReadKey();
        }
        public static void ArrayFilling(int N, ref int[][] array)
        {
            for (int i = 0; i < N; i++)
            {
                if (i == 0)
                {
                    array[i] = new int[] { 0 };
                    continue;
                }

                int sum = 0;
                GetSum(i, out sum);

                int count = 0;
                NumberOfMultiples(N, sum, out count);

                array[i] = new int[count];

                //Finding multiples
                int index = 0;
                for (int j = sum; j <= N; j += sum)
                {
                    array[i][index] = j;
                    index++;
                }
            }
        }
        public static void GetSum(int N, out int sum)
        {
            sum = 0;
            while (N != 0)
            {
                sum += N % 10;
                N /= 10;
            }
        }
        public static void NumberOfMultiples(int N, int sum, out int count)
        {
            count = N / sum;
        }
        public static void ShowArray(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Line #{i}: ");
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press enter");
        }
    }
}