﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.draw();

            Point p2 = new Point(4, 5, '#');

            p2.draw();

            h_l line = new h_l(5, 10, 8, '+');
            line.draw();




            Console.ReadLine();
        }
    }
}