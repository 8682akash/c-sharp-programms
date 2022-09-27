using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newprpgramm
{
    internal class multiplication
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
                int x=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the second number");
                int y = Convert.ToInt32(Console.ReadLine());
                int z = x * y;
             Console.WriteLine("multiplication of two num is "+z);
        }
    }
}
