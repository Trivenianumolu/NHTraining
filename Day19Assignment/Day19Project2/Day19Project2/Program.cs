using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day19project2
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("D:\\XmlFiles\\Tagsxml.xml");
            foreach (XmlNode node in xml.DocumentElement.ChildNodes)
            {
                foreach(XmlNode node1 in node.ChildNodes)
                {
                    if(node1.Name=="Name")
                        Console.WriteLine(node1.InnerText);

                }
                
            }
            Console.ReadLine();
        }
    }
}
