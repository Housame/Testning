using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JavaToCsharp
{
    // TODO 1. Skapa en main
    // TODO 2. Hämta plugin
    // TODO 3. Hitta sökfätet i google
    // TODO 4. Sök efter "Testautomatisering Stockholm"
    // TODO 5. Hitta sök knappen, klicka på den
    // TODO 
  
    class Program
    {
        //static IWebDriver driver;
        static void Main(string[] args)
        {
            //ställa in driver till att använd google Chrome
            IWebDriver driver = new ChromeDriver();
            // Öppna google
            driver.Navigate().GoToUrl("http://www.google.com/");
            // Ställa in en wait tills driver laddar google
            Thread.Sleep(3000);
            // Hitta sök-fältet och skriv in "Testautomatisering Stockholm"
            driver.FindElement(By.Id("lst-ib")).SendKeys("Testautomatisering Stockholm");
            Thread.Sleep(3000);
            // Hitta sök knappen, klicka på den 
            driver.FindElement(By.Id("_fZl")).Click();
            // Vänta tills dess att element är synligt
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement result = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("resultStats")));
            //Ta fram resultatstats och skriv ut
            Console.WriteLine(result.Text);


        }
    }
}
