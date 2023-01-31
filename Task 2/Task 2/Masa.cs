using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    internal class KvadratMasa : Mebel
    {
        public override double CheckSize()
        {

            Area = Width * Lenght;

            return Area;
            
        }
    }
}
