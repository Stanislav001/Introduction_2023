namespace ReverseArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static int[] FirstReverseTry(int[] arr)
        {
            if (arr.Length > 1)
            {
                int firstElement = arr[0];
                arr[0] = arr[arr.Length - 1];
                arr[arr.Length - 1] = firstElement;
            }

            return arr;
        }
    }
}
