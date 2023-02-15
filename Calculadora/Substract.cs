namespace Calculadora
{
    internal class Substract
    {
        public int firstNumber;
        public int secondNumber;
        public int resultSubstract;

        public Substract(int firstNumber, int secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

        public int Perform()
        {
            this.resultSubstract = firstNumber - secondNumber;
            return resultSubstract;
        }

        public int Undo()
        {
            return resultSubstract + secondNumber;
        }
    }
}
