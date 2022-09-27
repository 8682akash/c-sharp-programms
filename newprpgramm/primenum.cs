using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newprpgramm
{
    internal class primenum
    {
        public static void Main(string[] args)
        {
            for (int num = 1; num <= 100; num++)
            {
                int count = 0;
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
