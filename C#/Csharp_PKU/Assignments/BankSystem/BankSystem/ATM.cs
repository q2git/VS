using System;
using System.Collections;

namespace BankSystem
{
    public class ATM : IATM
    {

        readonly Bank bank;
        Account currentAccount = null;
        public event BigMoneyFetchedHandler BigMoneyFetched;

        public ATM(Bank bank)
        {
            this.bank = bank;
        }

        public Bank Bank
        {
            get { return bank; }
        }

        public void Run()
        {
            while (true)
            {
                Show();

                if (currentAccount == null)
                {
                    userLogin();
                }
                else
                {
                    Transaction();
                }
            }
        }

        public void Transaction()
        {
            string op = GetInput("choice");
                
            switch (op)
            {
                case "1":
                    displayAccount();
                    break;

                case "2":
                    saveMoney();
                    break;

                case "3":
                    withdrawMoney();
                    break;

                case "4":
                    changePsw();
                    break;

                case "5":
                    userLogout();
                    break;

                default:
                    Show("Error: Wrong input");
                    break;
            }

        }

        private void displayAccount()
        {
            string msg = string.Format("\n{0, 50}", new string('-', 50));
            msg += String.Format("\n| {0, -20}| {1, -24} |", "ACCOUNT ID:", currentAccount.ID);
            msg += string.Format("\n{0, 50}", new string('-', 50));
            msg += String.Format("\n| {0, -20}| {1, -24} |", "ACCOUNT TYPE:", currentAccount.Type);
            msg += string.Format("\n{0, 50}", new string('-', 50));
            msg += String.Format("\n| {0, -20}| {1, -24} |", "CREATION DATE:", currentAccount.CreationDate);
            msg += string.Format("\n{0, 50}", new string('-', 50));
            msg += String.Format("\n| {0, -20:c}| {1, -24} |", "BALANCE:", currentAccount.Balance);
            msg += string.Format("\n{0, 50}", new string('-', 50));

            if (currentAccount.Type == AccountType.CreditAccount)
            {
                msg += String.Format("\n| {0, -20:c}| {1, -24} |", "CREADIT LIMIT:", ((CreditAccount)currentAccount).CreditLimit);
                msg += string.Format("\n{0, 50}", new string('-', 50));
                msg += String.Format("\n| {0, -20:c}| {1, -24} |", "CURRENT CREDITS:", ((CreditAccount)currentAccount).Credits);
                msg += string.Format("\n{0, 50}", new string('-', 50));
                msg += String.Format("\n| {0, -20:c}| {1, -24} |", "CURRENT DEBTS:", ((CreditAccount)currentAccount).Debts);
                msg += string.Format("\n{0, 50}", new string('-', 50));
            }

            Show(msg + "\n");
            GetInput("wait");
        }

        private void saveMoney()
        {
            try
            {
                double money = double.Parse(GetInput("save"));

                currentAccount.SaveMoney(money);
                bank.SaveAccount(currentAccount);

                displayAccount();
            }
            catch(Exception e)
            {
                Show("Error: " + e.Message);
            }
        }

        private void withdrawMoney()
        {
            try
            {
                double money = double.Parse(GetInput("withdraw"));

                if (new Random().Next(3) == 0)
                    throw new BadCashException("Bad Cash");

                currentAccount.WithdrawMoney(money);

                if (BigMoneyFetched != null && money > 10000)
                    BigMoneyFetched(this, new BigMoneyArgs(currentAccount.ID, money));

                bank.SaveAccount(currentAccount);

                displayAccount();
            }
            catch (Exception e)
            {
                Show("Error: " + e.Message);
            }
        }

        private void changePsw()
        {
            try
            {
                currentAccount.ChangePwd(GetInput("pwd"));
                bank.SaveAccount(currentAccount);
            }
            catch (AccountException e)
            {
                Show("Error: " + e.Message);
            }
        }

        private void userLogin()
        {
            try
            {
                Account account = bank.SearchAccount(GetInput("id"));
                currentAccount = bank.VerifyPsw(account, GetInput("pwd"));
            }
            catch (Exception e)
            {
                Show("Error: " + e.Message);
            }
        }

        private void userLogout()
        {
            currentAccount = null;
        }

        private void Show(string msg)
        {
            if (msg.StartsWith("Error"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(msg);
                GetInput("wait");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(msg);
            }
        }

        private void Show()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string('#', 70));
            Console.WriteLine(string.Format("{0, -19} Welcome to XXX Bank ATM System {1, 19}", 
                new string('#', 15), new string('#', 15)));
            Console.WriteLine(new string('#', 70));
        }
      
        private string GetInput(string prompt)
        {
            switch (prompt.ToUpper())
            {
                case "PWD":
                    prompt = "Please input your password: ";
                    break;
                case "ID":
                    prompt = "Please insert your card: ";
                    break;
                case "SAVE":
                    prompt = "Save Money: ";
                    break;
                case "WITHDRAW":
                    prompt = "Withdraw Money: ";
                    break;
                case "CHOICE":
                    prompt = "1: Account Info; 2: Save Money; 3: Withdraw Money;" +
                        "\n4: Change Password; 5: Exit" +
                        "\nPlease choose: ";
                    break;
                case "WAIT":
                    prompt = "Press any key to continue...";
                    break;
            }

            Show(prompt);
            return Console.ReadLine();
        }
    }

}