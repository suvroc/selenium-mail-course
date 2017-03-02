using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EndToEndMailCourse._03
{
    [TestFixture]
    public class Example03Tests
    {
        private string testUrl = "https://suvroc.github.io/selenium-mail-course/03/example.html";


        [Test]
        public void ShouldTestExamplePage()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(testUrl);

            var selectedLineCss = driver.FindElement(By.CssSelector("body > div > div.row.poem1 > div > ul > li.list-group-item.selected"));
            Assert.AreEqual(selectedLineCss.Text, "And there is another sunshine,");

            var selectedLineByAttribute = driver.FindElement(By.CssSelector(".list-group-item[title='flowers']"));
            Assert.AreEqual(selectedLineByAttribute.Text, "In its unfading flowers");

            var selectedLineCssSimple = driver.FindElement(By.CssSelector(".poem1 .list-group > .list-group-item.selected"));
            Assert.AreEqual(selectedLineCssSimple.Text, "And there is another sunshine,");

            var selectedLineXPath = driver.FindElement(By.XPath("/html/body/div/div[2]/div/ul/li[3]"));
            Assert.AreEqual(selectedLineXPath.Text, "And there is another sunshine,");


            var poemElement = driver.FindElement(By.ClassName("poem1"));

            var selectedByNested = poemElement.FindElement(By.CssSelector(".list-group > .list-group-item.selected"));
            Assert.AreEqual(selectedByNested.Text, "And there is another sunshine,");


            var allLines = poemElement.FindElements(By.ClassName("list-group-item"));
            Assert.AreEqual(allLines.Count, 14);

            var disabledLine = poemElement.FindElement(By.ClassName("disabled"));
            Assert.AreEqual(disabledLine.GetAttribute("title"), "brother");


            driver.Quit();
        }

        
    }
}
