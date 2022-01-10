using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 58, number2 = 12;

            Calculator.Sum(number1, number2);
            Calculator.Sub(number1, number2);
            Calculator.Mult(number1, number2);
            Calculator.Div(number1, number2);
            Calculator.RemOfDiv(number1, number2);

            Console.ReadKey();
        }
    }
}
