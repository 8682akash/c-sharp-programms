using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace newprpgramm
{
    internal class Programme
    {
        static void Main(string[] args)
        {

            //    // Date

            //    Date d1 = new Date();
            //    Console.WriteLine("enter the day month and year");
            //    int day=Convert.ToInt32(Console.ReadLine());
            //    string month=Console.ReadLine();
            //    int year=Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine($"Date={day}/{month}/{year}");
            //    d1.Add(10, "august", 2022);
            //    Console.WriteLine(d1.Get());

            //    // Student

            //    Student cs1 = new Student();

            //    Console.WriteLine("enter the id name and marks");
            //    int id = Convert.ToInt32(Console.ReadLine());
            //    string name = Console.ReadLine();
            //    int phy = Convert.ToInt32(Console.ReadLine());
            //    int chem = Convert.ToInt32(Console.ReadLine());
            //    int math = Convert.ToInt32(Console.ReadLine());
            //    int total = phy + chem + math;
            //    int per = total / 3;
            //    Console.WriteLine($"id={id} name={name} total={total} percentage={per}");            
            //    cs1.Adddata(1, "akash", 52, 96, 99);
            //    cs1.Calculate();
            //    Console.WriteLine(cs1.Getdata());

            //    // Employee

            //    Employee emp1=new Employee();
            //    Console.WriteLine("enter the id name and salary");
            //    int empid = Convert.ToInt32(Console.ReadLine());
            //    string empname = Console.ReadLine();
            //    int salary = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine($"id={empid} name={empname} salary={salary}");
            //    emp1.Adddetails(101, "akash", 20000);
            //    Console.WriteLine(emp1.Getdetails());

            //    //cources

            //    Cource c1 = new Cource();
            //    Console.WriteLine("enter the id name and salary");
            //    int id1 = Convert.ToInt32(Console.ReadLine());
            //    string cn1= Console.ReadLine();
            //    int fee1= Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine($"id={id1} name={cn1}salary={fee1}");
            //    c1.Java(1,"java",450);
            //    Console.WriteLine(c1.Getjava());     

            //    Cource c2 = new Cource();
            //    Console.WriteLine("enter the id name and salary");
            //    int id2 = Convert.ToInt32(Console.ReadLine());
            //    string cn2 = Console.ReadLine();
            //    int fee2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine($"id={id2} name={cn2} salary={fee2}");
            //    c2.Java(1, "python", 40000);
            //    Console.WriteLine(c2.Getjava());

            //    Cource c3 = new Cource();
            //    Console.WriteLine("enter the id name and salary");
            //    int id3 = Convert.ToInt32(Console.ReadLine());
            //    string cn3 = Console.ReadLine();
            //    int fee3 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine($"id={id3} name={cn3} salary={fee3}");
            //    c3.Java(1, "c#", 35000);
            //    Console.WriteLine(c3.Getjava());

            //    //product 

            //    Product p1 = new Product();
            //    Console.WriteLine("enter thr id name per and final price");
            //    p1.Dataadd(1, "HP laptop", 40000, 10.0);
            //    p1.Finalprice();
            //    Console.WriteLine(p1.Display());

            //    //employeec

            //Employeec emp0 = new Employeec();
            //emp0.Payment(1001, "shardul", 15000);
            //emp0.Netsalary();
            //Console.WriteLine(emp0.IH());

            // constuctor student 

            //Conststudent cs1 = new Conststudent();
            //Console.WriteLine(cs1.GetValue());

            //Conststudent cs2=new Conststudent(5,"umesh",80);
            //Console.WriteLine(cs2.GetValue());

            // constuctor cource

            //Cource c5=new Cource();
            //c5.Getinfo();
            //Console.WriteLine(c5.Getinfo());

            //ToString COurce

            //Cource c10 = new Cource();
            //Console.WriteLine(c10);

            //Cource c11=new Cource(10,"priya",36000);
            //Console.WriteLine(c11);



           // ------ Property  in c#


            //property initializer syntax

            PropertyDept pd1 = new PropertyDept();
            pd1.Deptid = 10;
            pd1.Deptname = "cs";
            pd1.Location = "pune";
            Console.WriteLine(pd1);

            // object initializer

            PropertyDept pd2 = new PropertyDept { Deptid = 50 , Deptname = "it ", Location = "baramati" };
            Console.WriteLine($"{pd2.Deptid} {pd2.Deptname}{pd2.Location}");





        }
    }
}
