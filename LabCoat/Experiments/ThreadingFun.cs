namespace LabCoat.Experiments
{
    using System;
    using System.Threading;

    internal class ThreadingFun : IExperiment
    {
        public void Experiment()
        {
            Thread t = new Thread(this.WriteY);
            t.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.Write("x");
                Thread.Yield();
            }
            //Thread.Yield();
            //Thread.Sleep(1000);

            t.Join();

            //while (t.IsAlive)
            //{
            //}
        }

        private void WriteY(object obj)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("y");
                Thread.Yield();
            }
        }

        public string IdentifyExperiment()
        {
            return nameof(ThreadingFun);
        }
    }
}