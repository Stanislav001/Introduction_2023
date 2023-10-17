namespace P01_DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3] { 1, 3, 5 };

            int[] points = new int[3];
            points[0] = 1;
            points[1] = 2;
            points[2] = 3;

            int arrayLength = numbers.Length;
            
            string[] days =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thusday",
                "Friday",
                "Saturday",
                "Sunday",
            };

            string command = Console.ReadLine();

            while (command.ToUpper() != "STOP")
            {
                int number = int.Parse(command);

                string textToPrint = "Invalid day!";
                if (number >= 1 && number <= days.Length)
                {
                    textToPrint = days[number - 1];
                }

                Console.WriteLine(textToPrint);

                command = Console.ReadLine();
            }
        }
    }
}