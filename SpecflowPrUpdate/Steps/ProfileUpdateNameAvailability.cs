using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace SpecflowPrUpdate.Feature
{
    [Binding]
    public class ProfileUpdateNameAvailability 
    {

                IWebDriver driver = new ChromeDriver();
        [Given(@"Clicked on the Profile tab")]
        public void GivenClickedOnTheProfileTab()
        {
            driver.FindElement(By.XPath("//a[normalize-space()='Profile']")).Click();
        }

        [Given(@"click on Update First Name  and LastName")]
        public void GivenClickOnUpdateFirstNameAndLastName()
        {
            driver.FindElement(By.XPath("//div[@class='title']//i[@class='dropdown icon']")).Click();
            var firname = driver.FindElement(By.Name("firstName"));
            firname.SendKeys("Divya");
            driver.FindElement(By.Name("lastName")).SendKeys("kumar");
            driver.FindElement(By.XPath("//button[normalize-space()='Save']")).Click();
        }

        [Given(@"Click on availabilty tab and update availability")]
        public void GivenClickOnAvailabiltyTabAndUpdateAvailability()
        {
            var time = driver.FindElement(By.Name("availabiltyType"));
            var selectElement = new SelectElement(time);
            selectElement.SelectByValue("0");

        }

        [Given(@"click on hour tab and update working hours")]
        public void GivenClickOnHourTabAndUpdateWorkingHours()
        {
            var Workhour = driver.FindElement(By.Name("availabiltyHour"));
            var selectElementh = new SelectElement(Workhour);
            selectElementh.SelectByValue("0");
        }

        [Given(@"click on Ear target  tab to update the  the earning per month")]
        public void GivenClickOnEarTargetTabToUpdateTheTheEarningPerMonth()
        {
            var Target = driver.FindElement(By.Name("availabiltyTarget"));
            var selectElementt = new SelectElement(Target);
            selectElementt.SelectByValue("0");
        }

        [Given(@"click on Add description")]
        public void GivenClickOnAddDescription()
        {
            driver.FindElement(By.XPath("//i[@class='outline write icon']")).Click();
            driver.FindElement(By.Name("value")).Clear();
            driver.FindElement(By.Name("value")).SendKeys("Add Something");
        }

        [Then(@"check all the fields are updated\.")]
        public void ThenCheckAllTheFieldsAreUpdated_()
        {
            String actualname = "Divya";
            var firname = driver.FindElement(By.Name("firstName"));
            Assert.AreEqual(actualname, firname);

        }



        
    }
}
