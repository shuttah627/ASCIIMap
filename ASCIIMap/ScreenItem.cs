using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIMap
{
    class ScreenItem : Element
    {
        public Frame s_canvas = new Frame(30, 30);
        public CoOrd p_start = new CoOrd(0,0);

        public ScreenItem()
        {
            p_start.x = 0;
            p_start.y = 0;
        }

        public ScreenItem(int x, int y)
        {
            p_start.x = x;
            p_start.y = y;
        }

        public void RandomFill()
        {
            Random gen = new Random();
            for (int y = 0; y < s_canvas.height; y++)
            {
                for (int x = 0; x < s_canvas.width; x++)
                {
                    int temp = gen.Next(1, 4);
                    switch (temp)
                    {
                        case 1:
                            s_canvas.s_Frame[x, y] = '▀';
                            break;
                        case 2:
                            s_canvas.s_Frame[x, y] = '▄';
                            break;
                        case 3:
                            s_canvas.s_Frame[x, y] = '▌';
                            break;
                        case 4:
                            s_canvas.s_Frame[x, y] = '▐';
                            break;
                    }

                    temp = gen.Next(1, 16);
                    switch (temp)
                    {
                        case 1:
                            s_canvas.f_Ground[x, y] = ConsoleColor.Black;
                            break;
                        case 2:
                            s_canvas.f_Ground[x, y] = ConsoleColor.Blue;
                            break;
                        case 3:
                            s_canvas.f_Ground[x, y] = ConsoleColor.Cyan;
                            break;
                        case 4:
                            s_canvas.f_Ground[x, y] = ConsoleColor.DarkBlue;
                            break;
                        case 5:
                            s_canvas.f_Ground[x, y] = ConsoleColor.DarkCyan;
                            break;
                        case 6:
                            s_canvas.f_Ground[x, y] = ConsoleColor.DarkGray;
                            break;
                        case 7:
                            s_canvas.f_Ground[x, y] = ConsoleColor.DarkGreen;
                            break;
                        case 8:
                            s_canvas.f_Ground[x, y] = ConsoleColor.DarkMagenta;
                            break;
                        case 9:
                            s_canvas.f_Ground[x, y] = ConsoleColor.DarkRed;
                            break;
                        case 10:
                            s_canvas.f_Ground[x, y] = ConsoleColor.DarkYellow;
                            break;
                        case 11:
                            s_canvas.f_Ground[x, y] = ConsoleColor.Gray;
                            break;
                        case 12:
                            s_canvas.f_Ground[x, y] = ConsoleColor.Green;
                            break;
                        case 13:
                            s_canvas.f_Ground[x, y] = ConsoleColor.Magenta;
                            break;
                        case 14:
                            s_canvas.f_Ground[x, y] = ConsoleColor.Red;
                            break;
                        case 15:
                            s_canvas.f_Ground[x, y] = ConsoleColor.White;
                            break;
                        case 16:
                            s_canvas.f_Ground[x, y] = ConsoleColor.Yellow;
                            break;
                    }

                    temp = gen.Next(1, 16);
                    switch (temp)
                    {
                        case 1:
                            s_canvas.b_Ground[x, y] = ConsoleColor.Black;
                            break;
                        case 2:
                            s_canvas.b_Ground[x, y] = ConsoleColor.Blue;
                            break;
                        case 3:
                            s_canvas.b_Ground[x, y] = ConsoleColor.Cyan;
                            break;
                        case 4:
                            s_canvas.b_Ground[x, y] = ConsoleColor.DarkBlue;
                            break;
                        case 5:
                            s_canvas.b_Ground[x, y] = ConsoleColor.DarkCyan;
                            break;
                        case 6:
                            s_canvas.b_Ground[x, y] = ConsoleColor.DarkGray;
                            break;
                        case 7:
                            s_canvas.b_Ground[x, y] = ConsoleColor.DarkGreen;
                            break;
                        case 8:
                            s_canvas.b_Ground[x, y] = ConsoleColor.DarkMagenta;
                            break;
                        case 9:
                            s_canvas.b_Ground[x, y] = ConsoleColor.DarkRed;
                            break;
                        case 10:
                            s_canvas.b_Ground[x, y] = ConsoleColor.DarkYellow;
                            break;
                        case 11:
                            s_canvas.b_Ground[x, y] = ConsoleColor.Gray;
                            break;
                        case 12:
                            s_canvas.b_Ground[x, y] = ConsoleColor.Green;
                            break;
                        case 13:
                            s_canvas.b_Ground[x, y] = ConsoleColor.Magenta;
                            break;
                        case 14:
                            s_canvas.b_Ground[x, y] = ConsoleColor.Red;
                            break;
                        case 15:
                            s_canvas.b_Ground[x, y] = ConsoleColor.White;
                            break;
                        case 16:
                            s_canvas.b_Ground[x, y] = ConsoleColor.Yellow;
                            break;
                    }

                }
            }
        }
    }
}
