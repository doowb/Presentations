app.core.factory('productData', ['services',
  function (services) {
      return {
          create: function (product, success, error) {
              services.callApi('/api/product', product, success, error, 'POST');
          },
          getById: function (id, success, error) {
              services.callApi('/api/product', { id: id }, success, error, 'GET');
          },
          getAll: function (success, error) {
              services.callApi('/api/product', { }, success, error, 'GET');
          },
          save: function (product, success, error) {
              services.callApi('/api/product', product, success, error, 'PUT');
          },
          remove: function (id, success, error) {
              services.callApi('/api/product', { id: id }, success, error, 'DELETE');
          },
      };
  }
]);
