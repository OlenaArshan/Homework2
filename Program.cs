using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentValueCalculator {
    enum TransactionType {
        Buy, Sell
    }
    class Program {
        static void Main(string[] args) {
            double tradePrice;
            Console.WriteLine("Input the nominal of the trade:");
            string userInput = Console.ReadLine();
            int nominal = Int32.Parse(userInput);

            Console.ReadLine();
        }
    }
}
