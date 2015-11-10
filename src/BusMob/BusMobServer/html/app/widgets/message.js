(function () {
	"use strict";

	angular.module("app.widgets")
		.directive("message", message);

	function message() {
		return {
			bindToController: true,
			controller: messageCtrl,
			controllerAs: "vm",
			replace: true,
			restrict: "EA",
			scope: {manager: "="},
			templateUrl: "app/widgets/message.html"
		}

		function messageCtrl() {
			var vm = this;
			vm.manager.show = function (message) {
				vm.message = message;
				$("#messageModal").modal("show");
			}
		}
	}
})();