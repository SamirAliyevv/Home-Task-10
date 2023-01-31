using System;
using System.Runtime.CompilerServices;

namespace Class_Task
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Student student = new Student();


            Console.WriteLine(" FullName :  ");
            string fullname = Console.ReadLine();

            string password;
            do
            {
                Console.WriteLine("Password : ");
                password = Console.ReadLine();



            } while (!User.CheckPassword(password));


            User user = new User
            {

                FullName = fullname,
                Password = password



            };
        }
    }
}
