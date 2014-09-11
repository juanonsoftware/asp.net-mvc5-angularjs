(function () {
    var app = angular.module('MMM', []);

    //app.config('$routeProvider', function ($routeProvider) {
    //    $routeProvider.when('/Category/Add', {
    //        templateUrl: 'Category/AddNewCategory.html',
    //        controller: 'AddNewCategoryController'
    //    });
    //});

    app.controller("CategoryController", ['$scope', '$http', function ($scope, $http) {
        $scope.loadCategories = function () {
            $http.get('/api/Category').success(function (data) {
                $scope.categories = data;
            });
        };

        $scope.addCategory = function () {
            $http.post('/api/Category', $scope.category).success(function (data) {
                $scope.categories.push($scope.category);
                $scope.category = {};
            });
        };

        $scope.search = function () {
            $http({
                url: '/api/Category',
                method: 'GET',
                params: { 'query': $scope.query }
            }).success(function (data, status) {
                $scope.categories = data;
            });
        };

        $scope.resetCategories = function () {
            $scope.categories = [];
            $scope.category = {};
            $scope.query = '';
        };

        $scope.resetCategories();
        $scope.loadCategories();
    }]);
})();
