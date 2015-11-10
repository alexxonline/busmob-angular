(function () {

	"use strict";

	angular.module("app.widgets")
		.directive("routePart", routePart);

	function routePart() {
		return {
			bindToController: true,
			controller: [routePartCtrl],
			controllerAs: "vm",
			replace: true,
			restrict: "EA",
			scope: {part: "="},
			templateUrl: "app/widgets/routePart.html"
		}

		function routePartCtrl() {
			var vm = this;
		}
	}
})();