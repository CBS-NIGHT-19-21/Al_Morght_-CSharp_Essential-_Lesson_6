using System;

namespace Task1
{
    static class Calculator
    {
        public static void Sum(int value1, int value2) => Console.WriteLine("Сумма: " + (value1 + value2));
        public static void Sub(int value1, int value2) => Console.WriteLine("Разница: " + (value1 - value2));
        public static void Mult(int value1, int value2) => Console.WriteLine("Произведение: " + (value1 * value2));
        public static void Div(int value1, int value2) => Console.WriteLine("Частное: " + (value1 / value2));
        public static void RemOfDiv(int value1, int value2) => Console.WriteLine("Остаток от деления: " + (value1 % value2));
    }
}
