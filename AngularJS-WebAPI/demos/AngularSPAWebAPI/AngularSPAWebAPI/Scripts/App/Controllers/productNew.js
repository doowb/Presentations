app.core.controller('controllers.product.new', ['$scope', '$location', 'productData',
    function ($scope, $location, productData) {

        $scope.product = new app.models.Product();

        productData.getAll(
            function (products) {
                $scope.products = products;
            },
            function (error) {
                console.log(error);
                alert(error.Message);
            }
        );

        $scope.create = function () {
            productData.create($scope.product,
                function (product) {
                    alert('Product ' + product.Name + ' created.');
                    $location.url('/products/list');
                },
                function (error) {
                    console.log(error);
                    alert(error.Message);
                }
            );
        };
    }
]);
