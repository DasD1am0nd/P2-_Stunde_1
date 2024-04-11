using P2Ü_Stunde_1;

namespace ContactTest
{
    public class UnitTest1
    {
        private Contact myContact;
        [SetUp]
        public void Setup()
        {
            myContact = new Contact("a", "n", "c", "D");
        }

        [Test]
        public void Test1()
        {
            Assert.True(myContact.FirstName.Contains("a"));
        }
    }
}