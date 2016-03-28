(function () {
    "use strict";

    var controllerId = "mainController";
    angular.module("sbApp")
        .controller(controllerId, ["main_datacontext", mainController]);

    function mainController($http) {

        var vm = this;

        vm.title = "Seudan Beaga";


       
    }
})();