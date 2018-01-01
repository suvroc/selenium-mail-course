using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace EndToEndCourse._05
{
    [TestFixture]
    public class Example05Tests
    {
        private string testUrl = "https://suvroc.github.io/selenium-course/05/example.html";


        [Test]
        public void ShouldTestExamplePage()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(testUrl);

            var selectElement = new SelectElement(driver.FindElement(By.Id("selectElement")));

            selectElement.SelectByIndex(2);
            Assert.AreEqual(selectElement.SelectedOption.Text, "Value3");

            selectElement.SelectByText("Value4");
            Assert.AreEqual(selectElement.SelectedOption.Text, "Value4");

            selectElement.SelectByValue("value2");
            Assert.AreEqual(selectElement.SelectedOption.Text, "Value2");

            var checkboxElement = driver.FindElement((By.Id("checkboxElement")));
            checkboxElement.Click();

            Assert.AreEqual(checkboxElement.Selected, true);

            var combinationElement = driver.FindElement((By.Id("keyInput")));
            combinationElement.SendKeys(Keys.Control + "L");
            //Actions actions = new Actions(driver);
            //actions
            //    .KeyDown(Keys.Control)
            //    .SendKeys(Keys.  "L")
            //    .Release()
            //    .Build()
            //    .Perform();
            var innerElement = driver.FindElement(By.Id("innerElement"));
            Assert.IsTrue(innerElement.Displayed);
            var oldPosition = innerElement.Location;

            new Actions(driver)
                .DragAndDropToOffset(innerElement, 5, 5)
                .Build()
                .Perform();

            var newPosition = innerElement.Location;

            Assert.AreNotEqual(oldPosition.X, newPosition.X);
            Assert.AreNotEqual(oldPosition.Y, newPosition.Y);

            driver.Quit();
        }

        
    }
}
