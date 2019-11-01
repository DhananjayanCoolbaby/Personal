var associateId = "";
EmployeeModule.controller("EmployeeController", ["$scope", "$http", "EmployeeFactory", function ($scope, $http, EmployeeFactory) {

    $scope.username = associateId;
    $scope.submitClick = function () {

        var UNamePName = {
            Username: $scope.username,
            password: $scope.password
        }

        EmployeeFactory.PostServiceCall(url + '/CheckUserName/', UNamePName).then(function (response) {
            debugger;
            if (response.data["0"].Access == 1) {

               // window.location.href = "/Default1/Index";
                window.location.href = "/TimeSheet/Index?username=" + $scope.username + '&Userlevel=' + response.data["0"].Userlevel;

            }
            else {
                window.location.href = "Erro/Index";
            }
        });
    }



}]);