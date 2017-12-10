Feature: DiceRoller
	As a user
	I want a dice roller
	So that I can play DND

Scenario Outline: ReturnNumberBetweenOneAndSize
	Given I have a Dice Roller
	When I roll a dice with <size> sides
	Then it returns a number between one and <size>

	Examples: 
	| size |
	| 20   |
	| 4    |

Scenario Outline: ReturnNumberBetweenNumberOfDiceAndSizeTimeNumber
	Given I have a Dice Roller
	When I roll <num> dice with <size> sides
	Then it returns a number between <num> and <max>

	Examples: 
	| num | size | max |
	| 2   | 6    | 12  |
	| 3   | 8    | 24  |

Scenario: RollAbilityScore
	Given I have a Dice Roller
	When I roll ability scores
	Then it returns a number between 3 and 18