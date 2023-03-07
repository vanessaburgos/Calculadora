namespace Calculadora
{
    internal class Multiply
    {
        public int firstNumber;
        public int secondNumber;
        public int resultMultiply;

        public Multiply(int firstNumber, int secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

        public int Perform()
        {
            this.resultMultiply = firstNumber * secondNumber;
            return resultMultiply;
        }

        public int Undo()
        {
            return resultMultiply / secondNumber;
        }
    }
}
