//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace newprpgramm
//{
//    public delegate void MyDelegate();
//    public class Bank
//    {
//        public event MyDelegate insufficientbalance; // declare an event
//        public event MyDelegate lowbalance;
//        public event MyDelegate zerobalance;
//        public event MyDelegate updatebalance;
//        public int balance = 5000;

//        public int Credit(int amt)
//        {
//            balance = balance + amt;
//            updatebalance();
//            return balance;
//        }
//        public int Debit(int amt)
//        {
//            balance = balance - amt;

//            if (amt > balance)
//            {
//                insufficientbalance();
//            }
//            else if (balance == 0)
//            {
//                zerobalance();
//            }
//            else if (balance < 3000)
//            {
//                lowbalance();
//            }
//            else
//            {
//                balance = balance - amt;
//            }
//            return balance;
//        }
//    }

//    public class Assignment {


//        static void iMsg()
//        {
//            Console.WriteLine("insufficient balance");
//        }
//        static void dmMsg()
//        {
//            Console.WriteLine("zero balance");
//        }
//        static void dnMsg()
//        {
//            Console.WriteLine("low balance");
//        }

//        static void doMsg()
//        {
//            Console.WriteLine("updated balance");
//        }

//        static void Main(string[] args)
//        {
//            Bank b = new Bank();
//            b.insufficientbalance += new MyDelegate(iMsg);
//            b.zerobalance+=new MyDelegate(dmMsg);
//            b.lowbalance+=new MyDelegate(dnMsg);
//            b.Debit(0);
//            b.Credit(5000);

//        }

//    }











//    //public void CreditAmount(int balance)
//    //        {

//    //        }
//    //    }

//    //    static void Credit(int UpdatedBalance, int balance, int x)
//    //    {
//    //        UpdatedBalance = balance + x;
//    //        Console.WriteLine(UpdatedBalance);

//    //    }
//    //    static void Debit(int CurrentBalance, int balance, int y)
//    //    {
//    //        CurrentBalance = balance - y;
//    //        Console.WriteLine(CurrentBalance);
//    //    }
//    //}

//    //       // static void Main(string[] args)
//    //        {
//    //            Bank b = new Bank();
//    //            b.Credit += new MyDelegate(UpdatedBalance);
//    //            b.Debit += new MyDelegate(CurrentBalance);
//    //            b.CreditAmount(5000);
//}
