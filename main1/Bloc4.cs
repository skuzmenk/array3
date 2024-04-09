using System;

namespace main1
{
    public class Bloc4
    {
        public void Main()
        {
            int columns = 1; int lines = 1; int lower_bound = 0; int upper_bound = 0;
            data_input(ref columns, ref lines, ref lower_bound, ref upper_bound);

            int[,] original_matrix = new int[lines, columns];
            original_matrix_filling(ref original_matrix, lower_bound, upper_bound);

            int[,] transposed_matrix = new int[columns, lines]; //lines go first, then columns, so we just swapped their order here
            transposed_matrix_filling(original_matrix, ref transposed_matrix, lower_bound, upper_bound);

            int[,] swapped_lines_matrix = new int[columns, lines];
            swapping_lines(transposed_matrix, ref swapped_lines_matrix);

            checking_lines(ref swapped_lines_matrix);

            Console.WriteLine("Your final matrix:");
            output(swapped_lines_matrix);

            Console.ReadKey();
        }
        public static void data_input(ref int columns, ref int lines, ref int lower_bound, ref int upper_bound)
        {
            Console.WriteLine("Enter the number of columns");
            columns = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the number of lines");
            lines = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Now choose the range of numbers for the matrix:");
            Console.WriteLine("Enter the lower bound");
            lower_bound = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the upper bound");
            upper_bound = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        public static void original_matrix_filling(ref int[,] original_matrix, int lower_bound, int upper_bound)
        {
            Random generator = new Random();

            for (int i = 0; i < original_matrix.GetLength(0); i++)
            {
                for (int j = 0; j < original_matrix.GetLength(1); j++)
                {
                    original_matrix[i, j] = generator.Next(lower_bound, upper_bound);
                }
            }

            Console.WriteLine("Your original matrix:");
            output(original_matrix);
        }
        public static void transposed_matrix_filling(int[,] original_matrix, ref int[,] transposed_matrix, int lower_bound, int upper_bound)
        {
            for (int i = 0; i < transposed_matrix.GetLength(0); i++)
            {
                for (int j = 0; j < transposed_matrix.GetLength(1); j++)
                {
                    transposed_matrix[i, j] = original_matrix[j, i];
                }
            }
            Console.WriteLine("Your transposed matrix:");
            output(transposed_matrix);
        }
        public static void swapping_lines(int[,] transposed_matrix, ref int[,] swapped_lines_matrix)
        {
            int k = transposed_matrix.GetLength(0) - 1;

            for (int i = 0; i < transposed_matrix.GetLength(0); i++)
            {
                for (int j = 0; j < transposed_matrix.GetLength(1); j++)
                {
                    swapped_lines_matrix[i, j] = transposed_matrix[k, j];
                }
                k--;
            }
            Console.WriteLine("Your matrix with swapped lines:");
            output(swapped_lines_matrix);
        }

        public static void checking_lines(ref int[,] swapped_lines_matrix)
        {
            for (int i = 0; i < swapped_lines_matrix.GetLength(0); i++)
            {
                for (int j = 0; j < swapped_lines_matrix.GetLength(1); j++)
                {
                    if (j < swapped_lines_matrix.GetLength(1) / 2 && swapped_lines_matrix[i, j] == 0)
                    {
                        for (int t = 0; t < swapped_lines_matrix.GetLength(1); t++)
                        {
                            swapped_lines_matrix[i, t] = 0;
                        }
                        break;
                    }
                    else if (j > swapped_lines_matrix.GetLength(1) / 2)
                    {
                        int temp, smallest;

                        for (int m = 0; m < swapped_lines_matrix.GetLength(1) - 1; m++)
                        {
                            smallest = m;

                            for (int k = m + 1; k < swapped_lines_matrix.GetLength(1); k++)
                            {
                                if (swapped_lines_matrix[i, k] < swapped_lines_matrix[i, smallest])

                                { smallest = k; }
                            }

                            temp = swapped_lines_matrix[i, smallest];
                            swapped_lines_matrix[i, smallest] = swapped_lines_matrix[i, m];
                            swapped_lines_matrix[i, m] = temp;
                        }
                        break;
                    }
                }
            }
        }
        public static void output(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}