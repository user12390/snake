using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    class h_l
    {
        List<Point> pList;

        public h_l(int xLeft, int xRight, int y, char sym)
        { 
        pList = new List<Point>();

        for (int x = xLeft; x <= xRight; x++)
        {
            Point p = new Point(x, y, sym);
            pList.Add(p);
        }

        }
        public void draw()
        {
            foreach (Point p in pList)
            {
                p.draw();
            }
        }


    }
}
