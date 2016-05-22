(function () {
    "use strict";

    var serviceId = "main_datacontext";
    angular.module("sbApp")
        .factory(serviceId, ["$http","_apiUrl", main_datacontext]);

    function main_datacontext($http, _apiUrl) {

        var factory = {
            getHolidays: getHolidays
        };

        
        return factory;

        function getHolidays()
        {
            var url = _apiUrl + 'Holidays/GetActive';
            return $http.get(url);
        }
    }
})();