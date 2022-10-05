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
        By ContinueButton = By.XPath("//button[@class='btn btn-success close-modal btn-block']");
        By CartButton = By.XPath("(//i[@class='fa fa-shopping-cart'])[1]");
        By SignInButton = By.XPath("//i[@class='fa fa-lock']");
        By EmailField = By.XPath("//input[@data-qa='login-email']");
        By PasswordField = By.XPath("//input[@data-qa='login-password']");
        By LoginButton = By.XPath("//button[@data-qa='login-button']");
        By CartButton1 = By.XPath("(//i[@class='fa fa-shopping-cart'])[1]");
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
            clickButton(ContinueButton);
            clickButton(AddButton2);
            Thread.Sleep(3000);
            clickButton(ContinueButton);
            clickButton(AddButton3);
            Thread.Sleep(3000);
            clickButton(ContinueButton);
            clickButton(AddButton4);
            Thread.Sleep(3000);
            clickButton(ContinueButton);
            clickButton(CartButton);
            clickButton(SignInButton);
            textfield(EmailField, "usmanzahid401@gmail.com");
            textfield(PasswordField, "usman444");
            clickButton(LoginButton);
            clickButton(CartButton1);
        }
    }
}
