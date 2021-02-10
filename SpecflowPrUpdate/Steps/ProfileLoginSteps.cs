using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SpecflowPrUpdate.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecflowPrUpdate.Feature
{
    [Binding]
    public class ProfileLoginSteps
       

    {
        IWebDriver driver = new ChromeDriver();
        
        
        Loginpage loginPage = null;
       

        [Given(@"I Navigate to the HomePage for Login")]
        public void GivenINavigateToTheHomePageForLogin()
        {
           

            driver.Navigate().GoToUrl("http://localhost:5000/Home");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(40);
            Loginpage loginPage = new Loginpage(driver);
        }
        
        [Given(@"I Click SignIn button")]
        public void GivenIClickSignInButton()
        {
            driver.FindElement(By.LinkText("Sign In")).Click();
          //  loginPage.ClickSignIn();
        }

        [Given(@"I Login with Username '(.*)' and Password '(.*)' on the Login Page")]
        public void GivenILoginWithUsernameAndPasswordOnTheLoginPage(string UserName, string Password)
        {
             driver.FindElement(By.Name("email")).SendKeys("deepa.nair.d@gmail.com");                
             driver.FindElement(By.Name("password")).SendKeys("Industry15Connect");
           
        }
        
        [Given(@"I Click Login button")]
        public void GivenIClickLoginButton()
        {
            // loginPage.Clickloginbutton();

            driver.FindElement(By.CssSelector("button[class='fluid ui teal button']")).Click();
           

            var waitt = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
            var div = waitt.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Profile")));
            div.Click();

        }
        [Then(@"I should login to Profile page")]
        public void ThenIShouldLoginToProfilePage()
        {

            String actualurl = "http://localhost:5000/Account/Profile";

            String expectedurl = driver.Url;
            Assert.AreEqual(expectedurl, actualurl);

        }

        

    }
}
