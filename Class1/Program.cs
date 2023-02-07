
using Class1;

class Program
{
    public static void Main(string[] args)
    {

        Singleton obj1 = Singleton.GetInstances;
        obj1.PrintDetails("Trainer");
        Singleton obj2 = Singleton.GetInstances;
        obj2.PrintDetails("Student");


        //initialize null

        /* int? a = 20;
         int b = 10;
         int c = a ?? b;
         Console.WriteLine(c);*/

        // Console.WriteLine("hello world"); - TC :O(1) SC:O(1)
        /*  int n = 10;
         for (int i = 1; i<=n;i++)
          {
              Console.WriteLine("hello world");
          }
          // O(n)*/

      /*  int n = 8;
        for (int i =1;i<=n;i=i*2)
        {
            Console.WriteLine("hello world");
        }

        //O(log2(n))*/


    }
}