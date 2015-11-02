(function() {

	"use strict";

	angular.module("app.home")
		.config(configureRoutes);

	configureRoutes.$inject = ["$routeProvider"];

	function configureRoutes($routeProvider) {
		$routeProvider.when("/", {
			templateUrl: "app/home/home.html",
			controller: "HomeCtrl",
			controllerAs: "vm"
		})
		.when("/favs", {
			templateUrl: "app/home/favs.html",
			controller: "FavsCtrl",
			controllerAs: "vm"
		})
		.otherwise({redirectTo: "/"});
	}

})();