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

            IWebElement addNewEducation = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            addNewEducation.Click();

            IWebElement instituteTextbox = driver.FindElement(By.Name("instituteName"));
            instituteTextbox.SendKeys("Industry Connect");

            IWebElement instituteCountryDropdown = driver.FindElement(By.Name("country"));
            instituteCountryDropdown.Click();
            SelectElement instituteCountry = new SelectElement(instituteCountryDropdown);
            instituteCountry.SelectByValue("New Zealand");

            IWebElement titleDropdown = driver.FindElement(By.Name("title"));
            titleDropdown.Click();
            SelectElement title = new SelectElement(titleDropdown);
            title.SelectByValue("B.Tech");

            IWebElement degreeTextbox = driver.FindElement(By.Name("degree"));
            degreeTextbox.SendKeys("Quality Assurance");

            IWebElement yearGraduatedDropdown = driver.FindElement(By.Name("yearOfGraduation"));
            yearGraduatedDropdown.Click();
            SelectElement yearGraduated = new SelectElement(yearGraduatedDropdown);
            yearGraduated.SelectByValue("2023");

            IWebElement addEducationButton = driver.FindElement(By.XPath("//*[@value='Add']"));
            addEducationButton.Click();

        }
        public void editEducation(IWebDriver driver)
        {

            WaitToBeClickable(driver, "XPath", "//*[@class=\"ui top attached tabular menu\"]/a[3]", 5);

            IWebElement educationTab = driver.FindElement(By.XPath("//*[@class=\"ui top attached tabular menu\"]/a[3]"));
            educationTab.Click();

            IWebElement editIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[6]/span[1]/i"));
            editIcon.Click();

            IWebElement instituteTextbox = driver.FindElement(By.Name("instituteName"));
            instituteTextbox.Clear();
            instituteTextbox.SendKeys("Otago Polytech");

            IWebElement instituteCountryDropdown = driver.FindElement(By.Name("country"));
            instituteCountryDropdown.Click();
            SelectElement instituteCountry = new SelectElement(instituteCountryDropdown);
            instituteCountry.SelectByValue("Australia");

            IWebElement titleDropdown = driver.FindElement(By.Name("title"));
            titleDropdown.Click();
            SelectElement title = new SelectElement(titleDropdown);
            title.SelectByValue("B.Sc");

            IWebElement degreeTextbox = driver.FindElement(By.Name("degree"));
            degreeTextbox.Clear();
            degreeTextbox.SendKeys("Data Analytics");

            IWebElement yearGraduatedDropdown = driver.FindElement(By.Name("yearOfGraduation"));
            yearGraduatedDropdown.Click();
            SelectElement yearGraduated = new SelectElement(yearGraduatedDropdown);
            yearGraduated.SelectByValue("2022");

            IWebElement updateEducationButton = driver.FindElement(By.XPath("//*[@value='Update']"));
            updateEducationButton.Click();

        }
        public void deleteEducation(IWebDriver driver)
        {
            WaitToBeClickable(driver, "XPath", "//*[@class=\"ui top attached tabular menu\"]/a[3]", 5);

            IWebElement educationTab = driver.FindElement(By.XPath("//*[@class=\"ui top attached tabular menu\"]/a[3]"));
            educationTab.Click();

            IWebElement deleteIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[6]/span[2]/i"));
            deleteIcon.Click();

        }
        public string alertWindow(IWebDriver driver)
        {

            WaitForELementToExist(driver, "CssSelector", "[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]", 5);
            IWebElement confirmationAlert = driver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]"));
            return confirmationAlert.Text;

        }

    }
}
