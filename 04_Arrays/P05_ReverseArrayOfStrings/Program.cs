namespace P05_ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            for (int index = input.Length - 1; index >= 0; index--)
            {
                Console.Write(input[index]);

                if (index != 0)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}