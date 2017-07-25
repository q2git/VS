using System;
using System.IO;
using System.Xml;
public class Sample
{
	private const string filename = "sampledata.xml";
	public static void Main()
	{
		XmlTextWriter writer = null;
		writer = new XmlTextWriter (filename, null);
		//Ϊʹ�ļ��׶���ʹ������
		writer.Formatting = Formatting.Indented;
		//дXML����
		writer.WriteStartDocument();

		//������ʽ
		String PItext="type='text/xsl' href='book.xsl'";
		writer.WriteProcessingInstruction("xml-stylesheet", PItext);
		//�ĵ�����
		writer.WriteDocType("book", null , null, "<!ENTITY h 'hardcover'>");
		//д��ע��
		writer.WriteComment("sample XML");
		
		//дһ��Ԫ�أ���Ԫ�أ�
		writer.WriteStartElement("book");
		//����
		writer.WriteAttributeString("genre", "novel");
		writer.WriteAttributeString("ISBN", "1-8630-014");

		//����Ԫ��
		writer.WriteElementString("title", "The Handmaid's Tale");
		//Write the style element
		writer.WriteStartElement("style");
		writer.WriteEntityRef("h");
		writer.WriteEndElement(); 
		//�۸�Ԫ��
		writer.WriteElementString("price", "19.95");
		//д�� CDATA
		writer.WriteCData("Prices 15% off!!");
		//�رո�Ԫ��
		writer.WriteEndElement();
		writer.WriteEndDocument();

		writer.Flush();
		writer.Close(); 
		
		//�����ļ�
		XmlDocument doc = new XmlDocument();
		doc.PreserveWhitespace = true;
		doc.Load(filename);  
		//XML�ļ���������ʾ�ڿ���̨
		Console.Write(doc.InnerXml);  
	}
}
