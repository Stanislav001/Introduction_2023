using System.Linq;

namespace RemoveArrayPart
{
    public class Program
    {
        static void Main(string[] args)
        {
          
        }
        public static int[] Solution(int[] inputArray, int l, int r)
        {
            return inputArray.Take(l).Concat(inputArray.Skip(r + 1)).ToArray();
        }
    }
}
