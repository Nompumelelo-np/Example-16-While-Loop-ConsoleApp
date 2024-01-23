using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_16_While_Loop_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = 0;

            Console.WriteLine("This is the while loop");
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }
            Console.WriteLine("This is the do while loop");

            int index2 = 0;
            do
            {
                
                Console.WriteLine(index2);
                index2++;
            }
            while (index2 <= 5);

            Console.Read();

        }
    }
}
