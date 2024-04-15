namespace Ratespiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rndInt = new Random();
            int randomNumber = rndInt.Next(1, 101);
            Console.WriteLine("Geben Sie eine Zahl ein:");
            int? input = Convert.ToInt32(Console.ReadLine());
            if (input == randomNumber)
            {
                Console.WriteLine("Sie haben richtig geraten");
            }
            if (input < randomNumber)
            {
                Console.WriteLine("Die Zahl ist größer als die Geratene.");
            }
            if (input > randomNumber)
            {
                Console.WriteLine("Die Zahl ist kleiner als die Geratene.");
            }
        }
    }
}
