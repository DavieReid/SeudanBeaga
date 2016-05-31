(function () {
    "use strict";

    var serviceId = "gallery_datacontext";
    angular.module("sbApp")
        .factory(serviceId, ["$http", "_apiUrl", gallery_datacontext]);

    function gallery_datacontext($http, _apiUrl) {

        var factory = {
            getGallery: getGallery
        };


        return factory;

        function getGallery() {

            var url = _apiUrl + 'Gallery/Get';

            return $http.get(url);
        }
    }
})();