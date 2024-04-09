using System;

namespace main1
{
    public class Task2
    {
        
            public static void Calculation(ref int n, ref int[][] arr)
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
            public static void Output(int n, int[][] arr)
            {
            Console.WriteLine("The result");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        Console.Write(arr[i][j] + " ");
                    }
                    Console.WriteLine();
                }
            Console.WriteLine("Press enter");
        }
        public void Main()
            {
            Console.WriteLine("Enter your number");
                int n = Convert.ToInt32(Console.ReadLine());
                int[][] arr = new int[n][];
                Calculation(ref n, ref arr);
                Output(n, arr);
                Console.ReadLine();
            }
    }
    
}