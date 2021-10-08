using System;
using System.Collections.Generic;
using System.Text;

namespace BRP_DailyPracticeProblems
{
    class PallindromeString
    {
        public bool IsPalindrome(string text)
        {
            if (text.Length <= 1)
                return true;
            else
            {
                if (text[0] != text[text.Length - 1])
                    return false;
                else
                    return IsPalindrome(text.Substring(1, text.Length - 2));
            }
        }
        public void CheckPallindrome()
        {
            string str1;
            bool tf;
            Console.Write(" Input a string : ");
            str1 = Console.ReadLine();
            tf = IsPalindrome(str1);
            if (tf == true)
            {
                Console.WriteLine("The string is Palindrome");
            }
            else
            {
                Console.WriteLine("The string is not a Palindrome");
            }
        }
    }
}