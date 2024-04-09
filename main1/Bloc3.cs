using System;

namespace main1
{
    public class Bloc3
    {
        public void Main()
        {
            Console.WriteLine("Enter the number of lines");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[][] array = new int[N][];
            ArrayFilling(N, ref array);

            int count = 0;
            int[] lines_w_smallest_nums = new int[N];
            FindTheSmallest(array, ref lines_w_smallest_nums, ref count);

            int[][] final_array = new int[array.Length - count][];
            ErasingLines(array, lines_w_smallest_nums, ref final_array);

            ShowResult(final_array);
            Console.ReadKey();
        }
        public static void ArrayFilling(int N, ref int[][] array)
        {
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Enter your elements using the Spacebar");
                string[] input = Console.ReadLine().Trim().Split();
                int[] line = new int[input.Length];

                for (int j = 0; j < input.Length; j++)
                {
                    line[j] = int.Parse(input[j]);
                }
                array[i] = line;
            }
        }
        public static void FindTheSmallest(int[][] array, ref int[] lines_w_smallest_nums, ref int count)
        {
            int min = int.MaxValue;

            //finding the smallest
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] <= min)
                    {
                        min = array[i][j];
                    }
                }
            }

            //collecting all lines with the smallest number
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] == min)
                    {
                        lines_w_smallest_nums[count] = i;
                        count++;
                        break;
                    }
                }
            }
        }
        public static void ErasingLines(int[][] array, int[] lines_w_smallest_nums, ref int[][] final_array)
        {
            int j = 0; int k = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i == lines_w_smallest_nums[j])
                {
                    j++;
                }
                else
                {
                    final_array[k] = array[i];
                    k++;
                }
            }
        }
        public static void ShowResult(int[][] final_array)
        {
            Console.WriteLine();
            Console.WriteLine("The final version of matrix is shown below");

            for (int i = 0; i < final_array.Length; i++)
            {
                for (int j = 0; j < final_array[i].Length; j++)
                {
                    Console.Write(final_array[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press enter");
        }
    }
}
