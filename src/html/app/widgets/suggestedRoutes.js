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

			vm.routes = [{
					start: "17:54",
					end: "18:27",
					totalTime: 33,
					walkDistance: 342,
					sub: [{name: "Empezar viaje en ubicación actual",
						instruction: "Andar a destino Maestro Vidal 127",
						type: "walk",
						distance: 113,
						time: 1
						},
						{
							name: "Maestro Vidal 127",
							instruction: "Tomar el colectivo 600 de autobuses Santa Fé",
							type: "bus",
							distance: 9,
							time: 8,
							additional: "Manuel Quintana 1413"			
						},
						{
							name: "Manuel Quintana 1423",
							instruction: "Andar a destino Joaquin Furiel 2134",
							type: "walk",
							distance: 413,
							time: 22
						}]
			}, 
			{
				start: "17:42",
				end: "18:22",
				totalTime: 33,
				walkDistance: 344,
					sub: [{name: "Empezar viaje en ubicación actual",
					instruction: "Andar a destino Colón 122",
					type: "walk",
					distance: 210,
					time: 12},
					{
						name: "Manuel Quintana 1423",
						instruction: "Andar a destino Joaquin Furiel 2134",
						type: "walk",
						distance: 413,
						time: 22
					}]
			}];
		}
	}
})();