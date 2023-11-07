using System;

namespace CountSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static int CountSumOfTwoRepresentations(int n, int l, int r)
        {
            int a = n / 2;
            int b = n - a;
            if ((a < l) || (b > r)) return 0;
            return Math.Min(a - l, r - b) + 1;
        }
    }
}
