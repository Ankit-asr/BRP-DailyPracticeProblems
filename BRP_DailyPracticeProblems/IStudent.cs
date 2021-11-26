using System;
using System.Collections.Generic;
using System.Text;

namespace BRP_DailyPracticeProblems
{
    interface IStudent
    {
        public void Subjects();
    }
    class FifthStandard : IStudent
    {
        public void Subjects()
        {
            Console.WriteLine("Maths");
            Console.WriteLine("English");
            Console.WriteLine("EVS");
        }
        
        static void Main(string[] args)
        {
            FifthStandard obj = new FifthStandard();
            obj.Subjects();
        }
    }
}
