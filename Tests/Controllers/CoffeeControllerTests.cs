using API_Interactive_Lab_1.Controllers;
using API_Interactive_Lab_1.Models;
using NUnit.Framework;
namespace API_Interactive_Lab_1.Tests
{
    public class CoffeeControllerTests
    {
        [Test]
        public void TestGetCoffee()
        {
            string expectedContent = "I like coffee!";
            var controller = new CoffeeController();
            var result = controller.Get();
            Assert.AreEqual(expectedContent, result);
        }
        [Test]
        public void TestCoffeeByNameWithName()
        {
            var coffeeList = new CoffeeList();
            string name = "Black Coffee";
            var expected = new Coffee(1, "Black Coffee");
            var result = coffeeList.GetCoffee(name);
            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Id, result.Id);
        }
        [Test]
        public void TestCoffeeByNameWithoutName()
        {
            var coffeeList = new CoffeeList();
            var expected = new Coffee(-1, "Latte");
            var result = coffeeList.GetCoffee(null);
            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Id, result.Id);
        }
    }
}
