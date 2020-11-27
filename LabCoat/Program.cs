using LabCoat.Experiments;
using System;

namespace LabCoat
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // All you have to do is put new experiment classes in the Laboratory.
            Laboratory lab = new Laboratory();
            Scientist scientist = new Scientist(lab);
            scientist.GoIntoLab();
        }
    }
}