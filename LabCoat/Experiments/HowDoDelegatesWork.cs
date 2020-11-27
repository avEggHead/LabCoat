namespace LabCoat.Experiments
{
    using System;

    internal class HowDoDelegatesWork : IExperiment
    {
        public delegate int Transformer(int x);

        public delegate string Stringer(int x);

        private static int Square(int x)
        {
            return x * x;
        }

        private static string GimmeAnIntIllGiveYaAString(int x)
        {
            return x.ToString();
        }

        public void Experiment()
        {
            Transformer t = Square;
            Console.WriteLine(t(3));
            Transformer t2 = (a) => 20 + 20;
            Stringer stringer = GimmeAnIntIllGiveYaAString;
            Console.WriteLine(nameof(stringer) + " is a " + stringer(44).GetType() + " and it's value is " + stringer(44));
            Console.WriteLine(t2(4));
        }

        public string TakeAMethodAsAParameter(Transformer transformer)
        {
            int result = transformer(4);

            return result.ToString();
        }

        public string IdentifyExperiment()
        {
            return nameof(HowDoDelegatesWork);
        }
    }
}