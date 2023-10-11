namespace _03_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myAge = 22;
            
            string myName = "Ivan Ivanov Petrov";
            int charsOfMyName = myName.Length;
            
            for (int i = 0; i < myName.Length; i++)
            {
                Console.WriteLine(myName[i]);
            }

            Console.WriteLine("For loop");

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Iteration " + i);
            }

            Console.WriteLine();
            Console.WriteLine("While loop");

            int count = 1;
            while (count <= 5)
            {
                Console.WriteLine("Iteration " + count);
                count++;
            }

        }
    }
}