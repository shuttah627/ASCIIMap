using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIMap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WindowHeight = 50;
            Console.WindowWidth = 100;
            ///Console.BufferHeight = 50;
            ///Console.BufferWidth = 100;
            Canvas c = new Canvas(Console.WindowWidth, Console.WindowHeight);
            c.AddElement(new ScreenItem(1, 1));
            c.Update();
            c.Draw();
        }
    }
}
