using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecflowPrUpdate.Feature.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecflowPrUpdate.Pages
{
 
    class Loginpage

    {
        public IWebDriver Driver { get; }
        public Loginpage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebElement LnkSignIn => Driver.FindElement(By.LinkText("Sign In"));
        public IWebElement TxtEmail => Driver.FindElement(By.Name("email"));
        public IWebElement Txtpasswrd => Driver.FindElement(By.Name("password"));
        public IWebElement BtnLogin => Driver.FindElement(By.CssSelector("button[class='fluid ui teal button']"));
        public IWebElement Profilepage => Driver.FindElement(By.XPath("//a[normalize-space()='Profile']"));
        public void ClickLogin() => LnkSignIn.Click();
        public void Login(string UserName, string Password)
        {
            TxtEmail.SendKeys(UserName);
            Txtpasswrd.SendKeys(Password);
        }
        public void ClickLoginButton() => BtnLogin.Click();
      
    }
}
