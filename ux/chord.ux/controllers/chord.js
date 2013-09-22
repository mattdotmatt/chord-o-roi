// declare a module
var chordApp = angular.module('chordApp', []);

function ChordCtrl($scope,chordFactory) {

    $scope.getChord = function(chordName){
        return chordFactory.getChord(chordName);
    }
}