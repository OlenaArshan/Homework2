using System;

namespace CurrentValueCalculator {
    enum TransactionType {
        Buy, Sell
    }
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Input the nominal of the trade:");
            string userInput = Console.ReadLine();
            int nominal = int.Parse(userInput ?? "0");

            Console.WriteLine("Input the trade price of the deal:");
            userInput = Console.ReadLine();
            double price = double.Parse(userInput ?? "0");

            Console.WriteLine("Input the transaction type:");
            userInput = Console.ReadLine();
            TransactionType trcType = (TransactionType)Enum.Parse(typeof(TransactionType), userInput ?? "0", true);

            int sign = trcType == TransactionType.Buy ? 1 : -1;
            double currentValue = sign * nominal * price;
            Console.WriteLine($"The current value of a deal is: {currentValue}");

            Console.ReadLine();
        }
    }
}
