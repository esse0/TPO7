
namespace CalculatorApp
{
    public static class Calculator
    {
        public static float GetSum(float firstNumberOperand, float secondNumberOperand)
        {
            return firstNumberOperand + secondNumberOperand;
        }

        public static float GetSubtract(float firstNumberOperand, float secondNumberOperand)
        {
            return firstNumberOperand - secondNumberOperand;
        }

        public static float GetMultiply(float firstNumberOperand, float secondNumberOperand)
        {
            return firstNumberOperand * secondNumberOperand;
        }

        public static float GetDivide(float firstNumberOperand, float secondNumberOperand)
        {
            if (secondNumberOperand == 0) throw new DivideByZeroException();

            return firstNumberOperand / secondNumberOperand;
        }
    }
}
