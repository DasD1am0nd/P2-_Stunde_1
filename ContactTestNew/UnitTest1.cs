using P2�_Stunde_1;

namespace ContactTestNew
{
    public class Tests
    {
        private Contact myContact;
        [SetUp]
        public void Setup()
        {
            myContact = new Contact("Nico", "Stinkt", "ichmag@z�ge.db", "32168");
        }

        [Test]
        public void Test1()
        {
            Assert.True(myContact.FirstName.Contains("Nico"));
        }
    }
}