(function () {
    "use strict";

    var controllerId = "faqController";
    angular.module("sbApp")
        .controller(controllerId, ["faq_datacontext", faqController]);

    function faqController(faq_datacontext) {

        var vm = this;
        vm.faqs = null;

        vm.getFaq = getFaq;

        function getFaq() {
            faq_datacontext.getFaq().then(function (response) {
                vm.faqs = response.data;
            });
        }
    }
})();