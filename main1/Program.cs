using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main1
{
    internal class Program
    {
        public void Main()
        {
            
            for (; ; )
            {
                Console.WriteLine("Choose the task (1-4)");
                Console.WriteLine("If you want to end the program, enter 5");
                int choise = Convert.ToInt32(Console.ReadLine());
                if (choise > 5 || choise < 1)
                {
                    Console.WriteLine("You entered the wrong number");
                }
                else
                {
                    if (choise == 5)
                    {
                        break;
                    }
                    else
                    {
                        switch (choise)
                        {
                            case 1:
                                new Task1().Main();
                                break;
                            case 2:
                                new Task2().Main();
                                break;
                            case 3:
                                new Task3().Main();
                                break;
                            case 4:
                                new Task4().Main();
                                break;
                        }
                    }
                }
            }
        }
    }
}
