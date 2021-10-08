using System;
using System.Collections.Generic;
using System.Text;

namespace BRP_DailyPracticeProblems
{
    class ExtendDecimalToBinary
    {
        public int SwapNibbles(int x)
        {
            return ((x & 0x0F) << 4 |
                    (x & 0xF0) >> 4);
        }
        public void Nibble()
        {
            Console.WriteLine("Enter a Decimal Number for Nibble");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Swapped Nibble is :" + SwapNibbles(x));
        }
    }
}


