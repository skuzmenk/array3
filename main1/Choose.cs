using System;

namespace main1
{
    internal class Choose
    {
        public static void Main(string[] args)
        {

            for (; ; )
            {
                Console.WriteLine("Choose the student Sasha(1) | Yana(2)");
                Console.WriteLine("If you want to end the program, enter 3");
                int choise = Convert.ToInt32(Console.ReadLine());
                if (choise > 3 || choise < 1)
                {
                    Console.WriteLine("You entered the wrong number");
                }
                else
                {
                    if (choise == 3)
                    {
                        break;
                    }
                    else
                    {
                        switch (choise)
                        {
                            case 1:
                                new Program().Main();
                                break;
                            case 2:
                                new Program2().Main();
                                break;
                        }
                    }
                }
            }
        }
    }
}