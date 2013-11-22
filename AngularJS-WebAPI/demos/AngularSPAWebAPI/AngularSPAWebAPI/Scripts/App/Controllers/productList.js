app.core.controller('controllers.product.list', ['$scope', 'productData',
    function ($scope, productData) {
        $scope.products = [];

        productData.getAll(
            function(products) {
                $scope.products = products;
            },
            function (error) {
                console.log(error);
                alert(error.Message);
            }
        );
    }
]);
