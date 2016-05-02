(function () {
    "use strict";

    var controllerId = "faqController";
    angular.module("sbApp")
        .controller(controllerId, ["faq_datacontext", faqController]);

    function faqController(faq_datacontext) {

        var vm = this;

        vm.getFaq = getFaq;

        function getFaq()
        {

        }


       
    }
})();