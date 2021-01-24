using System;
using System.Collections.Generic;
using System.Text;

namespace task_2
{
    class electronics :Products

    {
        public double Discout()
        {
            return product_price * 5 / 100.0;
        }
    }
}
