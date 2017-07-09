using System;
using System.Reflection;

//• 使用Attribute的一般方式
//在程序集、类、域、方法等前面用[] 表示
//可以省略“Attribute”几个字母，只写xxxxx
//可以带参数
//• 位置参数 （相当于构造方法带的参数）
//• 命名参数（域名或属性名=值）

//• 1．声明Attribute类
//从System.Attribute继承而来
//名字要用xxxxAttribute
//• 2．使用Attribute类
//在类及成员上面使用方括号
//可以省略后缀Attribute
//• 3．通过反射访问属性

namespace Csharp_PKU.Week4
{

    [AttributeUsage(AttributeTargets.Class

    | AttributeTargets.Method,

    AllowMultiple = true)]

    public class HelpAttribute : System.Attribute

    {

        public readonly string Url;

        private string topic;

        public string Topic // 属性 Topic 是命名参数

        {

            get

            {

                return topic;

            }

            set

            {

                topic = value;

            }

        }

        public HelpAttribute(string url) // url 是位置参数

        {

            this.Url = url;

        }

    }

    [HelpAttribute("http://msvc/MyClassInfo", Topic = "Test"),

    Help("http://my.com/about/class")]

    class MyClass

    {

        [Help("http;//my.com/about/method")]

        public void MyMethod(int i)

        {

            return;

        }

    }

    public class MemberInfo_GetCustomAttributes

    {

        public static void Test()

        {

            Type myType = typeof(MyClass);

            object[] attributes = myType.GetCustomAttributes(false);

            for (int i = 0; i < attributes.Length; i++)

            {

                PrintAttributeInfo(attributes[i]);

            }

            MemberInfo[] myMembers = myType.GetMembers();

            for (int i = 0; i < myMembers.Length; i++)

            {

                Console.WriteLine("\nNumber {0}: ", myMembers[i]);

                Object[] myAttributes = myMembers[i].GetCustomAttributes(false);

                for (int j = 0; j < myAttributes.Length; j++)

                {

                    PrintAttributeInfo(myAttributes[j]);

                }

            }

        }

        static void PrintAttributeInfo(object attr)

        {

            if (attr is HelpAttribute)

            {

                HelpAttribute attrh = (HelpAttribute)attr;

                Console.WriteLine("----Url: " + attrh.Url + " Topic: " + attrh.Topic);

            }

        }

    }
}
