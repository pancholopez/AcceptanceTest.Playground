Feature: My Example

A short summary of the feature

@Search
Scenario: This is one scenario example
	Given Given a navigate to "www.google.com"
	When I click in the search bar
	And I type "pokemon" in the search box
	And I click on the search button
	Then I should get redirected to a search result page
