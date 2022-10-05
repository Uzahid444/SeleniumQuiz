using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumQuiz
{
    public class Remove: CommonMethodsClass
    {

        #region
        By CartButton = By.XPath("(//i[@class='fa fa-shopping-cart'])[1]");
        By AddButton1 = By.XPath("(//i[@class='fa fa-shopping-cart'])[2]");
        By AddButton2 = By.XPath("(//i[@class='fa fa-shopping-cart'])[4]");
        By ContinueButton1 = By.XPath("//button[@class='btn btn-success close-modal btn-block']");
        By RemoveButton = By.XPath("//i[@class='fa fa-times']");
        By RemoveButton2 = By.XPath("//a[@data-product-id='2']");
        #endregion

        public void remove()
        {
            browserMethod("chrome");
            webApplication("https://automationexercise.com/");
           // clickButton(CartButton);
            clickButton(AddButton1);
            Thread.Sleep(3000);
            clickButton(ContinueButton1);
            clickButton(AddButton2);
            Thread.Sleep(3000);
            clickButton(ContinueButton1);
            clickButton(CartButton);
            Thread.Sleep(2000);
            clickButton(RemoveButton);
            clickButton(RemoveButton2);

        }
    }
}
