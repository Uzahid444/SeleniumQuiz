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
    public class RegisterUser : CommonMethodsClass
    {
        #region
        By SignUpButton = By.XPath("//i[@class='fa fa-lock']");
        By NemeField = By.XPath("//input[@data-qa='signup-name']");
        By EmailField = By.XPath("//input[@data-qa='signup-email']");
        By SignupButton = By.XPath("//button[@data-qa='signup-button']");
        By SelectGenderButton = By.Id("id_gender1");
        By PasswordField = By.XPath("//input[@id='password']");
        By DobButton1 = By.XPath("//option[@value='18']");
        By MonthButton = By.XPath("//*[@id='months']/option[13]");
        By YearButton = By.XPath("//option[@value='1998']");
        By OfferButton = By.Id("optin");
        By FirstNameField = By.Id("first_name");
        By LastNameField = By.Id("last_name");
        By CompanyField = By.Id("company");
        By AddressField1 = By.Id("address1");
        By AddressField2 = By.Id("address2");
        By CountryButton = By.XPath("//option[@value='Australia']");
        By StateField = By.Id("state");
        By CityField = By.Id("city");
        By Zipcode = By.Id("zipcode");
        By MobileField = By.Id("mobile_number");
        By CreateButton = By.XPath("//button[@data-qa='create-account']");
        #endregion
        public void registerUser()
        {
          
            browserMethod("chrome");
            webApplication("https://automationexercise.com/");
            clickButton(SignUpButton);
            textfield(NemeField, "Usman Zahid");
            textfield(EmailField, "usmanz5678@gmail.com");
            clickButton(SignupButton);
            clickButton(SelectGenderButton);
            Thread.Sleep(2000);
            textfield(PasswordField, "usman444");
            clickButton(DobButton1);
            clickButton(MonthButton);
            clickButton(YearButton);
            clickButton(OfferButton);
            textfield(FirstNameField, "Usman");
            textfield(LastNameField, "Zahid");
            Thread.Sleep(2000);
            textfield(CompanyField, "Contour");

            textfield(AddressField1, "Lahore");
            textfield(AddressField2, "Swat");
            clickButton(CountryButton);
            textfield(StateField, "Punjab");
            textfield(CityField, "Lahore");
            textfield(Zipcode, "580002");
            textfield(MobileField, "03024442144");
            clickButton(CreateButton);



        
        }





    }




}
