using System;

namespace Sandbox.Experiments
{
    internal class ConsoleTesting : IExperiment
    {
        public void Experiment()
        {
            var currentWidth = Console.WindowWidth;
            Console.WindowWidth = Console.LargestWindowWidth;
            Console.WriteLine("Hit a key to return to original width");
            Console.ReadKey();
            Console.WindowWidth = currentWidth;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("test... 50%");
            Console.CursorLeft -= 3;
            Console.Write("90%");
            Console.CursorSize = 33;
            Console.WriteLine();
            int cursorLeft = Console.CursorLeft;
            int cursorTop = Console.CursorTop;
            Console.WriteLine("Cursor position: " + cursorLeft + ", " + cursorTop);
            Console.WriteLine("Hit a key to end the test");
            Console.SetCursorPosition(25, 25);
            Console.ReadKey();
        }

        public string IdentifyExperiment()
        {
            return nameof(ConsoleTesting);
        }
    }
}