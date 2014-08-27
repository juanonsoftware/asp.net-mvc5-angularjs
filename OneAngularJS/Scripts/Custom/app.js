(function () {
    var app = angular.module('MMM', []);

    app.controller("CategoryController", ['$http', function ($http) {
        var category = this;
        category.categories = [];

        $http.get('/api/Category').success(function (data) {
            category.categories = data;
        });
    }]);
})();
