(function () {

	"use strict";

	angular.module("app.journey")
		.factory("journeyService", journeyService);

	journeyService.$inject = ["$http"];
	function journeyService($http) {
		return {
			get: get
		}

		function get(datos) {
			if(!datos.fechaSalida) {
				datos.fechaSalida = "";
			}
			else {
				datos.fechaSalida = datos.fechaSalida.toLocaleString();
			}

			if(!datos.fechaLlegada) {
				datos.fechaLlegada = "";
			}
			else {
				datos.fechaLlegada = datos.fechaLlegada.toLocaleString();
			}
			
			var url = "http://localhost:51972/api/trayectos?origen="+ datos.origen + "&destino=" + datos.destino + "&fechaSalida=" + datos.fechaSalida + "&fechaLlegada=" + datos.fechaLlegada;

			return $http.get(url)
				.then(function (data) {
					return data;
				})
				.catch(function(data) {
				
				})
		}
	}
})();