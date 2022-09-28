using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace newprpgramm
{
    internal class primeornotprime
    {
        //WAP to check number is prime or not

        public static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("enter the number");
            int num=Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= num; i++)
            {
                if (num % i == 0) 
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("prime number");
            }
            else
            {
                Console.WriteLine("not prime number");
            }
            Console.ReadLine();
        }
    }
}
