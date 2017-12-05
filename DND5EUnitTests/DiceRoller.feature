﻿Feature: DiceRoller
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