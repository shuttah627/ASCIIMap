using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIMap
{
    class CoOrd
    {
        public int x;
        public int y;

        public CoOrd()
        {
            x = 0;
            y = 0;
        }

        public CoOrd(int hori, int vert)
        {
            int x = hori;
            int y = vert;
        }
    }
}
