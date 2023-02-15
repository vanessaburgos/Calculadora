using System;

namespace Calculadora
{
    internal class CalculatorProgram
    {
        public int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public int Substract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public float Divide(int firstNumber, int secondNumber)
        {
            return (float)firstNumber / (float)secondNumber;
        }
        static void Main(string[] args)
        {
            var calculatorProgram = new CalculatorProgram();

            var sumOne = new Sum(1, 2);
            var sumSecond = new Sum(sumOne.Perform(), 8);
            var sumThird = new Sum(sumSecond.Perform(), 9);
            Console.WriteLine(sumThird.Perform());
            var resultAfterUndoTheSum = sumThird.Undo();
            Console.WriteLine(resultAfterUndoTheSum);
            Console.WriteLine("---------------------------");

            var substractOne = new Substract(8, 2);
            var substractSecond = new Substract(substractOne.Perform(), 1);
            Console.WriteLine(substractSecond.Perform());
            var resultAfterUndoTheSubstract = substractSecond.Undo();
            Console.WriteLine("---------------------------");
            Console.WriteLine(resultAfterUndoTheSubstract);
            Console.WriteLine("---------------------------");

            var multiplytOne = new Multiply(5, 2);
            var multiplySecond = new Multiply(multiplytOne.Perform(), 2);
            Console.WriteLine(multiplySecond.Perform());
            var resultAfterUndoTheMultiply = multiplySecond.Undo();
            Console.WriteLine("---------------------------");
            Console.WriteLine(resultAfterUndoTheMultiply);
            Console.WriteLine("---------------------------");

            var divideOne = new Divide(10, 2);
            var divideSecond = new Divide(divideOne.Perform(), 1);
            Console.WriteLine(divideSecond.Perform());
            var resultAfterUndoTheDivide = divideSecond.Undo();
            Console.WriteLine("---------------------------");
            Console.WriteLine(resultAfterUndoTheDivide);
            Console.WriteLine("---------------------------");
        }
    }
}
