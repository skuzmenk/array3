using System;

namespace main1
{
    public class Bloc1
    {
        
            public void Main()
            {
                Console.WriteLine("Enter the number of array elements");
                int N = int.Parse(Console.ReadLine());

                int[] input_array = new int[N];
                ArrayFilling(N, input_array);

                int maxIndex = 0; int minIndex = 0;
                FindExtremeValues(input_array, N, ref maxIndex, ref minIndex);
                SwapExtremeValues(ref minIndex, ref maxIndex);

                int K = N - (Math.Abs(maxIndex - minIndex) + 1);
                int[] modified_array = new int[K];

                NewArrayFilling(N, input_array, ref modified_array, minIndex, maxIndex);

                ShowResult(K, modified_array);
                Console.ReadKey();
            }
           public static void ArrayFilling(int N, int[] array)
            {
               Console.WriteLine("Add the elements using Enter");
                for (int i = 0; i < N; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                }
            }
           public static void FindExtremeValues(int[] array, int N, ref int maxIndex, ref int minIndex)
            {
                int min = int.MaxValue; int max = int.MinValue;

                for (int i = 0; i < N; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                        maxIndex = i;
                    }

                    if (array[i] < min)
                    {
                        min = array[i];
                        minIndex = i;
                    }
                }
            }
            public static void SwapExtremeValues(ref int minIndex, ref int maxIndex)
            {
                int temp = 0;

                if (minIndex > maxIndex)
                {
                    temp = maxIndex;
                    maxIndex = minIndex;
                    minIndex = temp;
                }
            }
            public static void NewArrayFilling(int N, int[] old_array, ref int[] new_array, int minIndex, int maxIndex)
            {
                int count = 0;
                for (int i = 0; i < minIndex; i++)
                {
                    new_array[i] = old_array[i];
                    count++;
                }

                for (int j = maxIndex + 1; j < N; j++)
                {
                    new_array[count] = old_array[j];
                    count++;
                }
            }
            public static void ShowResult(int K, int[] array)
            {
                Console.WriteLine();
            Console.WriteLine("The result:");
                for (int i = 0; i < K; i++)
                {
                    Console.WriteLine(array[i]);
                }
            Console.WriteLine("Press enter");
            }
        
    }
}
