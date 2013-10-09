// declare a module
var chordApp = angular.module('chordApp', []);

chordApp.config(function($httpProvider){
        delete $httpProvider.defaults.headers.common['X-Requested-With'];
    });

function ChordCtrl($scope,chordFactory) {
    $scope.getChordStack = function(stackSize){
        chordFactory.getChordStack(stackSize, function(data){
                $scope.chordStack = data.Stack;
            }
        );
    },
    $scope.getChord = function(chordName){
        chordFactory.getChord(chordName, function(data){
                $scope.chordName = data.Name;
                $scope.fingerings = data.Fingerings;
                $scope.frets = [0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18];
            }
        );
    }
}