angular.module('app', ['ui.router', 'ngResource', 'LocalStorageModule']).config(function ($stateProvider, $urlRouterProvider) {

    $urlRouterProvider.otherwise('/login');

    $stateProvider
        .state('login', { url: '/login', templateUrl: '/templates/authentication/login.html', controller: 'LoginController' })
        .state('register', { url: '/register', templateUrl: '/templates/authentication/register.html', controller: 'RegisterController' })

        .state('app', { url: '/app', templateUrl: '/templates/app/app.html', authenticate: true, controller: 'AppController' })
        .state('app.dashboard', { url: '/dashboard', templateUrl: '/templates/app/dashboard/dashboard.html', authenticate: true })

        .state('app.property', { abstract: true, url: '/property', template: '<ui-view />', authenticate: true })
            .state('app.property.grid', { url: '/grid', templateUrl: '/templates/app/property/grid.html', controller: 'PropertyGridController', authenticate: true })
            .state('app.property.detail', { url: '/detail/:id', templateUrl: '/templates/app/property/detail.html', controller: 'PropertyDetailController', authenticate: true })

        .state('app.tenant', { abstract: true, url: '/tenant', template: '<ui-view />', authenticate: true })
            .state('app.tenant.grid', { url: '/grid', templateUrl: '/templates/app/tenant/grid.html', controller: 'TenantGridController', authenticate: true })
            .state('app.tenant.detail', { url: '/detail/:id', templateUrl: '/templates/app/tenant/detail.html', controller: 'TenantDetailController', authenticate: true })

        .state('app.lease', { abstract: true, url: '/lease', template: '<ui-view />', authenticate: true })
            .state('app.lease.grid', { url: '/grid', templateUrl: '/templates/app/lease/grid.html', controller: 'LeaseGridController', authenticate: true })
            .state('app.lease.detail', { url: '/detail/:id', templateUrl: '/templates/app/lease/detail.html', controller: 'LeaseDetailController', authenticate: true });

});
angular.module('app').value('apiUrl', 'http://localhost:63338/api/');