namespace Temperatur
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie eine Temperatur und eine Einheit (C/F) ein.");
            string? input = Console.ReadLine();
            char[] inputChars = input.ToCharArray();
            
            string numberOut = "";
            foreach (char c in inputChars)
            {
                switch(c)
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9': numberOut+= c; break;
                    default: break;
                }
            }

            if (input.Contains('f') || input.Contains('F'))
            {
                Console.WriteLine($"{input} entspechen {((Convert.ToDouble(numberOut)-32)*5/9)}°C");
            }
            if (input.Contains('c') || input.Contains('C'))
            {
                Console.WriteLine($"{input} entspechen {((Convert.ToDouble(numberOut) * 1.8) + 32)}°F");
            }
            Console.ReadLine();
        }
    }
}