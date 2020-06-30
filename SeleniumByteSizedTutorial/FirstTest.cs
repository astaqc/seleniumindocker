using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SeleniumByteSizedTutorial
{
    [TestClass]
    public class FirstTest
    {
        private RemoteWebDriver _driver;
        public TestContext TestContext {get; set;}
        [TestInitialize]
        public void Setup(){
            var options = new ChromeOptions();
            var RemoteWebDriverUrl = "http://localhost:4444/wd/hub";
            _driver = new RemoteWebDriver(new Uri(RemoteWebDriverUrl), options ); 
        }

        [TestMethod]
        public void OpenYoutube(){
            _driver.Navigate().GoToUrl("https://google.com");
            Assert.IsTrue(_driver.Title.Contains("Google"));
            _driver.Quit();
        }
    }

}
