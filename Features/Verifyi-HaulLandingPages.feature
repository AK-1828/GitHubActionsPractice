Feature: verify i-Haul landing pages

A short summary of the feature

 Scenario Outline: Verify text is displayed on each landing page
    Then "<pageText>" page is displayed

    Examples:
      | pageText                   |
      | Welcome to i-Haul!         |
      | Simple and Convenient      |
      | Safe and Secure Payment    |
