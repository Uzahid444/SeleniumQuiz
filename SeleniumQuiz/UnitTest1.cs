using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumQuiz
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Registeruser1()
        {
            RegisterUser r1 = new RegisterUser();
            r1.registerUser();
        }
        [TestMethod]
        public void user2()
        {
            RegisterUser2 r2 = new RegisterUser2();
            r2.registerUser2();
        }

        [TestMethod]
        public void loginfunction()
        {
            Login lo = new Login();
            lo.login();
        }
        [TestMethod]
        public void logout()
        {
            Logout lg = new Logout();
            lg.logout();
        }
        [TestMethod]
        
        public void placeOrder()
        {
            PlaceOrder plo = new PlaceOrder();
            plo.placeorder();   
        }
        [TestMethod]
        public void downloadinvoice()
        {
            DownloadInvoice d = new DownloadInvoice();
            d.download();
        }
        [TestMethod]
        public void products()
        {
            Product p = new Product();
            p.product();
        }
        [TestMethod]
        public void address()
        {
            VerifyAddress v = new VerifyAddress();
            v.verifyaddress();
        }
        [TestMethod]
        public void Removecart()
        {
            Remove r = new Remove();
            r.remove();
        }

    }
}
