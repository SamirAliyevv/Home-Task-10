using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            KvadratMasa masa = new KvadratMasa()
            {
              Material="Wood",
              Width=3,
              Lenght=6,


               

            };




            Console.WriteLine(masa.CheckSize());


            
       
            

        }
    }
}
