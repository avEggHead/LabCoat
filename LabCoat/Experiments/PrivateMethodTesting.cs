using System;
using System.Reflection;
using System.Linq;

namespace LabCoat.Experiments
{
    internal class PrivateMethodTesting
        : IExperiment
    {
        public void Experiment()
        {
            Type type = typeof(Hello);
            MethodInfo method = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
                .Where(x => x.Name == "HelloMan" && x.IsPrivate)
                .First();

            Hello hello = new Hello("George", "Smith");
            Console.WriteLine(method.Invoke(hello, new object[] { "henry", "wilson" }));

            Type helloType = typeof(Hello);
            MethodInfo methodInfo = helloType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
                .Where(x => x.Name == "HelloMan" && x.IsPrivate)
                .First();
        }

        public class Hello
        {
            private string _firstName { get; set; }
            private string _lastName { get; set; }

            public Hello(string firstName, string lastName)
            {
                _firstName = firstName;
                _lastName = lastName;
            }

            //public string HelloMan()
            //{
            //    if (string.IsNullOrEmpty(_firstName))
            //        throw new Exception("Missing First Name.");
            //    return this.HelloMan(_firstName, _lastName);
            //}

            private string HelloMan(string firstName, string lastName)
            {
                return $"Hello {firstName} {lastName}!";
            }
        }

        public string IdentifyExperiment()
        {
            return nameof(PrivateMethodTesting);
        }
    }
}