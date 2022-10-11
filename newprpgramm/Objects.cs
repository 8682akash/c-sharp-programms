using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newprpgramm
{
    internal class Objects
    {
      static void Main(string[] args)
      {
            // property initializer syntax
            //Autopropscource apc1 = new Autopropscource();
            //apc1.Id = Convert.ToInt32(Console.ReadLine());  // internally app calls to set accessor
            //apc1.Name = Console.ReadLine();
            //apc1.Fees = Convert.ToSingle(Console.ReadLine());

            //Console.WriteLine($"{apc1.Id} {apc1.Name} {apc1.Fees}"); // call the get accessor


            //// using object initializer
            //Autopropscource apc2 = new Autopropscource { Id = 2, Name = "Java", Fees = 50000f };
            //Console.WriteLine($"{apc2.Id} {apc2.Name} {apc2.Fees}");

            Autopropsemp ape1=new Autopropsemp();
            Console.WriteLine("Enter the employee id");
            int Empid=Convert.ToInt32(Console.ReadLine());
            string Empname=Console.ReadLine();
            int NPS=Convert.ToInt32(Console.ReadLine());
            ape1.sal();
            Console.WriteLine($"id={Empid} name={Empname} net paid salary={NPS}");



        }
    }
}
