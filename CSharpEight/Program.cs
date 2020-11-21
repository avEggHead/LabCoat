﻿using System;
using System.Text;

namespace CSharpEight
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                Factory doerFactory = new Factory();

                IExecute activity = doerFactory.ChooseActivity();

                activity.Execute();

                Console.Write("Keep going? ");
                var input = Console.ReadKey();
                if (input.KeyChar != 'y')
                {
                    keepGoing = false;
                }
            }
        }
    }
}