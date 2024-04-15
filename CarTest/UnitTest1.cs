namespace CarTest
{
    public class Tests
    {
        private Vehicle car1;
        [SetUp]
        public void Setup()
        {
            car1 = new Vehicle(0, "Ford", "Mustang", 1986, 200.2, true, 500);
        }

        [Test]
        public void Test1()
        {
            Assert.True(car1.CalculateRentalCost(5) == 2500);
            Assert.True(car1.ID == 0 && car1.Manufacturer == "Ford" && car1.Model == "Mustang" && car1.Year == 1986 && car1.Mileage == 200.2 && car1.Availability == true && car1.RentalCost == 500);
        }
    }
}