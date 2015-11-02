(function() {

	"use strict";

	angular.module("app.journey")
		.controller("CalculateSuggested", CalculateSuggested);

	function CalculateSuggested() {
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
				vm.showForm = false;
			}
		}

		function validateForm() {
			if(vm.busqueda.desde == null || vm.busqueda.desde == "") {
				vm.messageManager.show("Debe ingresar una ubicación de salida.");
				return false;
			}

			if(vm.busqueda.hasta == null || vm.busqueda.hasta == "") {
				vm.messageManager.show("Debe ingresar una ubicación de llegada.");
				return false;
			}

			if(vm.busqueda.fechaSalida == null && vm.busqueda.fechaLlegada == null)
			{
				vm.messageManager.show("Debe ingresar al menos una fecha.");
				return false;
			} 	

			if(containsWord("florencia", vm.busqueda.desde) ||
				containsWord("florencia", vm.busqueda.hasta) ||
				containsWord("cecilia", vm.busqueda.desde) ||
				containsWord("cecilia", vm.busqueda.hasta) || 
				containsWord("judith", vm.busqueda.desde) || 
				containsWord("judith", vm.busqueda.hasta))
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