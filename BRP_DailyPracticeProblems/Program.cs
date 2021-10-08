using System;

namespace BRP_DailyPracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to BRP Daily Practice Problems");
            DecimalToBinary obj1 = new DecimalToBinary();
            obj1.Conversion();
            Console.WriteLine();
            ExtendDecimalToBinary obj2 = new ExtendDecimalToBinary();
            obj2.Nibble();
        }
    }
}
