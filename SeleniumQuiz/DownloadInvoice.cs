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
    public class DownloadInvoice: CommonMethodsClass
    {
        #region
        By AddtoCartButton = By.XPath("(//i[@class='fa fa-shopping-cart'])[2]");
        By ContinueButton1 = By.XPath("//button[@class='btn btn-success close-modal btn-block']");
        By CartButton = By.XPath("(//i[@class='fa fa-shopping-cart'])[1]");
        By CheckOutButton = By.XPath("//a[@class='btn btn-default check_out']");
        By LoginButton = By.XPath("//u[text()='Register / Login']");
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
        By ContinueButton = By.XPath("//a[@data-qa='continue-button']");
        By AddtoCartButton2 = By.XPath("(//i[@class='fa fa-shopping-cart'])[2]");
        By ContinueButton2 = By.XPath("//button[@class='btn btn-success close-modal btn-block']");
        By CartButton2 = By.XPath("(//i[@class='fa fa-shopping-cart'])[1]");
        By CheckOutButton2 = By.XPath("//a[@class='btn btn-default check_out']");
        By MessageField = By.XPath("//textarea[@class='form-control']");
        By PlaceOrderButton = By.XPath("//a[@class='btn btn-default check_out']");
        By NameField = By.Name("name_on_card");
        By CardField = By.Name("card_number");
        By CVCfield = By.XPath("//input[@data-qa='cvc']");
        By ExpiryField = By.Name("expiry_month");
        By YearField = By.Name("expiry_year");
        By SubmitButton = By.Id("submit");
        By DownlodButton = By.XPath("//a[@class='btn btn-default check_out']");
        By conButton = By.XPath("//a[@class='btn btn-primary']");

        #endregion

        public void download()
        {
            browserMethod("chrome");
            webApplication("https://automationexercise.com/");
            clickButton(AddtoCartButton);
            Thread.Sleep(3000);
            clickButton(ContinueButton1);
           clickButton(CartButton);
            clickButton(CheckOutButton);
            clickButton(LoginButton);
            textfield(NemeField, "Usman");
            textfield(EmailField, "usmanzahid401@gmail.com");
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
            clickButton(ContinueButton);
            clickButton(AddtoCartButton2);
            Thread.Sleep(3000);
            clickButton(ContinueButton2);
            clickButton(CartButton2);
            clickButton(CheckOutButton2);
            textfield(MessageField, "Kindly Deliver on Time.");
            clickButton(PlaceOrderButton);
            textfield(NameField, "Usman");
            textfield(CardField, "12345678910");
            textfield(CVCfield, "144");
            textfield(ExpiryField, "09");
            textfield(YearField, "2024");
            clickButton(SubmitButton);
            clickButton(DownlodButton);
            clickButton(conButton);


        }
    }
}
