namespace Vokale_zaehlen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(countVowel("Hello World"));
        }
        static int countVowel(string pText)
        {
            int chars=0;
            foreach (char c in pText)
            {
                chars++;
            }
            return chars;
        }
    }
}