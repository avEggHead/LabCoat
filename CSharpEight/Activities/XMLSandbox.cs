using System;
using System.Xml;

namespace CSharpEight.Activities
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