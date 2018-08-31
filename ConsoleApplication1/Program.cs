using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber == 1)
            {
                Console.WriteLine("Your Number is 1");              
            }
            if (userNumber == 2)
            {
                Console.WriteLine("Your Number is 2");                
            }
            if (userNumber == 3)
            {
                Console.WriteLine("Your Number is 3");                
            }
            if (userNumber == 4)
            {
                Console.WriteLine("Your Number is 4");                
            }
            if (userNumber != 1 && userNumber != 2 && userNumber !=3 && userNumber != 4)
            {
                Console.WriteLine("Please pick a number between 1 and 4");              
            }
            Console.Read();
        }
    }
}
