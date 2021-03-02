using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            example();

        }
        static void example()
        {
            List<Students> studentList = new List<Students>
            {
                new Students{ Name ="Robin", Age=25},
                new Students{ Name ="Shakil", Age=26},
                new Students{ Name ="Yousuf", Age=25},
                new Students{ Name ="Mashuq", Age=24},
                new Students{ Name ="Mahadi", Age=30},
                new Students{ Name ="Mahir", Age=19},
                new Students{ Name ="hasan", Age=17}

            };


            var result = from item in studentList
                         orderby item.Age descending , item.Name ascending
                         select item;

            foreach (var n in result)
            {
                if (n.Age >= 20)
                {
                    Console.WriteLine($"Age {n.Age} : Name {n.Name}");
                }

                
            }
        }
    }
}
