namespace Fahrzeugverleih_Teil_A
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new[] {
                new Vehicle(0,"Ford","Mustang",1986,200.2,true,500),
                new Vehicle(1,"Ford","Mustang",1986,200.2,true,500),
                new Vehicle(2,"Ford","Mustang",1986,200.2,true,500),
                new Vehicle(3,"Ford","Mustang",1986,200.2,true,500),
                new Vehicle(4,"Ford","Mustang",1986,200.2,true,500)
            };
            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
            Console.WriteLine(cars[0].CalculateRentalCost(5));
        }
    }

    public class Vehicle
    {
        public int ID { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }
        public bool Availability { get; set; }
        public double RentalCost { get; set; }

        public Vehicle(int pID, string pManufacturer, string pModel, int pYear, double pMileage, bool pAvaibility, double pRentalCost)
        {
            ID = pID;
            Manufacturer = pManufacturer;
            Model = pModel;
            Year = pYear;
            Mileage = pMileage;
            Availability = pAvaibility;
            RentalCost = pRentalCost;
        }

        public double CalculateRentalCost(int pDays)
        {
            return pDays * RentalCost;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Manufacturer: {Manufacturer}, Model: {Model}, Year: {Year}, Mileage: {Mileage}, Avaible: {Availability}, Rental cost: {RentalCost}";
        }
    }
}
