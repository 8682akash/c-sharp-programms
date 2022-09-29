using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newprpgramm
{
    internal class programme
    {
        static void Main(string[] args)
        {
            Student cs1=new Student();
            Console.WriteLine("enter rno name and per");
            int x=Convert.ToInt32(Console.ReadLine());
            string y=Console.ReadLine();
            double z=Convert.ToDouble(Console.ReadLine());
            cs1.Adddata(x,y,z);
            Console.WriteLine(cs1.Getdata());
            Student cs2=new Student();
            cs2.Adddata(x,y,z);
            Console.WriteLine(cs2.Getdata());
        }
    }
}
