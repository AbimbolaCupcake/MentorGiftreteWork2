using MentorGiftreteWork2.Hooks;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MentorGiftreteWork2.PageObjects
{
    class Loginpages
    {
        IWebDriver driver;

        
        IWebElement signIn => driver.FindElement(By.XPath("(//a[text()='Sign In'])[1]"));

        IWebElement emailAddress => driver.FindElement(By.XPath("(//input[@type='email'])[1]"));

        IWebElement password => driver.FindElement(By.XPath("(//input[@type='password'])[1]"));

        IWebElement clickSignin => driver.FindElement(By.XPath("(//input[@type='submit'])[1]"));

        IWebElement loggedIn => driver.FindElement(By.XPath("//div[@style='top: 0;']"));

        IWebElement profileName => driver.FindElement(By.XPath("(//span[text()='bash abimbola'])[1]"));

        IWebElement logOut => driver.FindElement(By.XPath("(//a[text()='Logout'])[1]"));

        IWebElement loggedOut => driver.FindElement(By.XPath("//span[text()='Remember me']"));

        IWebElement community => driver.FindElement(By.XPath("(//span[text()='Community'])[1]"));

        IWebElement communitiesPage => driver.FindElement(By.XPath("(//p[text()='Explore communities you interested in joining'])[1]"));

        IWebElement search => driver.FindElement(By.CssSelector("body > div.wrapper > header.header.header-transparent.lnk-others.header-fullwidth.header-style-1.hide > div > div.container-fluid > div > div.col-xl-5.col-lg-4.col-md-9.col-8 > ul > li.mr--10 > a > span > i"));

        IWebElement itemsDisplaced => driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div"));


        public void ShouldBeLoggedIn()
        {
            Assert.IsTrue(loggedIn.Displayed);
        }

        public void ItemsShouldBeDisplayed()
        {
            Assert.IsTrue(itemsDisplaced.Displayed);
        }


        public void ClickOnSearch()
        {
            search.Click();
        }

        public void CommunitiesShouldBeDisplayed()
        {
            Assert.IsTrue(communitiesPage.Displayed);
        }


        public void ClickOnCommunity()
        {
            community.Click();

        }


        public void BeLoggedOut()
        {
            Assert.IsTrue(loggedOut.Displayed);
        }

        public void ClickOnLogout()
        {
            logOut.Click();
        }


        public void ClickOnYourProfileName()
        {
            profileName.Click();
        }



        public void ClickSignin()
        {
            clickSignin.Click();
        }

        public void MyPassword(string pwd)
        {
            password.SendKeys(pwd);
        }

        public void MyEmailAddress(string email)
        {
            emailAddress.SendKeys(email);
        }


        public void ClickOnSigninButton()
        {
            signIn.Click();
        }


        public void NavigateToGiftreteWebsite(string Url)
        {

            driver.Navigate().GoToUrl(Url);
        }





        public Loginpages()
        {
            driver = Hook.driver;
        }
       


    }
}
