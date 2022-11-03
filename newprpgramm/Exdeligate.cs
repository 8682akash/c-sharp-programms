//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static newprpgramm.Exdeligate;

//namespace newprpgramm
//{
//    internal class Exdeligate
//    {
       
//    public delegate string MyDelegate(string str);
//        public class calc
//        {
//            public string upper(string str)
//            {
//                return str.ToUpper();

//            }
//            public string lower(string str)
//            {
//                return str.ToLower();
//            }

//        }
//        internal class Program
//        {
//            static void Main(string[] args)
//            {
//                calc calc = new calc();
//                MyDelegate myDelegate = new MyDelegate(calc.upper);
//                myDelegate += new MyDelegate(calc.lower);

//                Delegate[] list = myDelegate.GetInvocationList();
//                foreach (Delegate d in list)
//                {
//                    Console.WriteLine(d.Method);
//                    Console.WriteLine(d.DynamicInvoke("akash"));
//                }
//            }
//        }
//    }
//}
