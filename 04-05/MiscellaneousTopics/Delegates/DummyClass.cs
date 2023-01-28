namespace Delegates
{
    //declaration of a delegate
    delegate void MyDelegate(float num1, float num2);
    class DummyClass
    {
        public static void Display()
        {
            Console.WriteLine("Welcome to learn about delegates");
        }
        /*
        public static void Add(float num1, float num2)
        {
            Console.WriteLine(num2 + num1);
        }
        public static void Substract(float num1, float num2)
        {
            Console.WriteLine(num2 - num1);
        }
        public static void Multiply(float num1, float num2)
        {
            Console.WriteLine(num2 * num1);
        }

        public static void Divide(float num1, float num2)
        {
            Console.WriteLine(num2 / num1);
        }
        */
        public static void CallBack(float x, float y, MyDelegate callback)
        {
            callback(y, x);
        }
    }
}
