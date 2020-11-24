using System;
using System.Xml;

namespace Sandbox.Experiments
{
    internal class XMLSandbox : IExperiment
    {
        public void Experiment()
        {
            string s = XmlConvert.ToString(true);
            Console.WriteLine(s);
        }

        public string IdentifyExperiment()
        {
            return typeof(XMLSandbox).Name;
        }
    }
}