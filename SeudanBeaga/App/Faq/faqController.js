(function () {
    "use strict";

    var controllerId = "faqController";
    angular.module("sbApp")
        .controller(controllerId, ["faq_datacontext", faqController]);

    function faqController(faq_datacontext) {

        var vm = this;
        vm.faq = null;

        //main
        vm.getFaq();

        vm.getFaq = getFaq;

        function getFaq() {
            faq_datacontext.getFaq().then(function (response) {
                vm.faq = response.data;
            });
        }
    }
})();