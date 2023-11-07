using System.Linq;

namespace AppleBoxes
{
    public class Program
    {
        static void Main(string[] args)
        {
           
        }
        public static int Solution(int k)
        {
            return Enumerable.Range(1, k)
                .Select(v => v * v * (v % 2 == 0 ? 1 : -1))
                .Sum();
        }
    }
}
