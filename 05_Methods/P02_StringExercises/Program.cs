namespace P02_StringExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "The quick brown fox jumps over the lazy dog";  // text.Length -> 43;

            string substring = text.Substring(23);
            string secondSubstring = text.Substring(20, 10);
            Console.WriteLine("Substring result: : " + substring);
            Console.WriteLine("SecondSubstring result: " + secondSubstring);

            Console.WriteLine("Count words in text" + CountWordsInText(text));

            string text2 = "The quick brown fox jumps over the brown lazy dog";
            string wordToFind = "brown";

            // INDEX OF
            int index = text2.IndexOf(wordToFind);

            Console.WriteLine(text2.Substring(index));
            Console.WriteLine(text2);

            // CONTAINS
            Console.WriteLine(text2.Contains("Dog"));                                               // FALSE
            Console.WriteLine(text2.Contains("Dog", StringComparison.InvariantCultureIgnoreCase));  // TRUE

            // INSERT
            string newText = text2.Insert(index, "big ");

            Console.WriteLine(newText);
            Console.WriteLine(text2);

            // REMOVE
            string removedString = text2.Remove(index, wordToFind.Length);

            Console.WriteLine(removedString);

            // ENDS WITH
            Console.WriteLine(text2.EndsWith("lazy dog")); // TRUE
            Console.WriteLine(text2.EndsWith("lazy cat")); // FALSE

            Console.WriteLine(text2.StartsWith("The"));

            // INDEX OF vs LAST INDEX OF
            Console.WriteLine(text2.IndexOf(wordToFind));
            Console.WriteLine(text2.LastIndexOf(wordToFind));

            // REPLACE
            Console.WriteLine(text2.Replace(wordToFind, "white"));

            // TRIM - TRIMEND - TRIMSTART
            Console.Write("                                                                                              asda da d dsa dasds d a    asdsad                                                                           ".Trim());

            Console.Write(123);
        }

        private static int CountWordsInText(string text)
        {
            string[] words = text.Split(' ');
            int countOfWords = words.Length;

            return countOfWords;
        }
    }
}