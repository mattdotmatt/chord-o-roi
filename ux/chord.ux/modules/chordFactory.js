// Factory
chordApp.factory('chordFactory', function($http){
    return {
        getChord: function(chordName, callback){
            return $http.get('http://localhost:12008/chord/'+chordName).success(callback);
        }
    }
});