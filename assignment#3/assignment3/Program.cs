using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            Console.WriteLine("Please enter a number to find its factorial!");
            Console.WriteLine("Enter 99 to quit..");    //set an unlikely number as the exit condition
            int number = int.Parse(Console.ReadLine());

            while(number != 99) //put the function in a loop to provide for multiple runs
                {
                int i;          //declare ints within the while loop so they are locally available to the for loop
                int result = 1; //declare result as a place holder for our calculations and set it equal to 1 so we can do repeated trials without
                                //an incorrect answer
                for (i = number; i > 0; i--) 
                    {
                        result *= i;
                    }

                    Console.WriteLine("The factorial of your number {0} is {1}", number, result); //display the result

                    Console.WriteLine("Please enter a number to find its factorial!"); //repeat the instructions

                    Console.WriteLine("Enter 99 to quit..");

                 number = int.Parse(Console.ReadLine());
                }
            Console.WriteLine("Goodbye.");
            Console.ReadLine();
        }
    }
}
