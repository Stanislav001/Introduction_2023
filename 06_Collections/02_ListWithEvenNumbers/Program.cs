namespace _02_ListWithEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> evenNumbers = Enumerable.Range(0, 20).Where(n => n % 2 == 0).ToList();

            foreach (int num in evenNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("==========");


            List<int> randomNumbers = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 10;)
            {
                int randomNumber = random.Next(10, 100);

                if(randomNumber % 2 == 0)
                {
                    randomNumbers.Add(randomNumber);
                    i++;
                }
            }

            foreach (int number in randomNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}