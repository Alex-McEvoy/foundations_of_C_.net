using System;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            long i, x, result;      //use long to account for potentially large factorial numbers
            
            Console.WriteLine("Please enter a number to see that number of factorials:");

            long num = long.Parse(Console.ReadLine());

            long[] arry = new long[num];    //set the array size to whatever number the user enters
            
            for(x = 0; x < num; x++)        //set one loop to cycle through all the numbers in the array
            {
                for(i = x+1, result = 1; i > 0; i--) //set a second loop to calculate the factorial in that location in the array
                {
                    result *= i;
                }
                arry[x] = result;       //set that array location to the desired result
            }

            for (x = 0; x < num; x++)  //for loop to display the results
            {
                Console.WriteLine("{0}!\t=\t{1}", x + 1, arry[x]);
            }
            Console.ReadLine();
        }
    }
}
