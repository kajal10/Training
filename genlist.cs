using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class CustDemo
    {
        public int CustID
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
        public string City
        {
            get;
            set;
        }
        public int Balance
        {
            get;
            set;
        }
        class Program
        {
            static void Main(string[] args)
            {
                List<CustDemo> cus = new List<CustDemo>();

                CustDemo c = new CustDemo { CustID = 10, Name = "jack", City = "Hyderabad", Balance = 5000 };
                CustDemo c1 = new CustDemo { CustID = 11, Name = "hksj", City = "Mumbai", Balance = 6000 };
                CustDemo c2 = new CustDemo { CustID = 12, Name = "gdyg", City = "Pune", Balance = 8000 };
                CustDemo c3 = new CustDemo { CustID = 13, Name = "hkjdh", City = "akola", Balance = 10000 };
                cus.Add(c);
                cus.Add(c1);
                cus.Add(c2);
                cus.Add(c3);
                foreach (var p in cus)
                    Console.WriteLine(p.CustID + " " + p.Name + " " + p.City + " " + p.Balance);

                Console.ReadKey();
            }
        }
    }
}
