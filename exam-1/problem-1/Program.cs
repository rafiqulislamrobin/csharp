using System;

namespace problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please give your input: ");
            string x = Console.ReadLine();
            int i;
            string j = "";
            for (i = 0; i < x.Length; i++)
            {
                if (x[i] == '!' || x[i] == '&' || x[i] == '#' || x[i] == '$' || x[i] == '@')
                {

                }
                else
                {
                    j = j + x[i];
                }
            }
            Console.WriteLine("");
            Console.WriteLine("your output without special characters: " + j);
        }

    }
}
