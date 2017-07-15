using System;


namespace BankSystem
{
    public class BankDemo
    {
        public static void Main(string[] args)
        {
            Bank bank = new Bank();

            //bank.OpenAccount("2222", "2222", 20000);
            //bank.OpenAccount("3333", "3333", 50);
            //bank.OpenAccount(1000, "1111", "1111"); //创建CreditAccount

            ATM atm = new ATM(bank);

            atm.BigMoneyFetched += atm_BigMoneyFetched;
            atm.Run();
            //atm.Transaction();
        }

        static void atm_BigMoneyFetched(object sender, BigMoneyArgs e)
        {
            //throw new System.NotImplementedException();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("$ Warning: Big Money Fetched! $");
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.BackgroundColor = ConsoleColor.Black;
        }

    }
}