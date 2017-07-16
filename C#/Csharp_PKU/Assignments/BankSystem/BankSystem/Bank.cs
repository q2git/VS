using System.Collections.Generic;

namespace BankSystem
{
    public class Bank 
    {
	    List<Account> accounts; // = new List<Account>();
        DataStore dataStore;

        public Bank()
        {
            dataStore = new DataStore();
            accounts = dataStore.FindAll();
        }
	
	    public Account OpenAccount(string id, string pwd, double money)
	    {
		    Account account = new Account(id, pwd, money);

		    accounts.Add( account );
            UpdateAccount(account);

		    return account;
	    }
        
        public Account OpenAccount(double credit, string id, string pwd)
        {
            CreditAccount account = new CreditAccount(id, pwd, credit);

            accounts.Add(account);
            UpdateAccount(account);

            return account;
        }

	    public bool CloseAccount(Account account) 
	    {
		    int idx = accounts.IndexOf(account);
		    if(idx<0)return false;

		    accounts.Remove(account);
            DeleteAccount(account);

		    return true;		
	    }

        public void UpdateAccount(Account account)
        {
            dataStore.Update(account);
        }

        public void DeleteAccount(Account account)
        {
            dataStore.Delete(account);
        }

        public Account SearchAccount(string id)
        {
            foreach (Account account in accounts)
                if (account.ID == id)
                    return account;

            throw new BankException("inexistent account");
        }

        public Account VerifyPsw(Account account, string psw)
        {
            if (account.IsMatch(account.ID, psw))
                return account;

            throw new BankException("incorrect password");
        }

	    public Account FindAccount(string id, string pwd)
	    {
            foreach (Account account in accounts)
            {
                if (account.IsMatch(id, pwd))
                {
                    return account;
                }
            }
            //for (int i = 0; i < accounts.Count; i++)
            //{
            //    Account account = accounts[i];

            //    if (account.IsMatch(id, pwd))
            //    {
            //        return account;
            //    }
            //}

		    return null;
	    }

    }

}