using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace CSharpEight
{
    internal class XMLSandbox : IExecute
    {
        public void Execute()
        {
            string s = XmlConvert.ToString(true);
            Console.WriteLine(s);
        }
    }
}