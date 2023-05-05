using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace MarsQA.Pages
{
    public class LoginPage 
    {
        public void loginActions(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("http://localhost:5000/Home");

            IWebElement signInButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            signInButton.Click();

            IWebElement userNameTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            userNameTextbox.SendKeys("swapnilbharati4@gmail.com");

            IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passwordTextbox.SendKeys("anvi2510");

            IWebElement rememberMeCheckbox = driver.FindElement(By.Name("rememberDetails"));
            rememberMeCheckbox.Click();

            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();

        }

    }
}
