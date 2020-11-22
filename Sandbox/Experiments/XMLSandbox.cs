using System;
using System.Xml;

namespace Sandbox.Experiments
{
    internal class XMLSandbox : IExperiment
    {
        public void Execute()
        {
            string s = XmlConvert.ToString(true);
            Console.WriteLine(s);
        }

        public string Identify()
        {
            return typeof(XMLSandbox).Name;
        }
    }
}