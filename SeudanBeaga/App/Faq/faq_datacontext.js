(function () {
    "use strict";

    var serviceId = "faq_datacontext";
    angular.module("sbApp")
        .factory(serviceId, ["$http", "_apiUrl", faq_datacontext]);

    function faq_datacontext($http, _apiUrl) {

        var factory = {
            getFaq: getFaq
        };


        return factory;

        function getFaq() {

            var url = _apiUrl + 'Faq/GetAll';

            return $http.get(url);
        }
    }
})();