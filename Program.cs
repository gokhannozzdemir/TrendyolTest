using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace TrendyolTest
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var driver = new ChromeDriver();
            
            string link = @"https://www.trendyol.com";
            driver.Navigate().GoToUrl(link);


            driver.FindElement(By.ClassName("homepage-popup-gender")).Click();
            Console.WriteLine("Onaylandi");

            driver.FindElement(By.ClassName("link-text")).Click();
            Console.WriteLine("Onaylandi");

            driver.FindElement(By.Id("login-email")).SendKeys("gokhannozzdemir@gmail.com");
            Console.WriteLine("Onaylandi");

            driver.FindElement(By.Id("login-password-input")).SendKeys("xxxxxxxx");
            Console.WriteLine("Onaylandi");

            driver.FindElement(By.XPath(".//*[@class = 'q-primary q-fluid q-button-medium q-button submit']")).Click();
            Console.WriteLine("Onaylandi");

            driver.FindElement(By.XPath(".//*[@class = 'search-box']")).SendKeys("Samsung");
            Console.WriteLine("Onaylandi");

            driver.FindElement(By.XPath(".//*[@class = 'search-icon']")).Click();
            Console.WriteLine("Onaylandi");

            driver.FindElement(By.XPath(".//*[@class = 'fvrt-btn fvred']")).Click();
            Console.WriteLine("Onaylandi");

            driver.FindElement(By.ClassName("account-nav-item account-favorites")).Click();
            Console.WriteLine("Onaylandi");

            driver.FindElement(By.ClassName("ufvrt-btn")).Click();
            Console.WriteLine("Onaylandi");











        }
    }
}
