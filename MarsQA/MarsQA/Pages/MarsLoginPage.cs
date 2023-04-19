using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.Pages
{
    public class MarsLoginPage
    {

        public void MarsNavigateToPortal(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("http://localhost:5000/");

            IWebElement marsSignInButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));

            marsSignInButton.Click();

            IWebElement marsUserNameTextBox = driver.FindElement(By.Name("email"));

            marsUserNameTextBox.SendKeys("swapnilbharati4@gmail.com");

            IWebElement marsPasswordTextBox = driver.FindElement(By.Name("password"));

            marsPasswordTextBox.SendKeys("");

            IWebElement marsRememberMeButton = driver.FindElement(By.Name("rememberDetails"));
            marsRememberMeButton.Click();
            Thread.Sleep(1000);

            IWebElement marsLoginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]"));
            marsLoginButton.Click();





        }
    }
}
