using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newprpgramm
{
    internal class Generic
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(91, "IND");
            
            foreach (KeyValuePair<int, string> item in dictionary)
            {
                Console.WriteLine(item.Key + item.Value);
            }
        }

    }
}
