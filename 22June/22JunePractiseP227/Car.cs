using System;
using System.Collections.Generic;
using System.Text;

namespace _22JunePractiseP227
{
    public class Car
    {
        public Car()
        {
            _no++;
            No = _no;
        }

        public string Brand;
        public int RaceDurationMinutes;
        public static int _no = 100;
        public int No;
    }
}
