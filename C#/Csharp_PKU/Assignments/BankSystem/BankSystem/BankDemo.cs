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
            Console.WriteLine();
            Console.WriteLine(string.Format("{0, -30}","Warning: Big Money Fetched!"));
            Console.WriteLine(string.Format("{0, -15}{1, -15}", "Account ID: ", e.ID));
            Console.WriteLine(string.Format("{0, -15}{1, -15:C3}", "Money: " , e.Money));
            Console.BackgroundColor = ConsoleColor.Black;
        }

    }
}