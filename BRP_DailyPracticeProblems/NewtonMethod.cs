using System;
using System.Collections.Generic;
using System.Text;

namespace BRP_DailyPracticeProblems
{
    class NewtonMethod
    {
        public static void SquareRoot()
        {
            Console.WriteLine("Enter a Number ");
            double number = Convert.ToDouble(Console.ReadLine());
            double c = number;
            double epsilon = 1e-15;
            double t = c;
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }
            Console.WriteLine("Square root of the number " + c + " is: " + t);
        }
    }
}
