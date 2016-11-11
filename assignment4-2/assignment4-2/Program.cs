using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to see that number of factorials!");

            int num = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= num; i++)
            {
                int total = 1;
                for (int j = 1; j <= i; j++)
                {
                    total *= j;
                }
                Console.WriteLine("{0}! = {1}", i, total);
            }
            Console.ReadLine();
        }
    }
}
