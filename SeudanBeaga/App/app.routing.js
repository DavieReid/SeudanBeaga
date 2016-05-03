function config($stateProvider, $urlRouterProvider) {

    $urlRouterProvider.otherwise(function ($injector, $location) {
        var $state = $injector.get("$state");
        $state.go("home");
    });

   
    $stateProvider
        .state('home', {
            url: "/index",
            templateUrl: "../App/Main/main.html"
        })
        .state('about', {
            url: "/about",
            templateUrl: "App/About/about.html",
        })
        .state('prices', {
            url: "/prices",
            templateUrl: "App/Prices/prices.html",
        })
        .state('gallery', {
            url: "/gallery",
            templateUrl: "App/Gallery/gallery.html",
        })
        .state('faq', {
            url: "/faq",
            templateUrl: "App/Faq/faq.html",
        })
        .state('contact', {
            url: "/contact",
            templateUrl: "App/Contact/contact.html",
        });

    return {
        appErrorPrefix: '[Error] ',
        version: '1.0'
    };
}
angular
    .module('sbApp')
    .config(config)
    .run(function ($rootScope, $state) {
        $rootScope.$state = $state;
    });
