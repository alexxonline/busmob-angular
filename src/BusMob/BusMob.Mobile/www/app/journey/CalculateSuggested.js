(function() {

	"use strict";

	angular.module("app.journey")
		.controller("CalculateSuggested", CalculateSuggested);

	CalculateSuggested.$inject = ["journeyService"];
	function CalculateSuggested(journeyService) {
		var vm = this;
		vm.busqueda = {};
		vm.buscar = search;
		vm.showForm = true;
		vm.messageManager = {};
		init();

		////////////////////////////////////
		function init() {
			vm.busqueda.fechaSalida = new Date();
		}


		function search() {
			if(validateForm()) {
				
				journeyService.get(vm.busqueda)
					.then(function (data) {
						vm.showForm = false;
						vm.routes = data.data;
					})
					.catch(function() {
						alert("Ha ocurrido un error.");
					});
			}
		}

		function validateForm() {
			if(vm.busqueda.origen == null || vm.busqueda.origen == "") {
				vm.messageManager.show("Debe ingresar una ubicación de salida.");
				return false;
			}

			if(vm.busqueda.destino == null || vm.busqueda.destino == "") {
				vm.messageManager.show("Debe ingresar una ubicación de llegada.");
				return false;
			}

			if(vm.busqueda.fechaSalida == null && vm.busqueda.fechaLlegada == null)
			{
				vm.messageManager.show("Debe ingresar al menos una fecha.");
				return false;
			} 	

			if(containsWord("florencia", vm.busqueda.origen) ||
				containsWord("florencia", vm.busqueda.destino) ||
				containsWord("cecilia", vm.busqueda.origen) ||
				containsWord("cecilia", vm.busqueda.destino) || 
				containsWord("judith", vm.busqueda.origen) || 
				containsWord("judith", vm.busqueda.destino))
			{
				vm.messageManager.show("Ha ingresado calles que no se encuentran en la ciudad actual.");
				return false;
			}

			return true;
		}

		function containsWord(word, variable) {
			if(variable.toLowerCase().indexOf(word) != -1) 
			{
				return true;
			}
			return false;
		}
	}
})();	