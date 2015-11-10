(function() {

	"use strict;"

	angular.module("app.widgets")
		.directive("suggestedRoutes", suggestedRoutes);

	function suggestedRoutes() {
		return {
			bindToController: true,
			controller: ["$http", suggestedRoutesCtrl],
			controllerAs: "vm",
			replace: true,
			restrict: "EA",
			templateUrl: "app/widgets/suggestedRoutes.html",
			scope: {routes: "="}
		}

		function suggestedRoutesCtrl($http) {
			var vm = this;
			vm.toggleExpansion = toggleExpansion;

			///////////////////
			

			function init() {

			}

			function toggleExpansion(route) {
				angular.forEach(vm.routes, function(routeC) {
					routeC.expanded = false;
				});
				if(route.expanded) {
					route.expanded = false;
				}
				else {
					route.expanded = true;
				}

			}
		}
	}
})();