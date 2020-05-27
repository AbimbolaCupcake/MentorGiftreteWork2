
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
	

@mytag
Scenario: Logout
	Given I am on the login page
	When I click on your profile name
	And I click on logout
	Then I should be logged out

Scenario: CommunityPage
	Given I click on Community                  
	Then Communities should be displayed    
	When I click on your profile name
	And I click on logout
	Then I should be logged out


Scenario: Searchpage
	Given I click on Search 
	Then all items should be displayed 
	When I click on your profile name
	And I click on logout
	Then I should be logged out

