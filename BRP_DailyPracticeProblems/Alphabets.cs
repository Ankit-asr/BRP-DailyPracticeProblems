//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace BRP_DailyPracticeProblems
//{
//    class Alphabets
//    {
//        static void Main(string[] args)
//        {
//            int row, column;
//            Console.Write("---------------------------------------------");
//            Console.Write("\n\n");

//            for (row = 0; row <= 7; row++)
//            {
//                for (column = 0; column <= 7; column++)
//                {
//                    if (((column == 1 || column == 5) && row != 0) ||
//                         ((row == 0 || row == 3) && (column > 1 && column < 5)))
//                        Console.Write("*");
//                    else
//                        Console.Write(" ");
//                }
//                Console.Write("\n");
//            }
//            Console.Write("\n");

//            Console.Write("---------------------------------------------");
//            Console.Write("\n\n");

//            for (row = 0; row <= 6; row++)
//            {
//                for (column = 0; column <= 6; column++)
//                {
//                    if (column == 1 || ((row == 0 || row == 3 || row == 6) && (column < 5 && column > 1)) || (column == 5 && (row != 0 && row != 3 && row != 6)))
//                        Console.Write("*");
//                    else
//                        Console.Write(" ");
//                }
//                Console.Write("\n");
//            }
//            Console.Write("\n");

//            Console.Write("---------------------------------------------");
//            Console.Write("\n\n");

//            for (row = 0; row <= 6; row++)
//            {
//                for (column = 0; column <= 6; column++)
//                {
//                    if ((column == 1 && (row != 0 && row != 6)) || ((row == 0 || row == 6) && (column > 1 && column < 5)) || (column == 5 && (row == 1 || row == 5)))
//                        Console.Write("*");
//                    else
//                        Console.Write(" ");
//                }
//                Console.Write("\n");
//            }
//            Console.Write("\n");



//            Console.Write("---------------------------------------------");
//            Console.Write("\n\n");

//            for (row = 0; row <= 6; row++)
//            {
//                for (column = 0; column <= 6; column++)
//                {
//                    if (column == 1 || ((row == 0 || row == 6) && (column > 1 && column < 5)) || (column == 5 && row != 0 && row != 6))
//                        Console.Write("*");
//                    else
//                        Console.Write(" ");
//                }
//                Console.Write("\n");
//            }
//            Console.Write("\n");


//            Console.Write("---------------------------------------------");
//            Console.Write("\n\n");

//            for (row = 0; row <= 6; row++)
//            {
//                for (column = 0; column <= 6; column++)
//                {
//                    if (column == 1 || ((row == 0 || row == 6) && (column > 1 && column < 6)) || (row == 3 && column > 1 && column < 5))
//                        Console.Write("*");
//                    else
//                        Console.Write(" ");
//                }
//                Console.Write("\n");
//            }
//            Console.Write("\n");




//            Console.Write("---------------------------------------------");
//            Console.Write("\n\n");

//            for (row = 0; row <= 6; row++)
//            {
//                for (column = 0; column <= 6; column++)
//                {
//                    if (column == 1 || (row == 0 && column > 1 && column < 6) || (row == 3 && column > 1 && column < 5))
//                        Console.Write("*");
//                    else
//                        Console.Write(" ");
//                }
//                Console.Write("\n");
//            }
//            Console.Write("\n");





//            Console.Write("---------------------------------------------");
//            Console.Write("\n\n");

//            for (row = 0; row <= 6; row++)
//            {
//                for (column = 0; column <= 6; column++)
//                {
//                    if (column == 1 || (row == 0 && column > 1 && column < 6) || (row == 3 && column > 1 && column < 5))
//                        Console.Write("*");
//                    else
//                        Console.Write(" ");
//                }
//                Console.Write("\n");
//            }
//            Console.Write("\n");


//            Console.Write("---------------------------------------------");
//            Console.Write("\n\n");

//            for (row = 0; row <= 6; row++)
//            {
//                for (column = 0; column <= 6; column++)
//                {
//                    if ((column == 1 && row != 0 && row != 6) || ((row == 0 || row == 6) && column > 1 && column < 5) || (row == 3 && column > 2 && column < 6) || (column == 5 && row != 0 && row != 2 && row != 6))
//                        Console.Write("*");
//                    else
//                        Console.Write(" ");
//                }
//                Console.Write("\n");
//            }
//            Console.Write("\n");


//            Console.Write("---------------------------------------------");
//            Console.Write("\n\n");

//            for (row = 0; row <= 6; row++)
//            {
//                for (column = 0; column <= 6; column++)
//                {
//                    if ((column == 1 || column == 5) || (row == 3 && column > 1 && column < 6))
//                        Console.Write("*");
//                    else
//                        Console.Write(" ");
//                }
//                Console.Write("\n");
//            }
//            Console.Write("\n");



