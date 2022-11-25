using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Configuration;

namespace SeleniumAutomation
{
    internal class Program
    {

        IWebDriver driver = new ChromeDriver();
       
        static void Main(string[] args)
        {
            
        }


       
        [Test]
        public void Initialise()
        {
            //navigate to google.com
            driver.Navigate().GoToUrl("https:www.amazon.com");
            Console.WriteLine("broweser is opened");

            //find element
            //IWebElement element = driver.FindElement(By.Name("url"));
            //element.Click();
            Console.WriteLine("Action performed");

        }

        [Test]
        public void Close()
        {
            //close the browser
            driver.Close();
            Console.WriteLine("browser closed");
        }
    }
}
