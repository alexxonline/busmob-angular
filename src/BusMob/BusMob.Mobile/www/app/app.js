(function() {

	"use strict";

	angular.module("app", [

		"ngAnimate",
		"ngRoute",
		"app.home",
		"app.journey",
		"app.widgets"])
    .config(function ($compileProvider) {
        $compileProvider.aHrefSanitizationWhitelist(/^\s*(https?|ftp|mailto|file|tel):/);
    });

})();