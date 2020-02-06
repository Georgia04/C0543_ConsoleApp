using C0453_ClassConsoleApp1.Unit4.Unit4;
using System;

namespace C0453_ClassConsoleApp1.Unit4
{
    class Program
    {
        static void Main(string[] args)
        {      
            double miles = 12;
            double feet = 7260;

            Console.WriteLine("Georgia's Distance Converter");
            DistanceConverter converter = new DistanceConverter();
            feet = converter.ToFeet(miles);
            Console.WriteLine(" The no of feet = " + feet);

            miles = converter.ToMiles(7260*3);
            Console.WriteLine("The no of miles = " + miles);
            
        } 
    }
}
