// single line comment

/*multi
line
comment*/
/*Console.WriteLine("Please enter your name");
string name = Console.ReadLine();
// Console is a predefined class, WriteLine -> is a method of Console class which prints the string written inside
Console.WriteLine($"Hello {name}!");*/

//// - previous version of .Net 6 the program structure looks like below
using System;
namespace HelloCSharp{
    //Types - class, struct, enums, interface, delegates
    class Program{
        //Type members - Eg: Method, properties, fields/variables, constructors
        public static void Main(string[] args)
        {
            //Console.WriteLine(args[0]);//Printing first command line arguement
            //User.GreetUser();
            /*Console.Write("Please enter a string to check for palindrome ");
            var input=Console.ReadLine();
            Console.Write(CodingChallenges.IsPalindrome(input));*/

            ICalculator ic=new Calculator();
            try{
                Console.WriteLine(ic.Divide(6,0));
            }
            catch(DivideByZeroException ex){
                //throw;//re-throw
                Console.WriteLine("Exception in Program class "+ex.Message);
            }
            
        }
    }
}