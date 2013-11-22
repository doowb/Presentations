app.core.factory('services', ['$http',
  function ($http) {
      var callApi = function (url, data, success, error, requestType) {
          if (requestType) {
              $http({ url: url, data: data, method: requestType })
              .success(success)
              .error(error);

              return;
          }

          $http.post(url, data)
              .success(success)
              .error(error);
      };

      return {
          callApi: callApi
      };
  }
]);
