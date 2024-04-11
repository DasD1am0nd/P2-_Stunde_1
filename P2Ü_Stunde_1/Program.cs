namespace P2Ü_Stunde_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int sum = a + b;
            Console.WriteLine(sum);
            Console.WriteLine(add(a, b));

            var contact1 = new Contact("Nico", "Stinkt", "ichmag@züge.db", "32168");
            //contact1.FirstName = "Olga"; //Geht nicht da FirstName privat
            //contact1.NickName = ""; //Exception wird getriggered
            contact1.NickName = "Roblox Mann";
            Console.WriteLine($"firstName: {contact1.FirstName}, lastName: {contact1.LastName}");
            Console.WriteLine(contact1.Name);

            string? input; //nur deklariert, hat deswegen ehh wert null, alternativ string? input = null;
            do
            {
                Console.WriteLine("Bitte gebe einen Suchstring ein:");
                input = Console.ReadLine(); //? macht String Nullable 
            } while (string.IsNullOrEmpty(input));
            Console.WriteLine($"Suche nach {input}");

            Contact[] contacts = new[]
                {
                new Contact("Nico","Stinkt","ichmag@züge.db","32168"),
                new Contact("Olchi", "Stinkt", "ichmag@muell.halde", "32168"),
                new Contact("Grinch","Stinkt","ichmag@weihnachten.xmas","32168")
                };

            Contact myContact = contacts[0];
            myContact.LastName = "stinkt nicht mehr";

            /*
            Contact[] contacts2 = new Contact[1];
            contacts2[0].LastName = "stinkt nicht mehr";
            */

            foreach (var contact in contacts)
            {
                if (contact.FirstName.Contains(input))
                {
                    Console.WriteLine(contact.FormatString());
                    Console.WriteLine(contact.ToString());
                }
            }
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

        static int add(int a, int b)
        {
            return a + b;
        }
    }
}
