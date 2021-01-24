using System;
using System.Collections.Generic;
using System.Text;

namespace task_2
{
    public class FestivelEvent : Products
    {
        string eventname;
        
        public DateTime Eventtime(DateTime timelimit)
        {
            return timelimit;
        }
        private string Eventname()
        {
            eventname = Console.ReadLine();
            return eventname;
        }
    }
}
