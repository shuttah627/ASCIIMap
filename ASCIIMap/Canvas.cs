using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIMap
{
    class Canvas
    {
        Frame l_Frame;
        Frame c_Frame;
        Frame n_Frame;

        List<ScreenItem> e_List = new List<ScreenItem>();


        public Canvas(int f_x, int f_y)
        {
            l_Frame = new Frame(f_x, f_y);
            c_Frame = new Frame(f_x, f_y);
            n_Frame = new Frame(f_x, f_y);
        }

        public void AddElement(ScreenItem x)
        {
            e_List.Add(x);
        }

        public void Update()
        {
            foreach (ScreenItem obj in e_List)
            {
                obj.RandomFill();
                for (int iy = 0; iy < obj.s_canvas.height; iy++)
                {
                    for (int ix = 0; ix < obj.s_canvas.width; ix++)
                    {
                        n_Frame.s_Frame[((obj.p_start.x) + ix), ((obj.p_start.y) + iy)] = obj.s_canvas.s_Frame[ix, iy];
                        n_Frame.b_Ground[((obj.p_start.x) + ix), ((obj.p_start.y) + iy)] = obj.s_canvas.b_Ground[ix, iy];
                        n_Frame.f_Ground[((obj.p_start.x) + ix), ((obj.p_start.y) + iy)] = obj.s_canvas.f_Ground[ix, iy];
                    }
                }
            }
        }

        public void Draw()
        {
            l_Frame = c_Frame;
            c_Frame = n_Frame;

            for (int iy = 0; iy < c_Frame.height; iy++)
            {
                for (int ix = 0; ix < c_Frame.width; ix++)
                {
                    Console.CursorLeft = ix;
                    Console.CursorTop = iy;
                    if (l_Frame.s_Frame[ix,iy] != c_Frame.s_Frame[ix,iy])
                    {
                        Console.BackgroundColor = c_Frame.b_Ground[ix, iy];
                        Console.ForegroundColor = c_Frame.f_Ground[ix, iy];
                        Console.Write(c_Frame.s_Frame[ix, iy]);
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
