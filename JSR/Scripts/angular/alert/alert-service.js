// Generated by CoffeeScript 1.7.1
(function() {
  var module;

  module = angular.module('app');

  module.factory('demoService', [
    'BASE_WEB_API', '$http', '$q', function(BASE_WEB_API, $http, $q) {
      var getAlerts;
      getAlerts = function() {
        return $http.get("" + BASE_WEB_API + "/alerts").then(function(response) {
          return response.data;
        }, function(errorResponse) {
          throw {
            status: errorResponse.status,
            message: errorResponse.data.Message
          };
        });
      };
      return {
        getAlerts: getAlerts
      };
    }
  ]);

}).call(this);