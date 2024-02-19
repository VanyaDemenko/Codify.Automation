@Smoke
Feature: Login to the Codify

Login to the Codify

@Critical
Scenario: 01 User can login to the Codify
	Given I login as a 'Admin' user to the Codify
	Then The Codify page is loaded

@Critical
Scenario: 02 User cannot login to the Codify without password
	Given I login as a 'Admin' user to the Codify without password
	Then The Error Message with value 'Error' is displayed 

@Critical
Scenario: 03 User can login to the Codify without login
	Given I login as a 'Admin' user to the Codify without login
	Then The Error Message with value 'Error' is displayed