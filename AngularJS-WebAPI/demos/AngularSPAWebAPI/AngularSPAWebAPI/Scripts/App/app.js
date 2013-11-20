var app = app || {};
app.core = angular.module("app", [])
    .config(['$routeProvider', '$locationProvider',
        function ($routeProvider, $locationProvider) {
            $routeProvider
                .when('/',
                {
                    templateUrl: '/templates/home/index',
                    controller: 'controllers.home'
                })
                .otherwise({ redirectTo: '/' });

            $locationProvider.html5Mode(true);

        }]);

app.core.run(['$rootScope', '$templateCache',
    function ($rootScope, $templateCache) {
        $rootScope.$on('$viewContentLoaded', function () {
            $templateCache.removeAll();
        });
    }]);
    