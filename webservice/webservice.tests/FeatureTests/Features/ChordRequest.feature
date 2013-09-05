Feature: ChordRequest
	In order to verify I know my chords
	As a guitar player
	I want to be shown pictorial representations of chords I have requested

Scenario: Request an existing chord
	Given the chord "C" exists in the chord database
	When I request the chord "C" from the api
	Then the image for the "C" chord should be returned by the api

Scenario: Request a chord that does not exist
	Given the chord "C" does not exist in the chord database
	When I request the chord "C" from the api
	Then a 404 should be returned from the api