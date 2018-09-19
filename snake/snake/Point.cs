﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {
        }

        public Point(int _x, int _y, char _sym)
    {
    x = _x;
    y = _y;
    sym = _sym;
    }

        public void draw()
        {
            Console.SetCursorPosition( x, y );
            Console.Write( sym );
        }
    }
}
