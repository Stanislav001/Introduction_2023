namespace Candles
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static int Candles(int candlesNumber, int makeNew)
        {
            int burnedCandles = 0;
            while (candlesNumber > 0)
            {
                candlesNumber--;
                burnedCandles++;
                if (burnedCandles % makeNew == 0)
                    candlesNumber++;
            }
            return burnedCandles;
        }
    }
}
