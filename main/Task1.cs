using System.Text;
using System;
using System.Linq;

namespace laba
{
    internal class Task1
    {
        public Task1()
        {
              void InputArr(ref int[] numbers, ref int T, ref int K)
              {
                Console.WriteLine("Вводьте елементи масиву");
                numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Console.WriteLine("Введіть кількість елементів, які необхідно видалити");
                T = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введіть з якого номеру починати видалення");
                K = Convert.ToInt32(Console.ReadLine());
              }
              void SarchNewArrLen(int[] numbers, int K, int T, ref int n)
              {
                if (numbers.Length < K + T)
                {
                    n = numbers.Length - (numbers.Length - K);
                }
                if (K > numbers.Length)
                {
                    n = numbers.Length;
                }
                if (numbers.Length >= K + T)
                {
                    n = numbers.Length - T;
                }
              }
              void Change(ref int[] newnumbers, int[] numbers, int K, int T)
              {
                int j = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i < K | i >= K + T)
                    {
                        newnumbers[j] = numbers[i];
                        j++;
                    }
                }
            }
              void Output(int[] newnumbers)
            {
                for (int i = 0; i < newnumbers.Length; i++)
                {
                    Console.Write(newnumbers[i] + " ");
                }
            }
             void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Введіть довжину масиву");
                int count = Convert.ToInt32(Console.ReadLine());
                int[] numbers = new int[count];
                int T = 0; int K = 0;
                InputArr(ref numbers, ref T, ref K);
                if (K >= 0)
                {
                    int n = 0;
                    SarchNewArrLen(numbers, K, T, ref n);
                    int[] newnumbers = new int[n];
                    Change(ref newnumbers, numbers, K, T);
                    Output(newnumbers);
                }
                else
                {
                    Output(numbers);
                }
                Console.ReadLine();
            }
        }
    }
}