//            Console.Write("---------------------------------------------");
//            Console.Write("\n\n");

//            for (row = 0; row <= 6; row++)
//            {
//                for (column = 0; column <= 6; column++)
//                {
//                    if (column == 3 || (row == 0 && column > 0 && column < 6) || (row == 6 && column > 0 && column < 6))
//                        Console.Write("*");
//                    else
//                        Console.Write(" ");
//                }
//                Console.Write("\n");
//            }
//            Console.Write("\n");


//            Console.Write("---------------------------------------------");
//            Console.Write("\n\n");

//            for (row = 0; row <= 6; row++)
//            {
//                for (column = 0; column <= 6; column++)
//                {
//                    if ((column == 4 && row != 6) || (row == 0 && column > 2 && column < 6) || (row == 6 && column == 3) || (row == 5 && column == 2))
//                        Console.Write("*");
//                    else
//                        Console.Write(" ");
//                }
//                Console.Write("\n");
//            }
//            Console.Write("\n");


//            Console.Write("---------------------------------------------");
//            Console.Write("\n\n");

//            for (row = 0; row <= 6; row++)
//            {
//                for (column = 0; column <= 6; column++)
//                {
//                    if ((column == 4 && row != 6) || (row == 0 && column > 2 && column < 6) || (row == 6 && column == 3) || (row == 5 && column == 2))
//                        Console.Write("*");
//                    else
//                        Console.Write(" ");
//                }
//                Console.Write("\n");
//            }
//            Console.Write("\n");


//            Console.Write("---------------------------------------------");
//            Console.Write("\n\n");

//            for (row = 0; row <= 6; row++)
//            {
//                for (column = 0; column <= 6; column++)
//                {
//                    if ((column == 4 && row != 6) || (row == 0 && column > 2 && column < 6) || (row == 6 && column == 3) || (row == 5 && column == 2))
//                        Console.Write("*");
//                    else
//                        Console.Write(" ");
//                }
//                Console.Write("\n");
//            }
//            Console.Write("\n");


//            Console.Write("---------------------------------------------");

//            Console.Write("---------------------------------------------");
//            Console.Write("\n\n");

//            for (row = 0; row <= 6; row++)
//            {
//                for (column = 0; column <= 6; column++)
//                {
//                    if (column == 1 || (row == 6 && column != 0 && column < 6))
//                        Console.Write("*");
//                    else
//                        Console.Write(" ");
//                }
//                Console.Write("\n");
//            }
//            Console.Write("\n");

//            Console.Write("---------------------------------------------");
//            Console.Write("\n\n");

//            for (row = 0; row <= 6; row++)
//            {
//                for (column = 0; column <= 6; column++)
//                {
//                    if (column == 1 || column == 5 || (row == 2 && (column == 2 || column == 4)) || (row == 3 && column == 3))
//                        Console.Write("*");
//                    else
//                        Console.Write(" ");
//                }
//                Console.Write("\n");
//            }
//            Console.Write("\n");


//            Console.Write("---------------------------------------------");
//            Console.Write("\n\n");

//            for (row = 0; row <= 6; row++)
//            {
//                for (column = 0; column <= 6; column++)
//                {
//                    if (column == 1 || column == 5 || (row == column && column != 0 && column != 6))
//                        Console.Write("*");
//                    else
//                        Console.Write(" ");
//                }
//                Console.Write("\n");
//            }
//            Console.Write("\n");



//            Console.Write("---------------------------------------------");
//            Console.Write("\n\n");

//            for (row = 0; row <= 6; row++)
//            {
//                for (column = 0; column <= 6; column++)
//                {
//                    if (((column == 1 || column == 5) && row != 0 && row != 6) || ((row == 0 || row == 6) && column > 1 && column < 5))
//                        Console.Write("*");
//                    else
//                        Console.Write(" ");
//                }
//                Console.Write("\n");
//            }
//            Console.Write("\n");


//            Console.Write("---------------------------------------------");
//            Console.Write("\n\n");

//            for (row = 0; row <= 6; row++)
//            {
//                for (column = 0; column <= 6; column++)
//                {
//                    if (column == 1 || ((row == 0 || row == 3) && column > 0 && column < 5) || ((column == 5 || column == 1) && (row == 1 || row == 2)))
//                        Console.Write("*");
//                    else
//                        Console.Write(" ");
//                }
//                Console.Write("\n");
//            }
//            Console.Write("\n");


//            Console.Write("---------------------------------------------");
//            Console.Write("\n\n");

