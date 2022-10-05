using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using log4net;


namespace SeleniumQuiz
{

    public class CommonMethodsClass
    {
       // private static readonly log4net.ILog log =

                    //log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        public static IWebDriver driver;

        public void browserMethod(string browserName)
        {
            if (browserName == "Chrome" || browserName=="chrome")
            {
                driver = new ChromeDriver();
            }
            else if (browserName == "Edge")
            {
                driver = new EdgeDriver();
            }
            driver.Manage().Window.Maximize();
        }
        public void webApplication(string u)
        {
            driver.Url = u;
        }
        public void clickButton(By path)
        {

            driver.FindElement(path).Click();
           // log.Info("   Button is clicked" + path);
        }


        public void textfield(By path, string data)
        {
            driver.FindElement(path).SendKeys(data);
           // log.Info("   Field is filled ");

        }
        public void HoverAction(By path)
        {
            IWebElement first = driver.FindElement(path);
            Actions action = new Actions(driver);
            action.MoveToElement(first).Build().Perform();
            Thread.Sleep(3000);
        }

        public void ScrollElement(By path)
        {
            IJavaScriptExecutor scroller = (IJavaScriptExecutor)driver;
            IWebElement ElementDetect = driver.FindElement(path);
            scroller.ExecuteScript("arguments[0].scrollIntoView(true);", ElementDetect);
        }

        public void logfunction(string s)
        {
           // log.Info(s);

        }






    }
}
