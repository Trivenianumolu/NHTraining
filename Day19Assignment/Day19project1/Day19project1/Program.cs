using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day19project1
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("D:\\XmlFiles\\Tagsxml.xml");
            foreach(XmlNode node in xml.DocumentElement.ChildNodes)
            {
                string text = node.InnerText;
                Console.WriteLine(text);
            }
            Console.ReadLine();
        }
    }
}
