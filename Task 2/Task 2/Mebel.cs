using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Task_2
{
     abstract class Mebel
     {
        public string Material;
        public  double Width ;
        public double  Lenght;
        public double  Area;

        public  abstract double  CheckSize();
        


     }
}
