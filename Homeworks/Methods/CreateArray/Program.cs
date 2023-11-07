namespace CreateArray
{
    public class Program
    {
        static void Main(string[] args)
        {
          
        }
        public static int[] CreateArray(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = 1;
            }

            return array;
        }
    }
}
