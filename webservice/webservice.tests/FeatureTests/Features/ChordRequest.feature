Feature: ChordRequest
	In order to show chords to my users
	As an api user
	I want to be given data versions of guitar chords

Scenario: Request an existing chord
	Given the chord "C" exists in the chord database
	When I request the chord "C" from the api
	Then the representation for the "C" chord should be returned by the api

Scenario: Request a chord that does not exist
	Given the chord "C" does not exist in the chord database
	When I request the chord "C" from the api
	Then a 404 should be returned from the api