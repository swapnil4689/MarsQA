using MarsQA.Utilities;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.Pages
{
    public class ProfilePage : Wait
    {

        public void AddEducation(IWebDriver driver)
        {

            WaitToBeClickable(driver, "XPath", "//*[@class=\"ui top attached tabular menu\"]/a[3]", 5);

            IWebElement educationTab = driver.FindElement(By.XPath("//*[@class=\"ui top attached tabular menu\"]/a[3]"));
            educationTab.Click();
            Thread.Sleep(3000);

            IWebElement addNewEducation = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            addNewEducation.Click();
            Thread.Sleep(2000);

            IWebElement instituteTextbox = driver.FindElement(By.Name("instituteName"));
            instituteTextbox.SendKeys("Industry Connect");
            Thread.Sleep(2000);

            IWebElement instituteCountryDropdown = driver.FindElement(By.Name("country"));
            instituteCountryDropdown.Click();
            SelectElement instituteCountry = new SelectElement(instituteCountryDropdown);
            instituteCountry.SelectByValue("New Zealand");
            Thread.Sleep(2000);

            IWebElement titleDropdown = driver.FindElement(By.Name("title"));
            titleDropdown.Click();
            SelectElement title = new SelectElement(titleDropdown);
            title.SelectByValue("B.Tech");
            Thread.Sleep(2000);

            IWebElement degreeTextbox = driver.FindElement(By.Name("degree"));
            degreeTextbox.SendKeys("Quality Assurance");
            Thread.Sleep(2000);

            IWebElement yearGraduatedDropdown = driver.FindElement(By.Name("yearOfGraduation"));
            yearGraduatedDropdown.Click();
            SelectElement yearGraduated = new SelectElement(yearGraduatedDropdown);
            yearGraduated.SelectByValue("2023");
            Thread.Sleep(2000);

            IWebElement addEducationButton = driver.FindElement(By.XPath("//*[@value='Add']"));
            addEducationButton.Click();
            Thread.Sleep(2000);

        }
        public void editEducation(IWebDriver driver)
        {

            WaitToBeClickable(driver, "XPath", "//*[@class=\"ui top attached tabular menu\"]/a[3]", 5);

            IWebElement educationTab = driver.FindElement(By.XPath("//*[@class=\"ui top attached tabular menu\"]/a[3]"));
            educationTab.Click();
            Thread.Sleep(3000);

            IWebElement editIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[6]/span[1]/i"));
            editIcon.Click();
            Thread.Sleep(2000);
            IWebElement instituteTextbox = driver.FindElement(By.Name("instituteName"));
            instituteTextbox.Clear();
            Thread.Sleep(2000);
            instituteTextbox.SendKeys("Otago Polytech");

            IWebElement instituteCountryDropdown = driver.FindElement(By.Name("country"));
            instituteCountryDropdown.Click();
            Thread.Sleep(2000);

            SelectElement instituteCountry = new SelectElement(instituteCountryDropdown);
            instituteCountry.SelectByValue("Australia");
            Thread.Sleep(2000);

            IWebElement titleDropdown = driver.FindElement(By.Name("title"));
            titleDropdown.Click();
            SelectElement title = new SelectElement(titleDropdown);
            title.SelectByValue("B.Sc");
            Thread.Sleep(2000);

            IWebElement degreeTextbox = driver.FindElement(By.Name("degree"));
            degreeTextbox.Clear();
            degreeTextbox.SendKeys("Data Analytics");
            Thread.Sleep(1000);

            IWebElement yearGraduatedDropdown = driver.FindElement(By.Name("yearOfGraduation"));
            yearGraduatedDropdown.Click();
            Thread.Sleep(1000);
            SelectElement yearGraduated = new SelectElement(yearGraduatedDropdown);
            yearGraduated.SelectByValue("2022");
            Thread.Sleep(2000);

            IWebElement updateEducationButton = driver.FindElement(By.XPath("//*[@value='Update']"));
            updateEducationButton.Click();
            Thread.Sleep(2000);

        }
        public void deleteEducation(IWebDriver driver)
        {
            WaitToBeClickable(driver, "XPath", "//*[@class=\"ui top attached tabular menu\"]/a[3]", 5);

            IWebElement educationTab = driver.FindElement(By.XPath("//*[@class=\"ui top attached tabular menu\"]/a[3]"));
            educationTab.Click();
            Thread.Sleep(2000);

            IWebElement deleteIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[6]/span[2]/i"));
            deleteIcon.Click();
            Thread.Sleep(2000);

        }
        public string alertWindow(IWebDriver driver)
        {

            WaitForELementToExist(driver, "CssSelector", "[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]", 5);
            IWebElement confirmationAlert = driver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]"));
            return confirmationAlert.Text;

        }

    }
}
