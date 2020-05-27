using MentorGiftreteWork2.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace MentorGiftreteWork2.Stepdefinitions
{
    [Binding]
    public class LoginSteps
    {

        Loginpages loginpages;
        public LoginSteps()
        {
            loginpages = new Loginpages();
        }

        [Given(@"I click on Search")]
        public void GivenIClickOnSearch()
        {
            loginpages.ClickOnSearch();
        }


        [Then(@"I should be logged out")]
        public void ThenIShouldBeLoggedOut()
        {
            loginpages.BeLoggedOut();

        }


        [When(@"I click on logout")]
        public void WhenIClickOnLogout()
        {

            loginpages.ClickOnLogout();
        }


        [When(@"I click on your profile name")]
        public void WhenIClickOnYourProfileName()
        {
            loginpages.ClickOnYourProfileName();

        }

        [Given(@"I click on Community")]
        public void GivenIClickOnCommunity()
        {
            loginpages.ClickOnCommunity();
        }


        [Then(@"I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
            loginpages.ShouldBeLoggedIn();

        }

        [Then(@"all items should be displayed")]
        public void ThenAllItemsShouldBeDisplayed()
        {
            loginpages.ItemsShouldBeDisplayed();
        }


        [Then(@"Communities should be displayed")]
        public void ThenCommunitiesShouldBeDisplayed()
        {
            loginpages.CommunitiesShouldBeDisplayed();
        }


        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            
        }



        [Given(@"I navigate to giftrete website ""(.*)""")]
        public void GivenINavigateToGiftreteWebsite(string Url)
        {
            loginpages.NavigateToGiftreteWebsite(Url);

        }
        
        [Given(@"I click on Signin button")]
        public void GivenIClickOnSigninButton()
        {
            loginpages.ClickOnSigninButton();
        
        }
        
        [Given(@"I enter my Email Address""(.*)""")]
        public void GivenIEnterMyEmailAddress(string email)
        {
            loginpages.MyEmailAddress(email);
        }
        
        [Given(@"I enter my Password""(.*)""")]
        public void GivenIEnterMyPassword(string pwd)
        {
            loginpages.MyPassword(pwd); 
        }
        
        [Given(@"I click Signin")]
        public void GivenIClickSignin()
        {
            loginpages.ClickSignin();
        }
        
       
    }
}
