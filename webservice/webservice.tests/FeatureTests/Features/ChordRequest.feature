Feature: ChordRequest
	In order to show chords to my users
	As an api user
	I want to be given data versions of guitar chords

Scenario: Request an existing chord
	Given the chord "C" exists in the chord database
	When I request the chord "C" from the api
	Then the following representation for the "C" chord should be returned by the api:
	| Fret | String |
	| 0    | B      |
	| 1    | D      |
	| 2    | A      |

Scenario: Request a chord that does not exist
	Given the chord "C" does not exist in the chord database
	When I request the chord "C" from the api
	Then a 404 should be returned from the api