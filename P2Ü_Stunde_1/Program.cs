namespace P2Ü_Stunde_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int sum = a+b;
            Console.WriteLine(sum);

            var contact1 = new Contact("Nico","Stinkt");
        }

        static bool isEven(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }
    }
}
