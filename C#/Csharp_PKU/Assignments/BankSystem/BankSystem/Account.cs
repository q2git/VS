using System;
using System.Text.RegularExpressions;

namespace BankSystem
{
    [Serializable]
    public class Account
    {
        double money;
        string id;
        string pwd;
        AccountType type;
        readonly DateTime creationDate;


        public Account(string id, string pwd, double money)
        {
            if( money < 0 ) 
                throw new AccountException("open account failed");

            this.id = id;
            this.pwd = pwd;
            this.money = money;
            type = AccountType.SavingAccount;
            creationDate = DateTime.Now;
        }

        public string ID
        {
            get { return id; }
        }

        public AccountType Type
        {
            get { return type; }
            set { type = value; }
        }

        public DateTime CreationDate
        {
            get { return creationDate; }
        }

        public double Balance
        {
            get { return money; }
        }

        public void ChangePwd(string newPwd)
        {
            if (Regex.IsMatch(newPwd, @"^\d{4}$")) //密码为4位数字
            {
                pwd = newPwd;
            }
            else
            {
                throw new AccountException("illegal password");
            }
        }

        public virtual void SaveMoney(double money)
        {
            if (money < 0) 
                throw new AccountException("negtive money");  

            this.money += money;

        }

        public virtual void WithdrawMoney(double money)
        {
            if (money < 0)
                throw new AccountException("negtive money");

            if (this.money < money)
                throw new AccountException("not enough money");
            
            this.money -= money;
        }

        public bool IsMatch(string id, string pwd)
        {
            return id == this.id && pwd == this.pwd;
        }

    }

    //信用账户类
    [Serializable]
    public class CreditAccount : Account
    {
        private readonly double creditlimit; //信用额度
        private double debt; //债务

        public CreditAccount(string id, string pwd, double creditlimit)
            : base(id, pwd, 0d)
        {
            this.creditlimit = creditlimit;
            base.Type = AccountType.CreditAccount;
        }

        public double CreditLimit
        {
            get { return creditlimit; }
        }

        public double Credits
        {
            get { return creditlimit - debt; }
        }

        public double Debts
        {
            get { return debt; }
        }

        public override void SaveMoney(double money)
        {
            if (money < 0)
                throw new AccountException("negtive money");

            if (money > debt)
            {
                base.SaveMoney(money - debt);
                debt = 0;
            }
            else
            {
                debt -= money;
            }

        }

        public override void WithdrawMoney(double money)
        {
            if (money < 0)
                throw new AccountException("negtive money");

            double saving = base.Balance;
            //存款够就直接取
            if (money <= saving)
            {
                base.WithdrawMoney(money);
            }
            //额度加存款不够
            else if (money > Credits + saving)
            {
                throw new AccountException("not enough credits");
            }
            //额度加存款够,取完再减额度
            else
            {
                debt += money - saving;
                base.WithdrawMoney(saving);
            }
        }
    }

}