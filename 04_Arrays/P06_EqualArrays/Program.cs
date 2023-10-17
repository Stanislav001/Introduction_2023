namespace P06_EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int[] arrayOfNumbers2 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sumOfTheArrays = 0;
            int indexOfDifference = 0;
            bool areIdentical = true;

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] != arrayOfNumbers2[i])
                {
                    areIdentical = false;
                    indexOfDifference = i;
                    break;
                }
            }

            if (areIdentical == false)
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {indexOfDifference} index.");
            }
            else
            {
                sumOfTheArrays = arrayOfNumbers.Sum();

                Console.WriteLine($"Arrays are identical. Sum: {sumOfTheArrays}");
            }
        }
    }
}