using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newprpgramm
{

    //WAP to print gross salary

    internal class grossalary
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the sallary");
            int BS=Convert.ToInt32(Console.ReadLine());
            if (BS <= 10000)
            {
                int DA = 10000 / 100 * 80;
                int HRA = 10000 / 100 * 20;
                int GS = BS + DA + HRA;
                Console.WriteLine("gross salary is"+GS);
            }else if(BS <= 15500)
            {
                int DA1 = 15500 / 100 * 90;
                int HRA1 = 15500 / 100 * 35;
                int GS1 = BS + DA1 + HRA1;
                Console.WriteLine("gross salary is" + GS1);
            }
            else
            {
                int DA2 = BS / 100 * 95;
                int HRA2 = BS / 100 * 40;
                int GS2 = BS + DA2 + HRA2;
                Console.WriteLine("gross salary is" + GS2);
            }
        }
    }
}
