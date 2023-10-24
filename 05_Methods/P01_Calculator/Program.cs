namespace P01_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Input: 5 + 3 Expected Output: The result is: 8

                Input: 10 - 2 Expected Output: The result is: 8

                Input: 4 * 6 Expected Output: The result is: 24

                Input: 12 / 3 Expected Output: The result is: 4
             */

            string expression = Console.ReadLine();
            string[] tokens = expression.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int firstOperand = int.Parse(tokens[0]); 
            int secondOperand = int.Parse(tokens[2]); 

            char sign = char.Parse(tokens[1]); 

            double result = DoTheCalculations(firstOperand, secondOperand, sign);

            Console.WriteLine($"The result is: {result}");
        }

        private static double DoTheCalculations(int firstOperand, int secondOperand, char sign)
        {
            double resultFromCalculations = 0;

            switch (sign)
            {
                case '+':
                    resultFromCalculations = SumTwoNumbers(firstOperand, secondOperand);
                    break;
                case '-':
                    resultFromCalculations = SubstractTwoNumbers(firstOperand, secondOperand);
                    break;
                case '*':
                    resultFromCalculations = MultiplyTwoNumbers(firstOperand, secondOperand);
                    break;
                case '/':
                    resultFromCalculations = DivideTwoNumbers(firstOperand, secondOperand);
                    break;

                default:
                    throw new ArgumentException("The sign is not correct!");
            }

            return resultFromCalculations;
        }

        private static double DivideTwoNumbers(int firstOperand, int secondOperand)
        {
            return firstOperand / (double)secondOperand;
        }

        private static double SubstractTwoNumbers(int firstOperand, int secondOperand)
        {
            return firstOperand - secondOperand;
        }

        private static double MultiplyTwoNumbers(int firstOperand, int secondOperand)
        {
            return firstOperand * secondOperand;
        }


        private static double SumTwoNumbers(int firstOperand, int secondOperand)
        {
            double sum = firstOperand + secondOperand;

            return sum;
        }
    }
}