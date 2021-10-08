using System;
using System.Collections.Generic;
using System.Text;

namespace BRP_DailyPracticeProblems
{
    class HarmonicNumber
    {
        public static int number;
        public static float sum = 1;
        public static void Harmonic()
        {
            Console.WriteLine("Enter a number grater than 0");
            number = Convert.ToInt32(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("Please Enter correct input");
            }
            else
            {
                HarmonicNumber.logic();
            }
        }
        public static void logic()
        {
            int i;
            Console.Write("1");
            for (i = 1; i <= number; i++)
            {
                sum = sum + (float)(1 / i);
                Console.Write(" " + "+" + "1/" + i);
            }
            Console.WriteLine();
            Console.WriteLine("Nth number is : " + sum);
        }
    }
}
