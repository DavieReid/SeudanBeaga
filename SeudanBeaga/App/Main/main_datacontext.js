(function () {
    "use strict";

    var serviceId = "main_datacontext";
    angular.module("sbApp")
        .factory(serviceId, ["$http", main_datacontext]);

    function main_datacontext($http) {

        var factory = {
            getHolidays: getHolidays
        };

        
        return factory;

        function getHolidays()
        {
            var url = _apiUrl + 'Holidays/Get';
            return $http.get(url);
        }
    }
})();