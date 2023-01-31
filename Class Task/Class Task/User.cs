using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Task
{
    internal class User
    {
        public string FullName;
        public string _password;





        public string Password
        {

            set
            {
                if (CheckPassword(value))
                {
                    _password = value;

                }


            }




        }


        static public bool CheckPassword(string str)
        {

            if (string.IsNullOrWhiteSpace(str) || str.Length <8 )
            {
                return false;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i]))
                {
                    return true;
                }

            }
            return false;










        }
    }
}
