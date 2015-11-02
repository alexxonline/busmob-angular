(function() {

	"use strict";

	angular.module("app.widgets")
		.directive("busMenu", busMenu);

	function busMenu() {
		return {
			controller: ["$scope", "$route", busMenuCtrl],
			controllerAs: "vm",
			replace: true,
			restrict: "EA",
			templateUrl: "app/widgets/busMenu.html"
		}

		function busMenuCtrl($scope, $route) {
			var vm = this;
			vm.current = "";
			$scope.$on("$routeChangeSuccess", function(ev, current) { 
		   		vm.current = current.$$route.originalPath;
			 });
		}
	}
})();