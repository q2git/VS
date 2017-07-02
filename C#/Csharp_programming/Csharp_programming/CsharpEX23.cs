using System;

//例23 银行账户

namespace CsharpEX23

{

    class Program

    {

        public static void Example()

        {

            SavingAccount sa = new SavingAccount(23F, 0.23F);

            sa.Credit(34);

            Console.WriteLine(sa.Balance);

            CheckingAccount ca = new CheckingAccount(34f, 1f);

            ca.Debit(15);

            Console.WriteLine(ca.Balance);

        }

    }

    public class Account

    {

        private float balance;

        public Account(float b)

        {

            balance = b >= 0 ? b : 0;

        }

        public Account()

        {

            balance = 0;

        }

        public void Credit(float m)

        {

            balance += m;

        }

        public Boolean Debit(float m)

        {

            if (balance >= m)

            {

                balance -= m;

                return true;

            }

            else

            {

                return false;

            }

        }

        public float Balance

        {

            get { return balance; }

        }

    }

    public class SavingAccount : Account

    {

        private float interest;

        public SavingAccount(float b, float i) : base(b)

        {

            interest = i;

        }

        public float Calculatelnterest()

        {

            return interest * Balance;

        }

    }

    public class CheckingAccount : Account

    {

        private float fee;

        public CheckingAccount(float b, float f) : base(b)

        {

            fee = f;

        }

        public new void Debit(float m)

        {

            if (base.Debit(m))

            {

                base.Debit(fee);

            }

        }

    }

}