//            for (row = 0; row <= 6; row++)
//            {
//                for (column = 0; column <= 6; column++)
//                {
//                    if ((column == 1 && row != 0 && row != 6) || (row == 0 && column > 1 && column < 5) || (column == 5 && row != 0 && row != 5) || (row == 6 && column > 1 && column < 4) || (column == row - 1 && row > 3))
//                        Console.Write("*");
//                    else
//                        Console.Write(" ");
//                }
//                Console.Write("\n");
//            }
//            Console.Write("\n");


//            Console.Write("---------------------------------------------");
//            Console.Write("\n\n");

//            for (row = 0; row <= 6; row++)
//            {
//                for (column = 0; column <= 6; column++)
//                {
//                    if ((column == 1 && row != 0 && row != 6) || (row == 0 && column > 1 && column < 5) || (column == 5 && row != 0 && row != 5) || (row == 6 && column > 1 && column < 4) || (column == row - 1 && row > 3))
//                        Console.Write("*");
//                    else
//                        Console.Write(" ");
//                }
//                Console.Write("\n");
//            }
//            Console.Write("\n");


//            Console.Write("---------------------------------------------");
//            Console.Write("\n\n");

//            for (row = 0; row <= 6; row++)
//            {
//                for (column = 0; column <= 6; column++)
//                {
//                    if (column == 1 || ((row == 0 || row == 3) && column > 1 && column < 5) || (column == 5 && row != 0 && row < 3) || (column == row - 1 && row > 2))
//                        Console.Write("*");
//                    else
//                        Console.Write(" ");
//                }
//                Console.Write("\n");
//            }
//            Console.Write("\n");


//            Console.Write("---------------------------------------------");
//            Console.Write("\n\n");

//            for (row = 0; row <= 6; row++)
//            {
//                for (column = 0; column <= 6; column++)
//                {
//                    if (((row == 0 || row == 3 || row == 6) && column > 1 && column < 5) || (column == 1 && (row == 1 || row == 2 || row == 6)) || (column == 5 && (row == 0 || row == 4 || row == 5)))
//                        Console.Write("*");
//                    else
//                        Console.Write(" ");
//                }
//                Console.Write("\n");
//            }
//            Console.Write("\n");


//            Console.Write("---------------------------------------------");
//            Console.Write("\n\n");

//            for (row = 0; row <= 6; row++)
//            {
//                for (column = 0; column <= 6; column++)
//                {
//                    if (column == 3 || (row == 0 && column > 0 && column < 6))
//                        Console.Write("*");
//                    else
//                        Console.Write(" ");
//                }
//                Console.Write("\n");
//            }
//            Console.Write("\n");



//            Console.Write("---------------------------------------------");
//            Console.Write("\n\n");

//            for (row = 0; row <= 6; row++)
//            {
//                for (column = 0; column <= 6; column++)
//                {
//                    if (((column == 1 || column == 5) && row < 5) || (row == 6 && column == 3) || (row == 5 && (column == 2 || column == 4)))
//                        Console.Write("*");
//                    else
//                        Console.Write(" ");
//                }
//                Console.Write("\n");
//            }
//            Console.Write("\n");



//            Console.Write("---------------------------------------------");
//            Console.Write("\n\n");

//            for (row = 0; row <= 6; row++)
//            {
//                for (column = 0; column <= 6; column++)
//                {
//                    if (((column == 1 || column == 5) && row < 6) || ((row == 5 || row == 4) && column == 3) || (row == 6 && (column == 2 || column == 4)))
//                        Console.Write("*");
//                    else
//                        Console.Write(" ");
//                }
//                Console.Write("\n");
//            }
//            Console.Write("\n");


//            Console.Write("---------------------------------------------");
//            Console.Write("\n\n");

//            for (row = 0; row <= 6; row++)
//            {
//                for (column = 0; column <= 6; column++)
//                {
//                    if (((column == 1 || column == 5) && (row > 4 || row < 2)) || row == column && column > 0 && column < 6 || (column == 2 && row == 4) || (column == 4 && row == 2))
//                        Console.Write("*");
//                    else
//                        Console.Write(" ");
//                }
//                Console.Write("\n");
//            }
//            Console.Write("\n");


//            Console.Write("---------------------------------------------");
//            Console.Write("\n\n");

//            for (row = 0; row <= 6; row++)
//            {
//                for (column = 0; column <= 6; column++)
//                {
//                    if (((column == 1 || column == 5) && row < 2) || row == column && column > 0 && column < 4 || (column == 4 && row == 2) || ((column == 3) && row > 3))
//                        Console.Write("*");
//                    else
//                        Console.Write(" ");
//                }
//                Console.Write("\n");
//            }
//            Console.Write("\n");


//        }
//    }
//}