using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Task_3
{
    internal class Student
    {

        private int _no;
        public string Name;
        public string GroupNo;
        public int count;
        static public int _totalcount;


        public Student()
        {
            _totalcount++;
            _no = _totalcount;



        }






       

    }

}
