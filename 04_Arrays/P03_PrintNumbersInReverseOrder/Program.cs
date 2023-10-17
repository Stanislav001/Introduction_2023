namespace P03_PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter count of numbers: ");
            int count = int.Parse(Console.ReadLine());
            int[] array = new int[count];

            for (int index = 0; index < array.Length; index++)
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                array[index] = number;
            }

            for (int index = array.Length - 1; index >= 0; index--)
            {
                Console.Write(array[index] + " ");
            }
        }
    }
}