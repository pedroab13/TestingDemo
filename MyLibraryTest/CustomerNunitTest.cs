using NUnit.Framework;

namespace MyLibrary
{
    [TestFixture]
    public class CustomerNunitTest
    {
        [Test]
        public void Fullname_ReturnEmpty()
        {
            //1. Arrange
            Customer customer = new Customer();

            //2. Act
            string result = customer.FullName;

            //3. Assert
            Assert.That(result, Is.WhiteSpace);
        }

        [Test]
        public void Fullname_ReturnFullName()
        {
            //1. Arrange
            Customer customer = new Customer
            {
                FirstName = "Pedro",
                LastName = "Alvarez"
            };
            
            //2. Act
            string result = customer.FullName;

            //3. Assert
            Assert.That(result, Is.Not.WhiteSpace);
            Assert.That(result, Does.Contain(""));
            Assert.That(result, Does.Contain("Pedro"));
            Assert.That(result, Does.Contain("Alvarez"));
            Assert.That(result, Does.StartWith("Pedro"));
            Assert.That(result, Does.EndWith("Alvarez"));
            Assert.That(result, Is.EqualTo("Pedro Alvarez"));
            Assert.That(result, Is.EqualTo("pedro alvarez").IgnoreCase);
        }
    }
}