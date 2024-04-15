namespace Uebung_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrom:");
            string? input = Console.ReadLine();
            char[] inputArray = input.ToCharArray();
            Array.Reverse(inputArray);
            string reversed = new string(inputArray);
            if (input == reversed)
            {
                Console.WriteLine($"Es handelt sich bei {input} um ein Palindrom");
            }
            else
            {
                Console.WriteLine($"Es handelt sich bei {input} nicht um ein Palindrom");
            }
        }
    }
}
