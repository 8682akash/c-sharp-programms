using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newprpgramm
{
    internal class pattern3
    {
        public static void Main(String[] args)
        {
            for (int i = 1; i <= 5; i--)
            {
                for (int j = 5; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }
    }
}
