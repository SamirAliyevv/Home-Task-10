using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    internal class KubDivan:Mebel
    {
        public int Height;

        public override double CheckSize()
        {
            Area = Height * Width * Lenght;

            return Area;
        }
    }
}
