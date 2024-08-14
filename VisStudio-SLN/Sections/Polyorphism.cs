using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Learning_Proj.Sections
{
    internal interface IPaymentProccessor
    {
        string AccountName { get; set; }
        decimal AccountBalance { get; set; }
        decimal CheckBalance();
        void WithdrawBalance(decimal amount);

    }

    internal class BankAccountProcessor : IPaymentProccessor
    {
        public string AccountName { get; set; }
        public decimal AccountBalance { get; set; }

        public decimal CheckBalance()
        {
            Console.WriteLine($"Your Account Balance is {AccountBalance}$");
            return AccountBalance;
        }

        public void WithdrawBalance(decimal amount)
        {
            if ((AccountBalance - amount) > 0) AccountBalance -= amount;
            else Console.WriteLine("Insufficient Funds");
            CheckBalance();
        }
    }
    /// <summary>  This one implements an interface as a property  </summary>
    internal class CreditCardProcessor : IPaymentProccessor
    {
        public string AccountName { get ; set ; }
        public decimal AccountBalance { get; set ; }

        public decimal CheckBalance()
        {
            Console.WriteLine($"Your Credit Score is {AccountBalance}$");
            return AccountBalance;
        }

        public void WithdrawBalance(decimal amount)
        {
            AccountBalance -= amount;
            CheckBalance();
        }
    }
    internal class BankingService
    {
        public IPaymentProccessor PaymentProccessor { get; set; }


        public BankingService(IPaymentProccessor processor)
        {
            int choice;
            PaymentProccessor = processor;
            Console.WriteLine("Select Service:\n1. Check Balance\n2. Withdraw");
            if (int.TryParse(Console.ReadLine(), out choice))
                switch (choice)
                {
                    case 1:
                        PaymentProccessor.CheckBalance();
                        break;

                    case 2:
                        int amount;
                        if (int.TryParse(Console.ReadLine(), out amount)) PaymentProccessor.WithdrawBalance(amount);
                        else Console.WriteLine("Invalid.");
                        break;
                }
        }


    }
}
