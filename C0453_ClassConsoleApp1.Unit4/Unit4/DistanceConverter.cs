using System;
using System.Collections.Generic;
using System.Text;

namespace C0453_ClassConsoleApp1.Unit4.Unit4
{
    public class DistanceConverter
    {
        public double ToFeet(double miles)
        {
            return miles * 1760.00 * 3;
        }

        public double ToMiles (double feet )
        {
            return feet  / 1760.00 * 3;
        }
    }
}
