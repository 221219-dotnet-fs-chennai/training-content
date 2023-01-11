using System;
namespace HelloCSharp
{
    public interface ICalculator
    {
        double Add(double num1, double num2);
        double Substract(double num1, double num2);
        double Divide(int num1,int num2);
        double Multiply(double num1,double num2);
        int Mod(int dividend, int divisor);
    }
    interface ICalculatorAdvance
    {
        double SquareRoot(int i);
        double Square(double i);
        double CubeRoot(int i);
        double Cube(double i);
        int Mod(int dividend, int divisor);
    }
    class Calculator : ICalculator, ICalculatorAdvance
    {
        public double Add(double num1, double num2)
        {
            return num1+num2;
        }

        public double Cube(double i)
        {
            throw new System.NotImplementedException();
        }

        public double CubeRoot(int i)
        {
            throw new System.NotImplementedException();
        }

        public double Divide(int num1, int num2)
        {
            float result =0;
            try{
                result = num1/num2;
            }
            catch{
                throw;
            }
            return result;
        }

        public double Multiply(double num1, double num2)
        {
            return num1*num2;
        }

        public double Square(double i)
        {
            throw new System.NotImplementedException();
        }

        public double SquareRoot(int i)
        {
            throw new System.NotImplementedException();
        }

        public double Substract(double num1, double num2)
        {
            return num1-num2;
        }

        int ICalculator.Mod(int dividend, int divisor)
        {
            throw new System.NotImplementedException();
        }

        int ICalculatorAdvance.Mod(int dividend, int divisor)
        {
            throw new System.NotImplementedException();
        }
    }

}