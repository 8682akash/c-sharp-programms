using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newprpgramm
{
    internal class CollectionsArray
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[5]; // 5 size
            // to hold rainfall for a week
            double[] rainfall = new double[7] { 101.3, 67.4, 45.5, 100.4, 100.4, 88.8, 99.7 };

            string[] names = { "Amol", "Rahul", "Kishor", "Rajesh", "Rohan" };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"numbers[{i}] = {numbers[i]}");
            //}

            for (int i = 0; i < rainfall.Length; i++)
            {
                Console.WriteLine(rainfall[i]);
            }

        }
    }
}
