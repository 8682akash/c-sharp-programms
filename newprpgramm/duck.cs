using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newprpgramm
{
    internal class duck
    {
        static void Main(string[] args)
        {
            int flag = 0;
            int count = 0;
            string str = Console.ReadLine();
            for (int i = 1; i < str.Length; i++)
            {
                if (str[0] == '0')
                {
                    flag = 1;
                }
                if (str[i] == '0')
                {
                    count++;
                    flag = 0;
                    break;
                }

            }
            if (flag == 1)
            {
                Console.WriteLine("Not Duck");
            }
            else if (count > 0 || flag == 0)
            {
                Console.WriteLine("Duck");
            }

        }
    }
}
