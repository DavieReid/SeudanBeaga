(function () {
    "use strict";

    var serviceId = "faq_datacontext";
    angular.module("sbApp")
        .factory(serviceId, ["$http", faq_datacontext]);

    function main_datacontext($http) {

        var factory = {
            getFaq: getFaq
        };


        return factory;

        function addNavigation(alarmId, description, customerName, assetName) {

            var navHistoryArray = [];

            //retrieve the cookie
            if ($cookies.alarmNavHistory === undefined) {
                navHistoryArray = [];
            } else {
                var data = $cookies.alarmNavHistory;
                navHistoryArray = angular.fromJson(data);
            }

            //new historical ref
            var historyObj = {
                alarmId: alarmId,
                description: description,
                visited: new Date(),
                customer: customerName,
                asset: assetName
            };
            //delete duplicates
            var result = $.grep(navHistoryArray, function (e) { return e.alarmId == alarmId; });
            if (result.length > 0) {
                var i = 0;
                for (i; i < result.length; i++) {
                    var index = navHistoryArray.indexOf(result[i]);
                    navHistoryArray.splice(index, 1);
                }
            }

            //more than 10 entries - delete last item
            if (navHistoryArray.length === 8) {
                navHistoryArray.pop();
            }

            //add the new entry
            navHistoryArray.unshift(historyObj);
            this.data = navHistoryArray;

            $cookies.alarmNavHistory = angular.toJson(navHistoryArray);
            $rootScope.$broadcast("historyUpdate", navHistoryArray);
        }
    }
})();