using System;
using System.Data.OleDb;

namespace Csharp_PKU.Week12
{
    class DbTest
    {
        public static void Test()
        {
            TestAdapter();
        }

        public static void TestAdapter()
        {
            string strSql = "SELECT * FROM [Publishers]";
            string strConn =
            @"Provider=Microsoft.Jet.OLEDB.4.0;" +
            @"Data Source=Week12\BIBLIO.MDB";
            OleDbConnection MyConn = new OleDbConnection(strConn);
            OleDbCommand MyCommand = new OleDbCommand(strSql, MyConn);
            MyConn.Open();
            //使用DataReader
            OleDbDataReader MyReader = MyCommand.ExecuteReader();
            while (MyReader.Read())
            {
                Console.WriteLine(
                MyReader.GetString(1) +
                MyReader["Name"].ToString() +
                MyReader[2].ToString()
                );
            }
            MyReader.Close();
            //使用Command的ExecuteScalar
            MyCommand.CommandText = "Select Count(*) From [Publishers]";
            int cnt = (int)MyCommand.ExecuteScalar();
            Console.WriteLine(cnt);
            //使用Command的ExecuteNonQuery
            MyCommand.CommandText = "Delete From [Publishers] Where [Name]='T'";
            int cntDeleted = MyCommand.ExecuteNonQuery();
            Console.WriteLine(cntDeleted);
            MyConn.Close();
        }

    }
}
