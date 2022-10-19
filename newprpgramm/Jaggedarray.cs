using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newprpgramm
{
    internal class Jaggedarray
    {
        static void Main(string[] args)
        {
            // jagged array
            // row size is fixed & col size is vary.. it is also  called as array of array
            int[][] jarray = new int[3][];

            jarray[0] = new int[] { 1, 2, 3, 4, 5 };
            jarray[1] = new int[] { 10, 20, 30 };
            jarray[2] = new int[] { 100, 200 };

            for (int i = 0; i < jarray.Length; i++) //jarray.Length --> row size 3
            {
                for (int j = 0; j < jarray[i].Length; j++)
                {
                    Console.Write(" " + jarray[i][j]);
                }
                Console.WriteLine();
            }

        }
    }
}
