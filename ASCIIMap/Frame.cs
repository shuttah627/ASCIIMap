using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIMap
{
    class Frame
    {
        public char[,] s_Frame;
        public ConsoleColor[,] f_Ground;
        public ConsoleColor[,] b_Ground;
        public int height = 0;
        public int width = 0;

        public Frame(int hori, int vert)
        {
            s_Frame = new char[hori, vert];
            f_Ground = new ConsoleColor[hori, vert];
            b_Ground = new ConsoleColor[hori, vert];
            width = hori;
            height = vert;
        }
    }
}
