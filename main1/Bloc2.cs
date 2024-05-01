using System;
using System.Diagnostics;

namespace main1
{
    public class Bloc2
    {
        public void Main()
        {
            // Створюємо новий процес для вимірювання пам'яті поточного процесу
            Process currentProcess = Process.GetCurrentProcess();
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

            // Отримуємо обсяг пам'яті, використаної поточним процесом (в байтах)
            long memoryUsed = currentProcess.WorkingSet64;

            // Переведення байтів у кілобайти або мегабайти за необхідності
            double memoryUsedKB = memoryUsed / 1024.0;
            double memoryUsedMB = memoryUsedKB / 1024.0;

            // Виведення результату
            Console.WriteLine("Використання пам'яті: " + memoryUsed + " байт (" + memoryUsedKB + " KB or " + memoryUsedMB + " MB)");

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