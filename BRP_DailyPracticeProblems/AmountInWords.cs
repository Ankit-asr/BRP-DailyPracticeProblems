//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace BRP_DailyPracticeProblems
//{
//    class AmountInWords
//    {
//        public string ConvertToWords(int number)
//        {
//            string str = " ";

//            while (number != 0)
//            {

//                if (number >= 1 && number < 100)
//                {
//                    str = str + OneToHundred(number);
//                    number = 0;
//                }

//                else if (number >= 100 && number < 1000)
//                {
//                    str = str + OneToHundred(number / 100);
//                    str = str + "Hundred";
//                    number = number % 100;
//                }
//            }
//            return str;
//        }
//        public string OneToHundred(int number)
//        {
//            string str = " ";
//            while (number!=0)
//            {
//                if(number == 1)
//                {
//                    str = str + "One";
//                    number = 0;
//                }
//                if (number == 2)
//                {
//                    str = str + "Two";
//                    number = 0;
//                }
//                if (number == 3)
//                {
//                    str = str + "Three";
//                    number = 0;
//                }
//                if (number == 4)
//                {
//                    str = str + "Four";
//                    number = 0;
//                }
//                if (number == 5)
//                {
//                    str = str + "Five";
//                    number = 0;
//                }
//                if (number == 6)
//                {
//                    str = str + "six";
//                    number = 0;
//                }
//                if (number == 7)
//                {
//                    str = str + "Seven";
//                    number = 0;
//                }
//                if (number == 8)
//                {
//                    str = str + "Eight";
//                    number = 0;
//                }
//                if (number == 9)
//                {
//                    str = str + "Nine";
//                    number = 0;
//                }
//                if (number == 10)
//                {
//                    str = str + "Ten";
//                    number = 0;
//                }
//                if (number == 11)
//                {
//                    str = str + "Eleven";
//                    number = 0;
//                }
//                if (number == 12)
//                {
//                    str = str + "Twelve";
//                    number = 0;
//                }
//                if (number == 13)
//                {
//                    str = str + "Thirty";
//                    number = 0;
//                }
//                if (number == 14)
//                {
//                    str = str + "Fourteen";
//                    number = 0;
//                }
//                if (number == 15)
//                {
//                    str = str + "Fifteen";
//                    number = 0;
//                }
//                if (number == 16)
//                {
//                    str = str + "Sixteen";
//                    number = 0;
//                }
//                if (number == 17)
//                {
//                    str = str + "Seventeen";
//                    number = 0;
//                }
//                if (number == 18)
//                {
//                    str = str + "Eighteen";
//                    number = 0;
//                }
//                if (number == 19)
//                {
//                    str = str + "Ninteen";
//                    number = 0;
//                }
             
//                if (number >= 20 && number <30)
//                {
//                    str = str + "twenty";
//                    number = number - 20;
//                }
//                if (number >=30 && number < 40)
//                {
//                    str = str + "Thety";
//                    number = number - 30;
//                }
//                if (number >= 40 && number < 50)
//                {
//                    str = str + "Fourty";
//                    number = number - 40;
//                }

//                if (number>=50 && number<60)
//                {
//                    str = str + "Fifty";
//                    number = number - 50;
//                }
//                if (number>=60 && number<70)
//                {
//                    str = str + "Sixty";
//                    number = number - 60;
//                }
//                if (number>=70 && number<80)
//                {
//                    str = str + "Seventy";
//                    number = number - 70;
//                }
//                if (number>=80 && number<90)
//                {
//                    str = str + "eighty";
//                    number = number - 80;
//                }
//                if (number>=90 && number<100)
//                {
//                    str = str + "Ninty";
//                    number = number - 90;
//                }
//            }
//            return str;

//        }
//        public static void Main()
//        {
//            string str;
//            int number;
//            Console.WriteLine("Enter the Amount or Number to Convert into Word");
//            number = Convert.ToInt32(Console.ReadLine());
//            AmountInWords obj = new AmountInWords();
//            str =obj.ConvertToWords(number);
//            Console.WriteLine(str);
//        }
//    }
//}
