(function () {
    var app = angular.module('MMM', []);

    //app.config('$routeProvider', function ($routeProvider) {
    //    $routeProvider.when('/Category/Add', {
    //        templateUrl: 'Category/AddNewCategory.html',
    //        controller: 'AddNewCategoryController'
    //    });
    //});

    app.controller("CategoryController", ['$http', function ($http) {
        var category = this;

        this.loadCategories = function () {
            $http.get('/api/Category').success(function (data) {
                category.categories = data;
            });
        };

        this.resetCategories = function () {
            category.categories = [];
        };

        this.resetCategories();
        this.loadCategories();
    }]);

    app.controller("AddCategoryController", ['$http', function ($http) {
        var controller = this;

        this.resetCategory = function () {
            controller.category = {};
        }

        this.addCategory = function () {
            $http.post('/api/Category', controller.category).success(function(data) {
                controller.resetCategory();
            });
        };

        controller.resetCategory();
    }]);
})();
