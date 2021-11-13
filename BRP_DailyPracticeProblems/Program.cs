using System;

namespace BRP_DailyPracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionHandling obj = new ExceptionHandling();
            //obj.AddTwoNumbers();

            //char i, j;
            //for (i = 'A'; i <= 'E'; i++)
            //{
            //    for (j = 'A'; j <= i; j++)
            //    {
            //        Console.Write(i);

            //    }
            //    Console.WriteLine(" ");
            //}
            //Console.WriteLine("");
            //for (int k=5; k >= 1; k--)
            //{
            //    for (int l=1; l <= k; l++)
            //    {
            //        Console.Write(l);
            //    }
            //    Console.WriteLine("");
            //}


            
            for (int i=1; i<=5; i++)
            {
                for (int j=1; j<=5; j++)
                {
                    if ( i==1 || j==1 || i==5 )
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("");
                    }
                }
                Console.WriteLine(" ");
            }
        }
    }
}
