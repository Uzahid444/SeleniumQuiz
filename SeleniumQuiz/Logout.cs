using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading.Tasks;
using System.Threading;

namespace SeleniumQuiz
{
    public class Logout:CommonMethodsClass
    {
        #region

        By SignInButton = By.XPath("//i[@class='fa fa-lock']");
        By EmailField = By.XPath("//input[@data-qa='login-email']");
        By PasswordField = By.XPath("//input[@data-qa='login-password']");
        By LoginButton = By.XPath("//button[@data-qa='login-button']");
        By LogoutButton = By.XPath("//i[@class='fa fa-lock']");
        #endregion

        public void logout()
        {
            browserMethod("chrome");
            webApplication("https://www.automationexercise.com/");
            clickButton(SignInButton);
            textfield(EmailField, "zeeshanzahid@gmail.com");
            textfield(PasswordField, "zeeshan444");
            clickButton(LoginButton);
            Thread.Sleep(10000);
            clickButton(LogoutButton);
       
        }
    }
}
