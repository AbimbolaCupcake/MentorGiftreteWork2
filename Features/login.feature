
Feature: login
	in order to use my account 
	As a register user 
	I need to sign in

Background: 
	Given I navigate to giftrete website "https://www.qa.giftrete.com/"
	And I click on Signin button
	And I enter my Email Address"aaransiola@yahoo.com"
	And I enter my Password"mysecurepassword"
	And I click Signin
	Then I should be logged in

@mytag
Scenario: Logout
	Given I am on the login page
	When you click on your profile name
	And you click on logout
	Then you should be logged out

Scenario: CommunityPage
	Given you click on Community                  
	Then Communities should be displayed    
	When you click on your profile name
	And you click on logout
	Then you should be logged out


Scenario: Searchpage
	Given you click on Search 
	Then all items should be displayed 
	When you click on your profile name
	And you click on logout
	Then you should be logged out

