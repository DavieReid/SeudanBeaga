(function () {
    "use strict";

    var controllerId = "contactController";
    angular.module("sbApp")
        .controller(controllerId, ["NgMap", "contact_datacontext", contactController]);

    function contactController(NgMap, contact_datacontext) {

        var vm = this;
        vm.contacts = null;

        NgMap.getMap().then(function (m) {
            vm.map = m;
            vm.lat = 55.8220413970829;
            vm.lng = -4.262115028231278;
            vm.zoom = 17;
            vm.mapTypeId =google.maps.MapTypeId.ROADMAP;
        });

        vm.getContacts = getContacts;

        function getContacts() {
            contact_datacontext.getContactDetails().then(function (response) {
                vm.contacts = response.data;
            });
        }




        
    }
})();