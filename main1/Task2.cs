using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace main1
{
    public class Task2
    {
        public static void DifSum(ref int n)
        {
            int max = 0;
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
                    max = i;
                }
                if (s > max)
                {
                    max = s;
                }
            }
            n = max;
        }

        public static void Calculation( int n, ref int[][] arr)
            {
                for (int i = 1; i <= arr.GetLength(0); i++)
                {
                    int s = i;
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
            public static void Output(int n, int[][] arr)
            {
            Console.WriteLine("The result");
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
                for (int j = 0; j < arr[s-1].Length; j++)
                {
                    Console.Write(arr[s - 1][j]+" ");
                }
                Console.WriteLine() ;
            }
            Console.WriteLine("Press enter");
        }
        public void Main()
            {
            // Створюємо новий процес для вимірювання пам'яті поточного процесу 
            Process currentProcess = Process.GetCurrentProcess();

            // Отримуємо обсяг пам'яті, використаної поточним процесом (в байтах) 
            long memoryUsed = currentProcess.WorkingSet64;

          Console.WriteLine("Enter your number");
                int n = Convert.ToInt32(Console.ReadLine());
            int l = n;
            DifSum(ref n);
            Console.WriteLine(n);
            int[][] arr = new int[n][];
            Calculation(l, ref arr);
                Output(l, arr);
            // Переведення байтів у кілобайти або мегабайти за необхідності 
            double memoryUsedKB = memoryUsed / 1024.0;
            double memoryUsedMB = memoryUsedKB / 1024.0;

            // Виведення результату 
            Console.WriteLine("Використання пам'яті: " + memoryUsed + " байт (" + memoryUsedKB + " KB or " + memoryUsedMB + " MB)");

            Console.ReadLine();
            }
    }
    
}