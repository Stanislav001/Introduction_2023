using System.Xml.Serialization;

namespace P00_Demo
{
    internal class Program
    {
        static void Main()
        {
              const int ARRAY_LENGTH = 10;
              const int MIN_NUMBER = 1;
              const int MAX_NUMBER = 100;

              int[] array = GenerateRandomArray(ARRAY_LENGTH, MIN_NUMBER, MAX_NUMBER);

              PrintArray(array);

              int minNumber = GetMinNumberFromArray(array);
              int maxNumber = GetMaxNumberFromArray(array);
              double average = CalculateAverage(array);

              Console.WriteLine($"The min number is: {minNumber}");
              Console.WriteLine($"The max number is: {maxNumber}");

              Console.WriteLine($"Average = {average}");

              SearchForValue(array, 5);

              int[] firstArray = GenerateRandomArray(ARRAY_LENGTH, MIN_NUMBER, MAX_NUMBER);
              int[] secondArray = GenerateRandomArray(ARRAY_LENGTH, MIN_NUMBER, MAX_NUMBER);

              // int[] firstArray = { 10, 20, 5, 4, 5, 6 };
              // int[] secondArray = { 10, 20, 5, 4, 5, 6 };
              PrintArray(firstArray);
              Console.WriteLine("====");
              PrintArray(secondArray);

              bool isEqual = false;
              
              for (int i = 0; i < firstArray.Length; i++) { 
                 if (firstArray[i] == secondArray[i])
                 {
                    isEqual = true;
                    break;
                 } 
              }

              if (isEqual)
              {
                Console.WriteLine("They are equals");
              } else
              {
                Console.WriteLine("Not equals");
              }
        }
        private static int[] GenerateRandomArray(int length, int minValue, int maxValue)
        {
            Random random = new Random();
            int[] randomArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                randomArray[i] = random.Next(minValue, maxValue + 1);
            }

            return randomArray;
        }
        private static void PrintArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
        }
        private static int GetMinNumberFromArray(int[] array)
        {
            int min = array[0]; 

            foreach (int number in array)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            return min;
        }
        private static int GetMaxNumberFromArray(int[] array)
        {
            int max = array[0]; 

            foreach (int number in array)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }
        private static double CalculateAverage(int[] array)
        {
            int sum = 0;
            foreach (int number in array)
            {
                sum += number;
            }
            return (double)sum / array.Length;
        }
        private static void SearchForValue(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    Console.WriteLine($"The number {value} is exist at array");
                }
            }
            Console.WriteLine($"The number {value} is don't exist at array");
        }
    }
}