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
    public class Login: CommonMethodsClass
    {
        #region
        By SignInButton = By.XPath("//i[@class='fa fa-lock']");
        By EmailField = By.XPath("//input[@data-qa='login-email']");
        By PasswordField = By.XPath("//input[@data-qa='login-password']");
        By LoginButton = By.XPath("//button[@data-qa='login-button']");
        By DeleteButton = By.XPath("//i[@class='fa fa-trash-o']");
        By DeleteButton2 = By.XPath("//*[@id='deleteModal']/div/div/div[2]/form/button");
        #endregion

        public void login()
        {
            browserMethod("chrome");
            webApplication("https://www.automationexercise.com/");
            clickButton(SignInButton);
            textfield(EmailField, "usmanz5678@gmail.com");
            textfield(PasswordField, "usman444");
            
            clickButton(LoginButton);
            Thread.Sleep(3000);
            clickButton(DeleteButton);
            clickButton(DeleteButton2);
        }



    }
}
