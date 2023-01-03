## Write a program in C# to check for a string if its a palindrome.
- ####  Check for Inputs - madam, racecar, 1122332211, 11/11/11, 11:11.
- ##### Check for edge cases if possible. Eg:
-  isPalindrome(“”) // true
- isPalindrome(1010) // false
- isPalindrome(“taco Cat”) // true
- isPalindrome(“Was it a car or a cat I saw?”) // true
- isPalindrome(“hello”) // false
- isPalindrome(“momma made me eat my m&ms”) //false
## Solution in c#
```
using System;
namespace Palindrome
{

    class Program
    {
        public static void isPalin()
        {
            Console.WriteLine("Enter the string To check Palindrome or Not  : ");
            string name = Console.ReadLine();
            name = name.ToLower();
            name = name.Trim();
            name = name.Replace(" ", "");
            name = name.Replace("$", "");
            name = name.Replace("?", "");
            name = name.Replace("^", "");
            name = name.Replace("{", "");
            name = name.Replace("[", "");
            name = name.Replace("(", "");
            name = name.Replace("|", "");
            name = name.Replace(")", "");
            name = name.Replace("]", "");
            name = name.Replace("}", "");
            name = name.Replace("*", "");
            name = name.Replace("+", "");
            name = name.Replace("\\", "");
            string reverse = "";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverse += name[i];
            }
            if (name == reverse)
            {
                Console.WriteLine($"True, {name} is a palindrome");
            }
            else
            {
                Console.WriteLine("False, {0} is not a palindrome", name);
            }

        }
        static void Main(string[] args)
        {
            isPalin();
        }
    }
}

```
### sample output :
```
Enter the string To check Palindrome or Not  :
Was it a car or a cat I saw?
True, wasitacaroracatisaw is a palindrome

```
---
---