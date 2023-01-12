using System;
using System.Text;
using System.Text.RegularExpressions;

namespace HelloCSharp
{
    public class CodingChallenges
    {
        public static bool IsPalindrome(string s){
            string pattern=  @"[^a-zA-Z0-9]";// to make sure that string is alphanumeric
            var curatedString=Regex.Replace(s,pattern,"").ToLower();
            // reverse the string
            Console.WriteLine(curatedString);
            var charArray = curatedString.ToCharArray();
            Array.Reverse(charArray);
            var reverseString = new string(charArray);
            Console.WriteLine(reverseString);
            // match the strings
            if(curatedString==reverseString)
                return true;
            else 
                 return false;

        }
    }
}