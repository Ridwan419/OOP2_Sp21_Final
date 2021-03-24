using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = new Account("Rijon", "1122", 5000);
            var a2 = new Account("Ridwan", "3344", 4000);
            a1.Withdraw(500);
            a1.Deposit(1000);
            a1.Transfer(1000, a2);
            a1.showAllTransactions();
            a2.showAllTransactions();
        }
    }
}