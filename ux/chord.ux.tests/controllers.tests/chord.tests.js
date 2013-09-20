/**
 * User: myoung
 * Date: 03/05/13
 * Time: 13:27
 */

describe("Chords", function () {
    "use strict";
    it("uses a date range based around the birthday", function() {
        var scope = {},
            ctrl = new ChordCtrl(scope);
        expect(scope.getChord()).toBe('C');
    });
});