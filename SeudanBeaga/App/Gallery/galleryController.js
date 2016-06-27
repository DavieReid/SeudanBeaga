(function () {
    "use strict";

    var controllerId = "galleryController";
    angular.module("sbApp")
        .controller(controllerId, ["$uibModal", "gallery_datacontext", galleryController]);

    function galleryController($uibModal, gallery_datacontext) {

        var vm = this;
        vm.photos = null;
        vm.currentPage = 1;
        vm.itemsPerPage = 10;

        //methods
        vm.getPhotos = getPhotos;
        vm.paginationOption_OnChange = paginationOption_OnChange;

        vm.paginationOptions = [
                        { value: "", label: "All photos" },
                        { value: "5", label: "5 per page" },
                        { value: "10", label: "10 per page" },
                        { value: "20", label: "20 per page" },
                        { value: "30", label: "30 per page" }
        ];

        vm.selectedItemsPerPage = vm.paginationOptions[2];

        function paginationOption_OnChange(option) {
            if (vm.itemsPerPage !== vm.selectedItemsPerPage.value) {
                vm.itemsPerPage = vm.selectedItemsPerPage.value;
            }
        }


        function getPhotos() {
            if (vm.photos === null) {
                gallery_datacontext.getGallery().then(function (response) {
                    vm.photos = response.data;
                });
            }
        }
    }

})();