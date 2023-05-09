using MarsQA.Pages;
using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA
{
    [Binding]
    public class FeatureStepDefinitions : Commondriver
    {
        LoginPage loginPageObj = new LoginPage();
        ProfilePage profilePageObj = new ProfilePage(); 

       [Given(@"I launnch and logged into MARSQA portal successfully")]
        public void GivenILaunnchAndLoggedIntoMARSQAPortalSuccessfully()
        {
            driver = new ChromeDriver("C:\\Users\\User\\OneDrive\\Desktop\\MarsQA");
            loginPageObj.loginActions(driver);
        }

        [When(@"I add new education record")]
        public void WhenIAddNewEducationRecord()
        {
            profilePageObj.AddEducation(driver);
        }


        [Then(@"The new Education Record should be added successfully")]
        public void ThenTheNewEducationRecordShouldBeAddedSuccessfully()
        {
            string newEducation = profilePageObj.alertWindow(driver);
            Assert.That(newEducation == "Education has been added", "Failed to add education record");
        }


        [When(@"I edited an existing education record")]
        public void WhenIEditedAnExistingEducationRecord()
        {
            profilePageObj.editEducation(driver);   
        }

        [Then(@"The new education record should be edited successfully")]
        public void ThenTheNewEducationRecordShouldBeEditedSuccessfully()
        {
            string updatedEducation = profilePageObj.alertWindow(driver);
            Assert.That(updatedEducation == "Education as been updated", "Failed to update education record");
        }

        [When(@"I deleted an existing education record")]
        public void WhenIDeletedAnExistingEducationRecord()
        {
            profilePageObj.deleteEducation(driver);
        }

        [Then(@"The new education record should be deleted succesfully")]
        public void ThenTheNewEducationRecordShouldBeDeletedSuccesfully()
        {
            string deleteEducation = profilePageObj.alertWindow(driver);
            Assert.That(deleteEducation == "Education entry successfully removed", "Failed to delete educaton record");

        }
        
        [AfterScenario]
        public void teardown()
        {
            driver.Quit();
        }



    }
}
