using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_3
{
    public class EmailMessages : ISendingMessages
    {
        public void SendingMessage(List<Connections> contactList)
        {
            foreach (var item in contactList)
            {
                Console.WriteLine($"Sending Email TO :{item.EmailAddress} \n Today we have an Event , please attend if u have time. \n\n");
            }
        }
    }
}
