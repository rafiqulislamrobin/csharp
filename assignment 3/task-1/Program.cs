using System;
using System.Collections.Generic;

namespace assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var contactList = new List<Connections>
            {
                new Connections {EmailAddress  ="robin@gmail.com" , SmsNumber ="123456"},
                new Connections {EmailAddress  ="shakil@gmail.com" , SmsNumber ="789456"},
            };
            Button button = new Button();

            button.Clicked += new Button.ClickDelegate(new EmailMessages().SendingMessage);
            button.Clicked += new Button.ClickDelegate(new SmsMessages().SendingMessage);
            button.Click(contactList);

        }



    }
}
