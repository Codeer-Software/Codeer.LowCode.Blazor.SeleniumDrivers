using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Scenario
{
    public class TAPTest
    {
        IWebDriver _driver;

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
        }

        [TearDown]
        public void TearDown() => _driver.Dispose();

        [TestCase]
        public void TestScenario()
        {

        }

        [TestCase]
        public void TestAll()
        {

        }
    }
}
