using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_3
{
    public class Button
    {
        public delegate void ClickDelegate(List<Connections> contactlist);

        public event ClickDelegate Clicked;

        public void Click(List<Connections> contactlist)
        {
            Clicked(contactlist);
        }
    }
}
