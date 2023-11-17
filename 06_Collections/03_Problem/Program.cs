namespace _03_Problem
{
    internal class Program
    {
        static void Main()
        {
            /* Да се създаде списък (List) от целите трицифрени числа, които се делят
            на сумата от цифрите си. Готовия списък да се изведе на екрана.
            Да се намери средното аритметично на елементите от списъка и
            след всеки елемент, по-голям от средното аритметично, да се добави -1.
            Променения списък да се изведе на екрана */

            List<int> myList = new List<int>();

            for (int i = 100; i < 1000; i++)
            {
                if (DivBySumDigits(i))
                {
                    myList.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", myList));
            Console.WriteLine();
            double average = Average(myList);

            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i] > average)
                {
                    myList.Insert(i + 1, -1);
                }
            }

            Console.WriteLine(string.Join(" ", myList));
        }

        private static bool DivBySumDigits(int n)
        {
            int sum = n / 100 + (n / 10) % 10 + n % 10;
            return (n % sum == 0);
        }

        private static double Average(List<int> myList)
        {
            double sum = 0;
            for (int i = 0; i < myList.Count; i++)
            {
                sum += myList[i];
            }
            return sum / myList.Count;
        }
    }
}
