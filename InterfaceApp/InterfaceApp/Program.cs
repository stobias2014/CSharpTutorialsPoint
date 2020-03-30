//interface is contract that all class which inherit should follow
//implementing class must abide by contract and implement methods of interface
//interface defines what a class can do
//deriving class defines the how

using System;

namespace InterfaceApp
{
    //interface declaration
    public interface ITransactions {
        //interface members
        //only declared but not implemented
        void showTransaction();
        double getAmount();
    }

    //if no implementation, compilation errors
    public class Transaction : ITransactions
    {
        private string tCode;
        private string date;
        private double amount;

        public Transaction()
        {
            tCode = "";
            date = "";
            amount = 0.0;
        }

        public Transaction(string tCode, string date, double amount) {
            this.tCode = tCode;
            this.date = date;
            this.amount = amount;
               
        }

        //implemented method from interface
        public double getAmount() {
            return amount;
        }

        public void showTransaction() {
            Console.WriteLine("Transaction: {0}", this.tCode);
            Console.WriteLine("Date: {0}:", this.date);
            Console.WriteLine("Amount: {0}", this.amount);
        }
        


    }


    class Program
    {
        static void Main(string[] args)
        {
            Transaction t1 = new Transaction();
            Transaction t2 = new Transaction("code", "date", 9.3);

            t1.showTransaction();
            t2.showTransaction();
        }
    }
}
