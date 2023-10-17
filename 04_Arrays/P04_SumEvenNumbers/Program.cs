namespace P04_SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a numbers ");
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int sum = 0;
            for (int index = 0; index < input.Length; index++)
            {
                int number = int.Parse(input[index]);

                if (number % 2 == 0)
                {
                    sum += number;
                }
            }

            Console.WriteLine(sum);
        }
    }
}