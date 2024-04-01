Feature: Purchase Product on Amazon
    As a user
    I want to be able to purchase a product on Amazon
    So that I can buy the desired item

Scenario: Successful Product Purchase
    Given I am on the Amazon homepage
    When I search for a product
    And I select a product from the search results
    And I add the product to the cart
    And I proceed to the checkout page
    And I complete the purchase
    Then I should see the purchase confirmation page