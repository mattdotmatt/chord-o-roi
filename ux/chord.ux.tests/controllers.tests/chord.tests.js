/**
 * User: myoung
 * Date: 03/05/13
 * Time: 13:27
 */

describe("Chords", function () {
    "use strict";
    it("gets a chord fron the factory", function() {
        var mockChordFactory = jasmine.createSpyObj('chordFactory', [ 'getChord' ]);
        mockChordFactory.getChord.andCallFake(function(chordName) {
            return 'C';
        });
        var scope = {},
            ctrl = new ChordCtrl(scope,mockChordFactory);
        expect(scope.getChord('C')).toBe('C');
    });
});