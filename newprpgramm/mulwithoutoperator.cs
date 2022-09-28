using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newprpgramm
{
    internal class mulwithoutoperator
    {
        public static void Main(string[] args)
        {

            int n1 = Convert.ToInt32(Console.ReadLine());// 3
            int n2 = Convert.ToInt32(Console.ReadLine());//4
            int m = 0;
            for (int i = 1; i <= n2; i++) //1--> 4
            {
                m += n1; //3 +3 +3+3
            }
            Console.WriteLine($"Multiplication {m}");


        }


    }
        
    }

