using System;
using System.Windows.Forms;

namespace Csharp_PKU.Week4
{

    public class DataHouse

    {

        public static void FindData(long ID)

        {

            if (ID > 0 && ID < 1000)

                Console.WriteLine(ID);

            else

                throw new DataHouseException("已到文件尾");

        }

    }

    public class BankATM

    {

        public static void GetBalanceInfo(long ID)

        {

            try

            {

                DataHouse.FindData(ID);

            }

            catch (DataHouseException e)

            {

                throw new MyAppException("账号不存在", e);

            }

        }

    }

    public class DataHouseException : ApplicationException

    {

        public DataHouseException(string message)

        : base(message)

        { }

    }

    public class MyAppException : ApplicationException

    {

        public MyAppException(string message)

        : base(message)

        { }

        public MyAppException(string message, Exception inner)

        : base(message, inner)

        { }

    }

    public class TestException

    {

        public static void Test()

        {

            try

            {

                BankATM.GetBalanceInfo(12345L);

            }

            catch (Exception e)

            {

                MessageBox.Show(string.Format("出现了异常： {0}", e.Message), "Exception");

                MessageBox.Show(string.Format("内部原因： {0}", e.InnerException.Message), "InnerException");

            }

            finally
            {
                MessageBox.Show("Finally");
            }
        }

    }
}
