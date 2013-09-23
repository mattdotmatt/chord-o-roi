// Factory
chordApp.factory('chordFactory', function($http){
    return {
        getChord: function(chordName){
            return 'C';
            /*
            $http({method: 'GET', url: '/someUrl'}).
                success(function(data, status, headers, config) {
                    // this callback will be called asynchronously
                    // when the response is available
                }).
                error(function(data, status, headers, config) {
                    // called asynchronously if an error occurs
                    // or server returns response with an error status.
                });
              */
        }
    }
});