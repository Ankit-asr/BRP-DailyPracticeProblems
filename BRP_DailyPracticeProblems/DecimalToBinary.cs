using System;
using System.Collections.Generic;
using System.Text;

namespace BRP_DailyPracticeProblems
{
    class DecimalToBinary
    {
        public static int number;
        public static int[] arr = new int[20];
        public void Conversion()
        {
            int i;
            Console.Write("Enter the number to convert: ");
            number = Convert.ToInt32(Console.ReadLine());
            int original = number;
            for (i = 0; number > 0; i++)
            {
                arr[i] = number % 2;
                number = number / 2;
            }
            Console.Write("Binary of " + original + " is : ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
        }
    }
}
