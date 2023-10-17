namespace P02_FillingArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter count of numbers: ");
            int countOfNumber = int.Parse(Console.ReadLine());

            int[] numbers = new int[countOfNumber];

            for (int index = 0; index < numbers.Length; index++)
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                numbers[index] = number;
            }
           
            Console.WriteLine();

            for (int index = 0; index < numbers.Length; index++)
            {
                Console.Write(numbers[index] + " ");
            }
        }
    }
}