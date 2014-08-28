(function () {
    var app = angular.module('MMM', []);

    //app.config('$routeProvider', function ($routeProvider) {
    //    $routeProvider.when('/Category/Add', {
    //        templateUrl: 'Category/AddNewCategory.html',
    //        controller: 'AddNewCategoryController'
    //    });
    //});

    app.controller("CategoryController", ['$http', function ($http) {
        var controller = this;

        this.loadCategories = function () {
            $http.get('/api/Category').success(function (data) {
                controller.categories = data;
            });
        };

        this.addCategory = function () {
            $http.post('/api/Category', controller.category).success(function (data) {
                controller.categories.push(controller.category);
                controller.category = {};
            });
        };

        this.resetCategories = function () {
            controller.categories = [];
            controller.category = {};
        };

        this.resetCategories();
        this.loadCategories();
    }]);
})();
