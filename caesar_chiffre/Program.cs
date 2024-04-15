namespace caesar_chiffre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sei gegrüßt Anwendender\nGeben Sie einen Text ein der verschlüsselt werden soll:");
            string? input;
            do
            {
                input = Console.ReadLine();
            } while (input != input.ToUpper());
            Console.WriteLine("Geben Sie eine Anzahl an Buchstaben ein um die Rotiert werden soll:");
            int inputRotations;
            do
            {
                inputRotations = Convert.ToInt32(Console.ReadLine());
            }
            while (!(inputRotations >= 1 && inputRotations <= 25));
            char[] textLetters = input.ToCharArray();
            string output = "";
            int asciichar;
            foreach (char c in textLetters)
            {
                asciichar = (int)c;
                asciichar = asciichar + inputRotations;
                output += (char)asciichar;
            }
            Console.WriteLine(output);
        }
    }
}
