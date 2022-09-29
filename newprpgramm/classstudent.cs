using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace newprpgramm
{
    public class Student
    {
        private int rno;
        private string name;
        private double per;

        public void Adddata(int x,string y,double z)
        {
            rno = x;
            name = y;
            per = z;
        }
        public string Getdata()
        {
            return $"classstudent :{rno}\n{name}\n{per}";
        }
    }
}
