## Problem Solving Practice

You can tackle these challenges alone or with a teammate:
Some things to keep in mind:
- Do not prematurely optimize your code. Focus first on getting something that works first. You can always readdress.
- If you're not sure where to start, start with pseudocode. Translating concepts directly to code can be challenging to do all at once. Take smaller steps by starting first with pseudocode.
- Talk through your code. This may feel a little counter intuitive, especially if you're working on a challenge alone. But communicating your though process throughout the development process will be important for coding interviews so it's good to start getting into the habit now.
- While there are no restrictions on external resources, you'll get the most out of this practice if external resources are limited.
---
### Part 1

1. Write a method to reverse a string.
   - ex: input "hello world" returns "dlrow olleh"

2. Write a method to determine if two words are an anagram. The method should return true, if and only if, the same characters are present in the first and second word the same amount of times.
   - ex: input "pool" and "polo" would return true
   - ex: input "pool" and "poll" would return false

3. Create your own implementation of a stack. Define a class that implements a length, push, and pop method. Your stack should follow LIFO processing order.

4. Write a method to return the nth fibonacci number.
   - ex: input 0 returns 0
   - ex: input 2 returns 1
   - ex: input 6 returns 8

5. Given two numeric arrays, return an array which represents the intersection of the two arrays.
   - ex: input [3,4] and [6,7] returns []
   - ex: input [8,9,3] and [0,3,8] returns [3,8]

6. Create your own implementation of a stack.
   - if you used an array backed structure for question 3, try implementing it now with a node based structure
   - if you used a node based structure, try using an array
   - compare/contrast your two implementations
---

### Part 2
1. Implement a utility method to print an array of int's
part 2: Implement a utility method which takes an array of a generic type and converts it to a string (without taking a parameter of Object[])
2. Implement a method which capitalizes the first letter of each word in a string
3. Implement a method which returns the value of n! when n is passed in as a parameter
4. Implement a method which reverses a String

5. Given an array of ints, return an array of ints which contains the maximum number in the array, as many times as it occurs
[2,3,5,1,5]->[5,5]

6. Given two Strings, return a boolean determining whether the second word is an anagram of the first
Implement a method which removes duplicates from an integer array using core java only (no collections or utility classes)
7. Implement a method which takes in a 3x3 2D array representing a tic tac toe board; have a boolean return based on if there was a winner
8. Given a string, find the longest sequence of contiguous characters and return the letter
'aaaabbbcccdcccee' -> 'a'

9. Separate an array into even numbers and odd numbers and give their count
[2,3,5,1,5] prints "1 even, 4 odd"

10. Given two arrays: [1, 2, 3] [‘a’, ‘b’, ‘c’] Combine them into one array (**note that these have different types…)
11. Write a program to count frequency of characters in an array
(['a','e','a','i'], 'a') -> 2