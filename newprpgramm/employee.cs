using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newprpgramm
{
    internal class Employee
    {
        private int empid;
        private string empname;
        private int salary;

        public void Adddetails(int id,string name,int sal)
        {
            empid = id;
            empname = name;
            salary = sal;
        }public string Getdetails()
        {
            return $"Employee: {empid}-{empname}-{salary}";
        }
    }
}
