// Factory
chordApp.factory('chordFactory', function($http){
    return {
        getChord: function(chordName, callback){
            return $http.get('http://localhost:12008/chord/'+chordName).success(callback);
        },
        getChordStack: function(stackSize, callback){
            return $http.get('http://localhost:12008/chordStack/'+stackSize).success(callback);
        }
    }
});