using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Övning3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ställa in driver till att använd google Chrome
            IWebDriver driver = new ChromeDriver();
            // Gå till Lyko.se
            driver.Navigate().GoToUrl("http://www.lyko.se/");
            Thread.Sleep(3000);
            //Sök efter schampoo i sökfältet
            driver.FindElement(By.Name("q")).SendKeys("schampoo");
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector("#container > div > div._2503fG > div > div > form > button._1D9Tmf._2nA9po._2mJsVq._25WAvI._2HyibO._2-D67p._1K65kQ._1WPTDP._2nZwW2._2nA9po._2mJsVq._25WAvI._2HyibO._2-D67p")).Click();
            Thread.Sleep(3000);
            //Tryck på en schampoo produkt & Lägg i varukorgen
            driver.FindElement(By.CssSelector("#container > div > main > div > div:nth-child(1) > div:nth-child(2) > div > div:nth-child(1) > div > div > div:nth-child(7) > div > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div > button > span")).Click();
            Thread.Sleep(3000);
            //Gåt till checkout i övre högra hörnet
            driver.FindElement(By.CssSelector("#container > div > div._2503fG > div > div > div.pwwReb.gECg2J > div._1BMbvw._1aC8DQ > div > button")).Click();
            Thread.Sleep(3000);
            //Gå till kassan
            driver.FindElement(By.CssSelector("#container > div > div._2503fG > div > div > div.pwwReb.gECg2J > div._1BMbvw._1aC8DQ > div._2iZQfl > div > div > div > div > ul._2PrcI6 > li:nth-child(4) > a")).Click();
            Thread.Sleep(3000);
            //Öka antalet av produkten till 10
            for (int i = 0; i < 9; i++)
            {
                driver.FindElement(By.CssSelector("#checkout-form > div:nth-child(4) > table > tbody > tr > td._3-PeSx > span > button.YwJvmF._3W7xFV")).Click();
                
            }
            Thread.Sleep(800);
            //Verifiera att Lyko loggan finns
            bool isElementDisplayed = driver.FindElement(By.CssSelector("#container > div > div._2503fG > div > div > div:nth-child(1) > a > div")).Displayed;
            //Tryck på Lycko loggan
            if (isElementDisplayed)
                driver.FindElement(By.CssSelector("#container > div > div._2503fG > div > div > div:nth-child(1) > a > div")).Click();

        }
    }
}
