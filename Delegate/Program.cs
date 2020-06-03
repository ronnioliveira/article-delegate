using System;

namespace Delegate
{
    //Criação de um delegate que retorna um inteiro e recebe dois inteiros como parâmetro.
    public delegate int AritmeticOperations(int numberOne, int numberTwo);

    public delegate void MulticasDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            WithMulticast();
        }

        public static void WithMulticast()
        {
            MulticasDelegate multicasDelegate = AritmeticService.FirstMethod;
            multicasDelegate += AritmeticService.ThirdMethod;
            multicasDelegate += AritmeticService.SecondMethod;

            multicasDelegate.Invoke();
        }

        public static void WithoutMulticast()
        {
            var numberOne = 7;
            var numberTwo = 3;

            var sum = AritmeticService.SumTwoIntNumbers(numberOne, numberTwo);
            var subtraction = AritmeticService.SubtractTwoIntNumbers(numberOne, numberTwo);

            Console.WriteLine($"A soma dos números é: {sum}");
            Console.WriteLine($"A subtração dos números é: {subtraction}");

            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine();

            //O delegate sumOperation é uma referência para a função SumTwoIntNumber da classe AritmeticService
            AritmeticOperations sumOperation = AritmeticService.SumTwoIntNumbers;

            //O delegate subtractOperation é uma referência para a função SubtractTwoIntNumbers da classe AritmeticService
            AritmeticOperations subtractOperation = AritmeticService.SubtractTwoIntNumbers;

            //como eu tenho a referência da função, basta invocá-la passando seus parâmetros, se houver.
            var resultSumOperation = sumOperation(numberOne, numberTwo);
            var resultSubtractOperation = subtractOperation(numberOne, numberTwo);

            Console.WriteLine($"A soma dos números com delegate é: {resultSumOperation}");
            Console.WriteLine($"A subtração dos números com delegate é: {resultSubtractOperation}");

            Console.ReadLine();
        }
    }
}

