/**
 * User: myoung
 * Date: 03/05/13
 * Time: 13:27
 */

describe("Chords", function () {
    "use strict";

    it("gets a chord from the factory", function() {
        var mockChordFactory = jasmine.createSpyObj('chordFactory', [ 'getChord' ]);
        mockChordFactory.getChord.andCallFake(function(chordName,callback) {
            var data = {Name:'C'};
            callback(data);
        });
        var scope = {}, ctrl = new ChordCtrl(scope,mockChordFactory);

        scope.getChord('C');
        expect(scope.chordName).toBe('C');
    });

    it("gets a chord stack from the factory", function() {
        var mockChordFactory = jasmine.createSpyObj('chordFactory', [ 'getChordStack' ]);
        mockChordFactory.getChordStack.andCallFake(function(stackSize,callback) {
            var data = {Stack:['C','D','E']};
            callback(data);
        });
        var scope = {}, ctrl = new ChordCtrl(scope,mockChordFactory);
        scope.getChordStack(10);
        expect(scope.chordStack).toEqual(['C','D','E']);
    });

    it("if a stack exists then getting a chord stack from the factory adds to it", function() {
        var mockChordFactory = jasmine.createSpyObj('chordFactory', [ 'getChordStack' ]);
        mockChordFactory.getChordStack.andCallFake(function(stackSize,callback) {
            var data = {Stack:['C','D','E']};
            callback(data);
        });
        var scope = {}, ctrl = new ChordCtrl(scope,mockChordFactory);
        scope.chordStack = ['A','E'];
        scope.getChordStack(10);
        expect(scope.chordStack).toEqual(['A','E','C','D','E']);
    });

    it("gets next chord off the stack", function() {
    });
    it("takes the current chord off the stack", function() {
    });
    it("replenishes the stack when it nears empty", function() {
    });

});