(function () {
    "use strict";

    var serviceId = "contact_datacontext";
    angular.module("sbApp")
        .factory(serviceId, ["$http", "_apiUrl", contact_datacontext]);

    function contact_datacontext($http, _apiUrl) {

        var factory = {
            getContactDetails: getContactDetails
        };

        return factory;

        function getContactDetails() {

            var url = _apiUrl + 'Contacts/GetAll';

            return $http.get(url);
        }
    }
})();