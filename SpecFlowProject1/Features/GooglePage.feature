Feature: Verify Google Home page functionality 

Scenario: Verify Search Java Tutorials
	Given Navigate Google Home Page URL
	And Search Text box should be present and enabled in google home page
	When User serach a course with a keyword java tutorials
	And Hit Enter button
	Then All course releated to java tutorials should be present

Scenario: Verify Search specflow Tutorials 
	Given Navigate Google Home Page URL
	And Search Text box should be present and enabled in google home page
	When User serach a course with a keyword specflow tutorials
	And Hit Enter button
	Then All course releated to specflow tutorials should be present