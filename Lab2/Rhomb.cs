﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Rhomb : Figure
    {
        //формула ромба через его диагонали
        public double d1 { get; set; }
        public double d2 { get; set; }

        public override double GetArea()
        {
            return (d1 * d2) / 2;
        }
    }
}
