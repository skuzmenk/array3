using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using laba;
using System.Threading.Tasks;

namespace laba
{
     class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Виберіть блок");
            int choise = Convert.ToInt32(Console.ReadLine());
            switch(choise)
            {
                case 1:
                    Task1 task1 = new Task1();
                    new Task1().Equals(task1);
                    break;
            }
            Console.ReadLine();
        }
    }
}
