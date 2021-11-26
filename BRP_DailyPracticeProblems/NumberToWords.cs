//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace BRP_DailyPracticeProblems
//{
//    class NumberToWords
//    {
//        public static void Main()
//        {
//            int number, num = 0;

//            Console.WriteLine("Enter any number to print in words: ");
//            number = Convert.ToInt32(Console.ReadLine());
//            while (number != 0)
//            {
//                num = (num * 10) + (number % 10);
//                number /= 10;
//            }
//            while (num != 0)
//            {
//                switch (num % 10)
//                {
//                    case 0:
//                        Console.WriteLine("Zero ");
//                        break;
//                    case 1:
//                        Console.WriteLine("One ");
//                        break;
//                    case 2:
//                        Console.WriteLine("Two ");
//                        break;
//                    case 3:
//                        Console.WriteLine("Three ");
//                        break;
//                    case 4:
//                        Console.WriteLine("Four ");
//                        break;
//                    case 5:
//                        Console.WriteLine("Five ");
//                        break;
//                    case 6:
//                        Console.WriteLine("Six ");
//                        break;
//                    case 7:
//                        Console.WriteLine("Seven ");
//                        break;
//                    case 8:
//                        Console.WriteLine("Eight ");
//                        break;
//                    case 9:
//                        Console.WriteLine("Nine ");
//                        break;
//                }

//                num = num / 10;
//            }

//        }
//    }
//}
