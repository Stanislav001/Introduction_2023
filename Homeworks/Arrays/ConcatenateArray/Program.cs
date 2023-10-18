using System.Linq;

namespace ConcatenateArray
{
    public class Program
    {
        static void Main(string[] args)
        {
          
        }
       public static int[] ConcatenateArrays(int[] a, int[] b)
        {
            return a.Concat(b).ToArray();
        }
    }
}
