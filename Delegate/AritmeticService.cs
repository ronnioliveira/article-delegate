using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    public class AritmeticService
    {
        public static int SumTwoIntNumbers(int numberOne, int numberTwo) => numberOne + numberTwo;
        public static int SubtractTwoIntNumbers(int numberOne, int numberTwo) => numberOne - numberTwo;

        public static void FirstMethod() => Console.WriteLine("First Method");
        public static void SecondMethod() => Console.WriteLine("Second Method");
        public static void ThirdMethod() => Console.WriteLine("Third Method");
    }
}
