using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecflowPrUpdate.Feature.Pages
{

   
    public class SkillPage
    {
        public IWebDriver Driver { get; }
        public SkillPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebElement SkillTab => Driver.FindElement(By.XPath("//a[normalize-space()='Skills']"));
        public IWebElement SAddLnk => Driver.FindElement(By.CssSelector("div[class='ui teal button']"));
        public IWebElement SkText => Driver.FindElement(By.CssSelector("input[placeholder='Add Skill']"));
        public IWebElement SAddBtn => Driver.FindElement(By.CssSelector("input[value='Add']"));
        public IWebElement DelIc => Driver.FindElement(By.XPath("//tbody[1]/tr[1]/td[3]/span[2]/i[1]"));
        public IWebElement DelIc1 => Driver.FindElement(By.XPath("//tbody[1]/tr[1]/td[3]/span[2]/i[1]"));
        public IWebElement DelIc2 => Driver.FindElement(By.XPath("//tbody[1]/tr[1]/td[3]/span[2]/i[1]"));
        public IWebElement DelIc3 => Driver.FindElement(By.CssSelector("tbody: nth - child(2) > tr:nth - child(1) > td.right.aligned:nth - child(3) > span.button:nth - child(2) > i"));

        
        
        public void SkilLnk()


        {
            Thread.Sleep(2000);
            SkillTab.Click();
        }
        public void Skilbtn()=> SAddLnk.Click();
      
        public void SkillLevel()
        {
            var SkLevel = Driver.FindElement(By.Name("level"));
            var selectElementl = new SelectElement(SkLevel);
            selectElementl.SelectByValue("Beginner");

         }
        public void UpdatSkillBtn() => SAddBtn.Click();

        public void DelIcon()
        {
            DelIc.Click();
            Thread.Sleep(3000);
            DelIc1.Click();
            Thread.Sleep(3000);
            DelIc2.Click();
            Thread.Sleep(3000);

        }
    }
}
