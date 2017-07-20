using System;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace Csharp_PKU.Week10
{
    class XlstTest
    {
        public static void Test()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(@"Week10\BookList.xml");

                XPathNavigator nav = doc.CreateNavigator();
                nav.MoveToRoot();

                //XslTransform xt = new XslTransform(); //obsolete
                XslCompiledTransform xt = new XslCompiledTransform();

                xt.Load(@"Week10\BookList.xslt");

                XmlTextWriter writer = new XmlTextWriter(Console.Out);

                xt.Transform(nav, null, writer);
            }
            catch (XmlException e)
            {
                Console.WriteLine("XML Exception:" + e.ToString());
            }
            catch (XsltException e)
            {
                Console.WriteLine("XSLT Exception:" + e.ToString());
            }
        }

    }

}