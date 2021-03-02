using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                Console.WriteLine("give an intger input");
                var x = double.Parse(Console.ReadLine());
                Console.WriteLine("give another intger input");
                var y = double.Parse(Console.ReadLine());

                var z = x / y;
                Console.WriteLine($"your ans is {z}\n");
            }


            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                //error or not , this code will run 
                Console.WriteLine("your code End here.");
            }
        }
    }
}
