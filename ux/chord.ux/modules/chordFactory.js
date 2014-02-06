// Factory
chordApp.factory('chordFactory', function($http){
    return {
        getChord: function(chordName, callback){
            return $http.get('http://localhost:12008/chord/'+chordName).success(callback).error(function(){
                // there was not a template for this url - set the default one
                $scope.templateUrl = '';
            });
        },
        getChordStack: function(stackSize, callback){
            return $http.get('http://localhost:12008/chordStack/'+stackSize).success(callback);
        }
    }
});