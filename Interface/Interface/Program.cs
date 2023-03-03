using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface Itransaction
    {
        void showTransaction();
        double getamount();
    }
    public class Transaction : Itransaction
    {
        private string tcode;
        private string date;
        private double amount;
        public Transaction()
        {
            tcode = " ";
            date = " ";
            amount = 0.0;
        }
        public Transaction(string c, string d, double a)
        {
            tcode = c;
            date = d;
            amount = a;
        }
        public double getamount()
        {
            return amount;
        }
        public void showTransaction()
        {
            Console.WriteLine("Transaction : {0}", tcode);
            Console.WriteLine("Date Is : {0}", date);
            Console.WriteLine("Amount Is : {0}", amount);
        }
    }
    class Tester
    {
        static void Main(string[] args)
        {
            Transaction obj1 = new Transaction("1001", "09/09/2021", 8595.5);
            Transaction obj2 = new Transaction("1002", "21/10/2021", 4590.5);
            obj1.showTransaction();
            obj2.showTransaction();
            Console.ReadLine();
        }
    }
}

