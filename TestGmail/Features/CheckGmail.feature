Feature: CheckGmailFeature
  As a user of gmail
  I should be able sign-in in existing account
  And check for existing email	


Scenario: Check Gmail letter
   Given I turn on GMAIL
	When I login using "valid" credentials
	Then I am on the gmail home page
	 And I see more Emails then 0 on the gmail home page
	