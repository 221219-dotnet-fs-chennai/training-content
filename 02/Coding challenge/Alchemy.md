1. Given an integer n, return a string array answer (1-indexed) where:
    - `answer[i] == "FizzBuzz" if i is divisible by 3 and 5.`
    - `answer[i] == "Fizz" if i is divisible by 3.`
    - `answer[i] == "Buzz" if i is divisible by 5.`
    - `answer[i] == i (as a string) if none of the above conditions are true.`

    - Example: 
        - `Input: n = 5`
            - `Output: ["1","2","Fizz","4","Buzz"]`

        - `Input: n = 15`
            - `Output: ["1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz"`


  <br><br> 
  ## Solution

    internal void FizzBuzzSol(int num){
            System.Console.Write("[");
            for(int i=1;i<=num;i++){
                
                if(i%3==0 && i%5==0){
                    System.Console.Write("\"FizzBuzz\"");
                }
                else if(i%3==0){
                    System.Console.Write("\"Fizz\"");
                }
                else if(i%5==0){
                    System.Console.Write("\"Buzz\"");
                }
                else{
                    System.Console.Write($"\"{i}\"");
                }
                if(i!=num){
                    System.Console.Write(",");
                }
            }
            System.Console.Write("]");
        }