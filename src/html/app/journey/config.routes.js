(function() {

	"use strict";

	angular.module("app.journey")
		.config(configureRoutes);

	configureRoutes.$inject = ["$routeProvider"];
	
	function configureRoutes($routeProvider) {
		$routeProvider.when("/journey", {
			templateUrl: "app/journey/CalculateSuggested.html",
			controller: "CalculateSuggested",
			controllerAs: "vm"
		})
	}

})();