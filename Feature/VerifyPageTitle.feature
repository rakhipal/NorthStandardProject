Feature: ValidateSelenium

@regression
Scenario: Check page title
Given I have set the chrome driver
When I navigate to the page url "https://www.selenium.dev/"
Then the page title should be "Selenium" 