using NUnit.Framework;
using System;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Security.Principal;

namespace TestProjectForHitachiSolutions
{
    [TestFixture]
    public class Tests
    {

        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void NavigateToSite()
        {
            
            driver.Url = "https://global.hitachi-solutions.com/blog/women-in-construction-week-building-momentum/";
            IWebElement element = driver.FindElement(By.XPath("//a[@id='open-global-search']"));
            element.Click();
            IWebElement searchTextBox = driver.FindElement(By.XPath("//input[@id='site-search-keyword']"));
            Thread.Sleep(1000);
            searchTextBox.SendKeys("jobs");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IWebElement closePopup = driver.FindElement(By.XPath("//button[@title='Close']"));
            Thread.Sleep(1000);
            closePopup.Click();
            IWebElement enterTextBox = driver.FindElement(By.XPath("//button[@class='search-form-submit']"));
            enterTextBox.Click();
            Thread.Sleep(1000);
            IWebElement searchElementResults = driver.FindElement(By.XPath("//div//h4[contains(text(),'Search results for: jobs')]"));
            Thread.Sleep(1000);
            Assert.IsTrue(searchElementResults != null);
        }
        [TearDown]
        public void Test2()
        {
            driver.Quit();
        }
        
    }
}