﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class HiringDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
      
        public HiringDate(int _day,int _month,int _year)
        {
            Day = _day; Month= _month; Year = _year;
        }
    }
}
