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




        [Given(@"you click on Search")]
        public void GivenYouClickOnSearch()
        {
            loginpages.ClickOnSearch();
        }



        [Given(@"you click on Community")]
        public void GivenYouClickOnCommunity()
        {
            loginpages.ClickOnCommunity();
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

        [When(@"you click on your profile name")]
        public void WhenYouClickOnYourProfileName()
        {
            loginpages.ClickOnYourProfileName();
        }

        [When(@"you click on logout")]
        public void WhenYouClickOnLogout()
        {
            loginpages.ClickOnLogout();
        }

        [Then(@"you should be logged out")]
        public void ThenYouShouldBeLoggedOut()
        {
            loginpages.BeLoggedOut();
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
