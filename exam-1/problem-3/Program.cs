using System;

namespace problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number");
            int x = int.Parse(Console.ReadLine());
            int i;
            
            for (i=2; i<x; i++)
            {
                if (x % i == 0)
                {
                    Console.WriteLine("your number's prime factors : " + i);
                }
            }
        }
    }
}
