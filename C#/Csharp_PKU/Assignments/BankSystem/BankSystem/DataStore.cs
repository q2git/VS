using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace BankSystem
{
    public class DataStore
    {
        private List<Account> _accountStore;
        private readonly string _filename;

        public DataStore()
        {
            _filename = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "AccountStore.bin");

            Deserialize();
        }

        public void Save(Account account)
        {
            if (!_accountStore.Contains(account))
                _accountStore.Add(account);

            Serialize();
        }

        public void Delete(Account account)
        {
            _accountStore.Remove(account);

            Serialize();
        }

        public List<Account> FindAll()
        {
            return new List<Account>(_accountStore);
        }

        private void Serialize()
        {
            using (FileStream stream = File.Open(_filename, FileMode.OpenOrCreate))
            {
                //XmlSerializer serializer = new XmlSerializer(typeof(Account));
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(stream, _accountStore);
            }
        }

        private void Deserialize()
        {
            if (File.Exists(_filename))
            {
                using (FileStream stream = File.Open(_filename, FileMode.Open))
                {
                    //XmlSerializer serializer = new XmlSerializer(typeof(Account));
                    BinaryFormatter serializer = new BinaryFormatter();
                    _accountStore = (List<Account>)serializer.Deserialize(stream);
                }
            }
            else
            {
                _accountStore = new List<Account>();
            }
        }
    }
}
