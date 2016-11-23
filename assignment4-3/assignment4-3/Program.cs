using System;


namespace assignment4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of factorials to see them displayed below!");
            int num = int.Parse(Console.ReadLine());
            int result = 1;

            for(int i = 1; i <= num; i++)
            {
                result *= i;

                Console.WriteLine("{0}! = {1}", i, result);
            }
            Console.ReadLine();
        }
    }
}
