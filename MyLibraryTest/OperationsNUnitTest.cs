using NUnit.Framework;

namespace MyLibrary
{
    [TestFixture]
    public class OperationsNUnitTest
    {
        [Test]
        public void Add_InputNumbers_ReturnNumber()
        {
            // 1. Arrange (iniciar/arrancar)
            // Tres formas diferentes de hacer lo mismo
            // Operations operations = new Operations();
            // Operations operations = new ();
            var operations = new Operations();
            int number1 = 2;
            int number2 = 5;

            // 2. Act (hacer la prueba)
            int result = operations.Add(number1,number2);

            //3. Assert (ver si funciona, comprobacion)
            Assert.That(result, Is.EqualTo(7));                 // Comprobar que es 7
            Assert.That(result, Is.Not.EqualTo (8));            //Comprobar que es distinto de 7 por arriba
            Assert.That(result, Is.Not.EqualTo(6));             //Comprobar que es distinto de 7 por abajo
        }

        [Test]
        [TestCase(10)]
        [TestCase(12)]
        [TestCase(14)]
        public void IsEven_InputNumbers_ReturnTrue(int number) 
            { 
            // 1. Arrange
            var operations = new Operations();
            //int number = 10;

            // 2. Act
            var result = operations.isEven(number);

            // 3. Assert
            Assert.That(result, Is.True);
            }

        [Test]
        [TestCase(2.2,1.2)]
        [TestCase(2.23,1.24)]
        public void AddDecimal_InputDoubleNumbers_ReturnDoubleNumber(double number1, double number2)
        {
            var operations = new Operations();

            var result = operations.AddDecimal(number1,number2);

            Assert.That(result, Is.EqualTo(3.4).Within(0.1));
        }
    }
}
