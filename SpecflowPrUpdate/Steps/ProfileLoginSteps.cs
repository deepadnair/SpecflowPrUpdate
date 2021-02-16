using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SpecflowPrUpdate.Feature.Pages;
using SpecflowPrUpdate.Pages;
using System;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowPrUpdate.Feature
{
    [Binding]
    public class ProfileLoginSteps
    {
        public static IWebDriver webDriver = new ChromeDriver();
        Loginpage loginPage = null;
        readonly Profilepage1 Profile = new Profilepage1(webDriver);
        SkillPage Skilpage = new SkillPage(webDriver);

        [Given(@"I Navigate to the HomePage for Login")]
        public void GivenINavigateToTheHomePageForLogin()
        {


            webDriver.Navigate().GoToUrl("http://localhost:5000/Home");
            webDriver.Manage().Window.Maximize();

            loginPage = new Loginpage(webDriver);

        }

        [Given(@"I Click SignIn link")]
        public void GivenIClickSignInLink()
        {
            loginPage.ClickLogin();

        }


        [Given(@"I Login with Username '(.*)' and Password '(.*)' on the Login Page")]
        public void GivenILoginWithUsernameAndPasswordOnTheLoginPage(string UserName, string Password)
        {
            loginPage.Login(UserName, Password);
        }


        [Given(@"I Click SignIn button to signIn to profile Page")]
        public void GivenIClickSignInButtonToSignInToProfilePage()
        {
            loginPage.ClickLoginButton();
            Thread.Sleep(5000);
        }

        [Given(@"Clicking on the Profile tab")]
        public void GivenClickingOnTheProfileTab()
        {
            String currentURL = webDriver.Url;
            Assert.AreEqual(currentURL, "http://localhost:5000/Account/Profile");
            Profile.ClickProTab();
        }

        [Given(@"Update First Name '(.*)'  and LastName  '(.*)'")]
        public void GivenUpdateFirstNameAndLastName(string firstName, string lastName)
        {
            Profile.NameUpdate(firstName, lastName);
            Assert.AreEqual(firstName, "divya");
            Assert.AreEqual(lastName, "Kumar");

        }

        [Given(@"update availability using availabilty tab")]
        public void GivenUpdateAvailabilityUsingAvailabiltyTab()
        {
            Profile.AvailabiTimeLnk();

        }

        [Given(@"use hour tab and update working hours")]
        public void GivenUseHourTabAndUpdateWorkingHours()
        {
            Profile.AvailabiHourLnk();
        }

        [Given(@"Use Ear target  tab to update the  the earning per month")]
        public void GivenUseEarTargetTabToUpdateTheTheEarningPerMonth()
        {
            Profile.AvailabiTargetLnk();
        }

        [Given(@"Use on Add description")]
        public void GivenUseOnAddDescription()
        {
            Profile.AvailabiDesLnk();
        }


        [Given(@"I Click on the Skills Tab and Click Add Button")]
        public void GivenIClickOnTheSkillsTabAndClickAddButton()
        {
            Skilpage.SkilLnk();
            Skilpage.Skilbtn();
            Thread.Sleep(2000);
        }

        [Given(@"I add the skills and level and update")]
        public void GivenIAddTheSkillsAndLevelAndUpdate(Table table)
        {
            foreach (TableRow row in table.Rows)
            {
                foreach (string value in row.Values)
                {
                    webDriver.FindElement(By.CssSelector("input[placeholder='Add Skill']")).SendKeys(value);
                    Skilpage.SkillLevel();
                    Skilpage.UpdatSkillBtn();
                    Skilpage.Skilbtn();
                    Thread.Sleep(2000);
                }
            }
        }

        [Given(@"Check for delete function")]
        public void GivenCheckForDeleteFunction()
        {
            Skilpage.DelIcon();
            webDriver.Close();
        }
    }
}