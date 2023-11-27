namespace LabCoat.Experiments
{
    using System;
    using System.Data;

    internal class DelegateExp : IExperiment
    {
        delegate int DelegateWIthTwoIntParameterReturnInt(int x, int y);

        public void Experiment()
        {
            DelegateWIthTwoIntParameterReturnInt delOb = new DelegateWIthTwoIntParameterReturnInt(Multiply);
            DelegateWIthTwoIntParameterReturnInt delOba = Sum;

            var result = delOb(4, 5);
            var resulta = delOba(4, 5);

            Console.WriteLine("If I feed 4 and 5 to the delegate with Multiply I get: " + result);
            Console.WriteLine("If I feed 4 and 5 to the delegate with Sum I get: " + resulta);
        }

        public string IdentifyExperiment()
        {
            return "DelegateExp";
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Sum(int a, int b, int c)
        {
           return (a + b + c);
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}