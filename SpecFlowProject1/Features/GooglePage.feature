Feature: Verify Google Home page functionality 

Background: 
	Given Navigate Google Home Page URL
	And Search Text box should be present and enabled in google home page

Scenario Outline: Search in google page with diffrent -2 parameters
	
	When User serach a course with a <keywordName> tutorials
	And Hit Enter button
	Then All course releated to <KeywordName> tutorials should be present

Example: 
|KeywordName|
|Java       |
|Specflow   |