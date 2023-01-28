# More CSharp topics week 3
# Regular Expressions
- A regular expression is a special sequence of characters that describe a pattern of text that should be found, or matched, in a string or document. 
- By matching text, we can identify how often and where certain pieces of text occur, as well as have the opportunity to replace or update these pieces of text if needed.
- Where do you need regukar expressions?
    - Validating user's input in a form
    - verify and parse any text files, code, application.
    - examie test results
    - finding keyword in the web pages, emails.

## Character Sets -[]
- practise or practice, consencous or concesous
    - practi[sc]e - match with practise and practice
    - con[sc]en[sc]ous - will match with consencous or concesous
## Literals - exact match 
- `3.14 will` match exactly with `3.14`
- `chennai has best dosas` will match exactly with `chennai has best dosas` 

## Alternation |
- allowing for the matching between 2 sub expression
    - `I love Chennai|Madras`

## Ranges -
- [A-Z] - match any uppercase letter
- [a-z] - match any lowercase letter
- [0-9] - matches any digit
- [a-zA-Z0-9 ] - matches any lowercase, uppercase letter or any digit.
## Short hand character classes 
- \w - [A-Za-z0-9]
- \d - [0-9]
- \W - not [A-Za-z0=9] or [^A-Za-z0-9]
- \D - not [0-9] or [^0-9]
- \s - single space
- \t - tab
- \r - carriage return
- \n - newline
- ? - optional
- ^ - not - [^A] ,means not A
- ^ - string beginning  - ^I love Chennai
- $ - String end  - I love Chennai$
    - ^I love Chennai$

## Wild card characters .
- . represents matching with a single character(letter, number, symbol, whitespace)
- ... -> matches Joe, Jon, Ron
- Eg `...athan' -> Jonathan, Ronathan,   Nathan etc...

## Kleen Star(*), Kleen Plus (+)
- * - means 0 or more charcates : Eg - h*t -> ht, hot, hoot, hooot
- + - means 1 or more characters : Eg h+t -> hot, hoot, hooot

## Grouping ()
- `I love (Chennai|Madras|Bombay|Mumbai)`

## Quantifiers {}
- PAN Card - 5 letters, 4 digits, 1 letter
    - [A-Z][A-Z][A-Z][A-Z][A-Z][0-9][0-9][0-9][0-9][A-Z] - is ineffective
    - [A-Z]{5}[0-9]{4}[A-Z]
- Aadhar number - \d{4}\s\d{4}\s\d{4}
- DOB - dd/MMM/yyyy
    - `^(([0-9])|([0-2][0-9])|([3][0-1]))\ (Jan|Feb|Mar|Apr|May|Jun|Jul|Aug|Sep|Oct|Nov|Dec)\ \d{4}$`
- Email - `\w+@\w+\.\w{2,4}\.?\w{0,2}`


# File Handling
- [Basics of File I/O](https://learn.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/file-io-operation)
- **System.IO** namespace provides four classes that allow you to manipulate individual files, as well as interact with a machine directory structure.
- The **Directory** and **File** directly extends System.Object and supports the creation, copying, moving and deletion of files using various static methods.
    -  They only contain static methods and are never instantiated.
- The **FileInfo** and **DirectoryInfo** types are derived from the abstract class **FileSystemInfo** type and they are typically, employed for obtaining the full details of a file or directory because their members tend to return strongly typed objects.
    - They implement roughly the same public methods as a Directory and a File but they are stateful and the members of these classes are not static.
# Exceptions
- An exception is an event that occurs during the execution of a program that distrupts the normal flow of instructions
    - Horrible to encounter when presenting your program (When it is expected to work perfectly fine)
    - Great when trying to find bugs in your program
- They are not Errors!
#### Errors
- A serious problem that for the most part cannot be handled by the developer
    -They are fatal to the program at runtime
    - Ex: A stack overflow error and that usually occurs when your computer has run out of memory to store information
- 3 types of errors
    - Usage error - error in your program logic and can be solve by modifying/restructuring your code
    - Program Error - run-time error that cannot be avoided even with a bug-free code (Ex: Your SDK is corrupt and can't compile or translate it to machine code properly)
    - System Failures - run-time error that cannot be handled programmatically in a meaninful way (Ex: your ram hardware is faulty)
###  Exception Handling
- Using a try-catch block and optionally finally block
- If you know the block of code you will run will have a risk of throwing an exception, you should put it in the try block
- The catch block will then "catch" that exception and will run instead its block of code
    - Once an exception occurs in the try block, the flow of control jumps to the first associated exception handler that is present anywhere in the call stack. In C#, the catch keyword is used to define an exception handler.
    - If no exception handler for a given exception is present, the program stops executing with an error message.
    - Don't catch an exception unless you can handle it and leave the application in a known state. 
- Optionally, you can add a finally block that will run regardless if your code throws an exception or not
    - Mostly used to clean up any resources you used in the try blcok
#### Throwing Exception
- You can throw an exception yourself in your code by using the throw keyword
- Useful for enforcing certain rules/logic in your program
#### Exception Heirarchy
- Certain exceptions are more specific than other exceptions
- General rule is the most specific exception should be the very first catch block and the least specific exception is at the very last catch block
    - Why? Well if you made the least specific the first catch block then it will always run if any exception is thrown making your other catch blocks useless
## throw vs rethrow?
- google it out

## [Logging](https://en.wikipedia.org/wiki/Logging_(software))
* The systematically way to record a series of events depending on what exactly you are trying to capture
* Ex: Logging user events - you will record every single page they went through, every single customer they have added, every single orders they have made
* The main purpose is for debugging potential bugs since the main problem with debugging is trying to re-create that bug again just to see what exactly did the user did to even get that bug
* Asking for feedback from a user as to what they did is incredibly unreliable so we have a robot to essentially record everything they do
* OF COURSE, that is only limited to what are they doing in the application and highly unethical (maybe illegal I'm not a lawyer) to record everything they do beyond that
## Serilog
* A library we will utilize to add logging functionality with our application
* There are more libraries out there that can accomplish the same task such as NLog but we will stick with Serilog
### [Steps to start Serilog](https://github.com/serilog/serilog/wiki/Getting-Started)
1. Make sure you add the package from Nuget
```
dotnet add package Serilog
dotnet add package Serilog.Sinks.File
```
2. create a Logger using LoggerConfiguration class provided by Serilog
3. Start logging!


# References:
- [Practise Regular Expressions Basics](https://www.codecademy.com/learn/introduction-to-regular-expressions)
- [File Handling overview](https://learn.microsoft.com/en-us/dotnet/standard/io/)
- [File Handling another](https://www.geeksforgeeks.org/basics-of-file-handling-in-c-sharp/)
