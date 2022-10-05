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
    public class VerifyAddress: CommonMethodsClass
    {
        #region
        By SignUpButton = By.XPath("//i[@class='fa fa-lock']");
        By NemeField = By.XPath("//input[@data-qa='signup-name']");
        By EmailField = By.XPath("//input[@data-qa='signup-email']");
        By SignupButton = By.XPath("//button[@data-qa='signup-button']");
        By SelectGenderButton = By.Id("id_gender1");
        By PasswordField = By.XPath("//input[@id='password']");
        By DobButton1 = By.XPath("//*[@id='days']/option[7]");
        By MonthButton = By.XPath("//*[@id='months']/option[7]");
        By YearButton = By.XPath("//option[@value='2000']");
        By OfferButton = By.Id("optin");
        By FirstNameField = By.Id("first_name");
        By LastNameField = By.Id("last_name");
        By CompanyField = By.Id("company");
        By AddressField1 = By.Id("address1");
        By AddressField2 = By.Id("address2");
        By CountryButton = By.XPath("//option[@value='United States']");
        By StateField = By.Id("state");
        By CityField = By.Id("city");
        By Zipcode = By.Id("zipcode");
        By MobileField = By.Id("mobile_number");
        By CreateButton = By.XPath("//button[@data-qa='create-account']");
        By ContinueButton = By.XPath("//a[@data-qa='continue-button']");
        By AddButton1 = By.XPath("(//i[@class='fa fa-shopping-cart'])[2]");
        By AddButton2 = By.XPath("(//i[@class='fa fa-shopping-cart'])[4]");
        By ContinueButton1 = By.XPath("//button[@class='btn btn-success close-modal btn-block']");
        By CartButton = By.XPath("(//i[@class='fa fa-shopping-cart'])[1]");
        By CheckOutButton2 = By.XPath("//a[@class='btn btn-default check_out']");
        #endregion

        public void verifyaddress()
        {
            browserMethod("chrome");
            webApplication("https://automationexercise.com/");
            clickButton(SignUpButton);
            textfield(NemeField, "Usman Zahid");
            textfield(EmailField, "usmanzahid123@gmail.com");
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
            textfield(CompanyField, "System");

            textfield(AddressField1, "Malakand");
            textfield(AddressField2, "Chitral");
            clickButton(CountryButton);
            textfield(StateField, "KPK");
            textfield(CityField, "Chitral");
            textfield(Zipcode, "45280");
            textfield(MobileField, "03024442144");
            clickButton(CreateButton);
            clickButton(ContinueButton);
            clickButton(AddButton1);
            Thread.Sleep(3000);

            clickButton(ContinueButton1);
            clickButton(AddButton2);
            Thread.Sleep(3000);
            clickButton(ContinueButton1);
            clickButton(CartButton);
            clickButton(CheckOutButton2);



        }



    }
}
