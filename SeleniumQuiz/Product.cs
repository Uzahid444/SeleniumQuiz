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
    public class Product :CommonMethodsClass
    {
        #region
        By ProductButton = By.XPath("//i[@class='material-icons card_travel']");
        By SerachField = By.Id("search_product");
        By SeerchButton = By.XPath("//i[@class='fa fa-search']");
        By AddButton1 = By.XPath("(//i[@class='fa fa-shopping-cart'])[2]");
       
        By AddButton2 = By.XPath("(//i[@class='fa fa-shopping-cart'])[4]");
        
        By AddButton3 = By.XPath("(//i[@class='fa fa-shopping-cart'])[6]");
        By AddButton4 = By.XPath("(//i[@class='fa fa-shopping-cart'])[8]");
        


        #endregion

        public void product()
        {
            browserMethod("chrome");
            webApplication("https://automationexercise.com/");
            clickButton(ProductButton);
            textfield(SerachField, "men");
            clickButton(SeerchButton);
            clickButton(AddButton1);
            Thread.Sleep(3000);
            clickButton(AddButton2);
            Thread.Sleep(3000);
            clickButton(AddButton3);
            Thread.Sleep(3000);
            clickButton(AddButton4);
            Thread.Sleep(3000);

        }
    }
}
