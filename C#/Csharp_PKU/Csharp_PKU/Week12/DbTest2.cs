﻿using System;
using System.Data;
using System.Data.OleDb;

namespace Csharp_PKU.Week12
{
    class DbTest2
    {
        public static void Test()
        {
            TestAdapter();
        }
        public static void TestAdapter()
        {
            string strSql = "SELECT * FROM [Publishers]";
            // 连接串
            string strConn =
            @"Provider=Microsoft.Jet.OLEDB.4.0;" +
            @"Data Source=Week12\BIBLIO.MDB";
            //注：如果是accdb文件,则用下面的方式
            // @"Provider=Microsoft.ACE.OLEDB.12.0;" +
            // @"Data Source="+Environment.CurrentDirectory+@"\english.accdb";
            // 连接
            OleDbConnection conn = new OleDbConnection(strConn);
            // 适配器
            OleDbDataAdapter daAdapter = new OleDbDataAdapter(strSql, conn);
            // 命令建立器
            OleDbCommandBuilder cmdbld = new OleDbCommandBuilder(daAdapter);
            // 数据集
            DataSet dsMyData = new DataSet();
            // 填充数据
            daAdapter.Fill(dsMyData);
            // 访问数据
            foreach (DataTable table in dsMyData.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (object field in row.ItemArray)
                    {
                        Console.Write(field);
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine(dsMyData.Tables[0].Rows[0][1]);
            // 在内存中选择、计算数据
            DataTable myTable = dsMyData.Tables[0];
            string strExpr = "Name Like 'T*'";
            DataRow[] foundRows = myTable.Select(strExpr);
            for (int i = 0; i < foundRows.Length; i++)
            {
                Console.WriteLine(foundRows[i][1]);
            }
            // 在内存中修改数据
            DataRow row1 = dsMyData.Tables[0].Rows[0];
            row1.BeginEdit();
            row1[1] = "Tang";
            row1[2] = "Peking Univ.";
            row1[3] = "Beijing";
            row1.EndEdit();
            row1.AcceptChanges();
            // 提交数据的改变
            daAdapter.Update(dsMyData);
            // 将数据标为已改变
            dsMyData.AcceptChanges();
            myTable.AcceptChanges();
            // DataSet与XML操作
            dsMyData.WriteXml("test.xml");
            dsMyData.ReadXml("test.xml");
        }
    }
}
