// declare a module
var chordApp = angular.module('chordApp', []);

chordApp.config(function($httpProvider){
        delete $httpProvider.defaults.headers.common['X-Requested-With'];
    });

function ChordCtrl($scope,chordFactory) {
    $scope.getChord = function(chordName){
        chordFactory.getChord(chordName, function(data){
                $scope.chordName = data.Name;
                $scope.fingerings = data.Fingerings;
            }
        );
    }
}