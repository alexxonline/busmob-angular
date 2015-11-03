(function() {

	"use strict;"

	angular.module("app.widgets")
		.directive("suggestedRoutes", suggestedRoutes);

	function suggestedRoutes() {
		return {
			controller: ["$http", suggestedRoutesCtrl],
			controllerAs: "vm",
			replace: true,
			restrict: "EA",
			templateUrl: "app/widgets/suggestedRoutes.html"
		}

		function suggestedRoutesCtrl($http) {
			var vm = this;
			vm.toggleExpansion = toggleExpansion;

			///////////////////
			vm.routes = [{
					start: "17:54",
					end: "18:27",
					totalTime: 33,
					walkDistance: 342,
					parts: [{name: "Empezar viaje en ubicación actual",
						time: "17:54",
						instruction: "Andar a destino Maestro Vidal 127",
						type: "walk",
						distance: 113,
						duration: 1
						},
						{
							name: "Maestro Vidal 127",
							time: "17:54",
							instruction: "Tomar el colectivo 600 de autobuses Santa Fé",
							type: "bus",
							distance: 9,
							duration: 8,
							additional: "Manuel Quintana 1413"			
						},
						{
							name: "Manuel Quintana 1423",
							time: "17:54",
							instruction: "Andar a destino Joaquin Furiel 2134",
							type: "walk",
							distance: 413,
							duration: 22
						}]
			}, 
			{
				start: "17:42",
				end: "18:22",
				totalTime: 33,
				walkDistance: 344,
					parts: [{name: "Empezar viaje en ubicación actual",
					time: "17:54",
					instruction: "Andar a destino Colón 122",
					type: "walk",
					distance: 210,
					time: 12},
					{
						name: "Manuel Quintana 1423",
						time: "17:54",
						instruction: "Andar a destino Joaquin Furiel 2134",
						type: "walk",
						distance: 413,
						time: 22
					}]
			}];

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