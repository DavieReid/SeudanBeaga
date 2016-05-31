(function () {
    "use strict";

    var controllerId = "galleryController";
    angular.module("sbApp")
        .controller(controllerId, ["gallery_datacontext", galleryController]);

    function galleryController(gallery_datacontext) {

        var vm = this;
        vm.photos = null;

        vm.getPhotos = getPhotos;


        function getPhotos() {
            if (vm.photos === null) {
                gallery_datacontext.getGallery().then(function (response) {
                    vm.photos = response.data;
                });
            }             
        }
    }
})();