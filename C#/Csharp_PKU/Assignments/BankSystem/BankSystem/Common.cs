using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public delegate void BigMoneyFetchedHandler(object sender, BigMoneyArgs e);

    public class BigMoneyArgs
    {
        private string _id;
        private double _money;
        public BigMoneyArgs(string id, double money)
        {
            _id = id;
            _money = money;
        }

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public double Money
        {
            get { return _money; }
            set { _money = value; }
        }
    }

    public class BankException : ApplicationException
    {
        public BankException(string message)
            : base(message) { }

        public BankException(string message, Exception inner)
            : base(message, inner) { }
    }

    public class AccountException : ApplicationException
    {
        public AccountException(string message)
            : base(message) { }

        public AccountException(string message, Exception inner)
            : base(message, inner) { }
    }

    public class BadCashException : ApplicationException
    {
        public BadCashException(string message)
            : base(message) { }

    }


    public class BadCash
    {
        public static void GenerateBadCash()
        {
            if (new Random().Next(3) == 0)
                throw new BadCashException("Bad Cash");
        }
    }

    public interface IATM
    {
        event BigMoneyFetchedHandler BigMoneyFetched;

        Bank Bank { get; }

        void Transaction();

        void Run();

    }

    public enum AccountType
    {
        SavingAccount,
        CreditAccount
    }

}
