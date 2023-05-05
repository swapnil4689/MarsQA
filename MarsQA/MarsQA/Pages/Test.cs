using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using MarsQA.Pages;
using MarsQA.Utilities;

public class Test : Commondriver
{
    
    public void loginChrome()


    {
        driver = new ChromeDriver();

        LoginPage loginPageobj = new LoginPage();
        loginPageobj.loginActions(driver);

    }

}