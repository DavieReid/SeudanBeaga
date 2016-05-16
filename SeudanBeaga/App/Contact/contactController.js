(function () {
    "use strict";

    var controllerId = "contactController";
    angular.module("sbApp")
        .controller(controllerId, ["contact_datacontext", contactController]);

    function contactController(contact_datacontext) {

        var vm = this;
        vm.contacts = null;

        //55.8219397,-4.2642401
        vm.mapOptions = {
            map: {
                center: new google.maps.LatLng(55.8219397, -4.2642401),
                zoom: 17,
                mapTypeId: google.maps.MapTypeId.Satelite
            }
        };

        vm.getContacts = getContacts;

        function getContacts() {
            contact_datacontext.getContactDetails().then(function (response) {
                vm.contacts = response.data;
            });
        }    
    }
})();