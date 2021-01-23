using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var number1 = Console.ReadLine();
                var number2 = Console.ReadLine();

                if (string.IsNullOrEmpty(number1) || string.IsNullOrEmpty(number2))
                    break;

                var result = new int[number1.Length + number2.Length];

                var x = number1.Length - 1;

                var n1 = 0;


                while (x >= 0)
                {
                    int carry = 0;
                    var n2 = 0;
                    var y = number2.Length - 1;

                    while (y >= 0)
                    {
                        int sum = (number1[x] - '0') * (number2[y] - '0') + result[n1 + n2] + carry;
                        carry = sum / 10;
                        result[n1 + n2] = sum % 10;
                        y--;
                        n2++;
                    }
                    if (carry > 0)
                    {
                        result[n1 + n2] += carry;

                    }
                    x--;
                    n1++;
                }
                
                for (var len = result.Length - 1; len >= 0; len--)
                {
                    Console.Write(result[len]);
                    
                }



            }



        }
    }
}
