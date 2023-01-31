using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    internal class Name
    {
        public string name;
       
        public string _groupno;
        public string GroupNo
        {
            set
            {

                if (CheckGroupNo(value))
                {
                    _groupno = value;   
                    
                }




            }
            get { return _groupno; }





        }


        static public bool CheckGroupNo(string str)
        {
            if (str.Length < 4)
            {
                return false;
            }
            if (!char.IsUpper(str[0]))
            {
                return false;
            }
            for (int i = 1; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i]))
                {
                    return false;
                }

            }
            return true;
        }
    }
}
