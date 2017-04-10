using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace EndToEndMailCourse._05
{
    [TestFixture]
    public class Workshop05Tests
    {
        private string testUrl = "https://suvroc.github.io/selenium-mail-course/05/workshop.html";

        [Test]
        public void ShouldSelectAnswers()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(testUrl);

         //   var qualityElement =  driver.FindElement(By.Id("procuctQualityElement"));
         //   var supportElement = driver.FindElement(By.Id("supportQualityElement"));

       var   qualityElement = new SelectElement(driver.FindElement(By.Id("procuctQualityElement")));
           qualityElement.SelectByValue("good");
         

        var    supportElement = new SelectElement(driver.FindElement(By.Id("supportQualityElement")));
            supportElement.SelectByValue("poor");

            #region TEST

            #endregion

            Assert.AreEqual(qualityElement.SelectedOption.Text, "Good");
                
            Assert.AreEqual(supportElement.SelectedOption.Text, "Poor");

            driver.Quit();
        }
    }
}