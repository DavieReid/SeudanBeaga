(function () {
    "use strict";

    var controllerId = "mainController";
    angular.module("sbApp")
        .controller(controllerId, ["main_datacontext", mainController]);

    function mainController(main_datacontext) {

        var vm = this;
        vm.title = "Seudan Beaga";
        vm.holidays = null;

        vm.getHolidays = getHolidays;

        function activate()
        {
            vm.getHolidays();
        }

        function getHolidays() {
            if (vm.holidays === null) {
                main_datacontext.getHolidays().then(function (response) {
                    vm.holidays = response.data;
                });
            }
        }

        //main
        activate();

       
    }
})();