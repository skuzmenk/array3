using System.Text;
using System;
using System.Linq;

namespace main1
{
    public class Task1
    {
        
            public static void InputArr(ref int[] numbers, ref int T, ref int K)
            {
                Console.WriteLine("Enter elements of the array");
                numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Console.WriteLine("Enter amount elements, which you want to delete");
                T = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the element from which the elements will be deleted ");
                K = Convert.ToInt32(Console.ReadLine());
            }
            public static void SarchNewArrLen(int[] numbers, int K, int T, ref int n)
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
            public static void Change(ref int[] newnumbers, int[] numbers, int K, int T)
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
           public static void Output(int[] newnumbers)
            {
            Console.WriteLine("The result");
                for (int i = 0; i < newnumbers.Length; i++)
                {
                    Console.Write(newnumbers[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Press enter");
            }
            public void Main()
            {
                Console.WriteLine("Enter the length of the array");
                int count = Convert.ToInt32(Console.ReadLine());
                int[] numbers = new int[count];
                int T = 0; int K = 0;
                InputArr(ref numbers, ref T, ref K);
                if (K >= 0 && T>=0)
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