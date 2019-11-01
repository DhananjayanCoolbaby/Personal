EmployeeModule.controller("AddReporting", ["$scope", "$http", "EmployeeFactory", '$timeout', function ($scope, $http, EmployeeFactory, $timeout) {
    $scope.IssuccessHidden = true;
    $scope.SubmitData = function () {
        var oReportername = $scope.ngReportername;
        var oReporterContactNO = $scope.ngReporterContactNO;
        var oReporterEmail = $scope.ngReporterEmail;
        var oReporterID = $scope.ngReporterId;
        var oReporterUsername = $scope.ngReporterUsername;
        var oReporterPassword = $scope.ngReporterPassword;
        var ocostcentername = $scope.ngcostcentername;
        var ReporterData = {
            Reportername: oReportername,
            ReporterContactNO: oReporterContactNO,
            ReporterEmail: oReporterEmail,
            ReporterID: oReporterID,
            ReporterUsername: oReporterUsername,
            ReporterPassword: oReporterPassword,
            costcentername: ocostcentername
        }
        EmployeeFactory.PostServiceCall(urlpro + '/SaveReporterData/', ReporterData).then(function (response) {
            debugger;
            $scope.IssuccessHidden = false;
            $timeout(function () {
                $scope.IssuccessHidden = true;
                window.location.href = "AddReporting";
            }, 3000);
            
        });
    }

    $scope.RedirectToADDCWR = function () {

        var UserID = "admin";
        var Userlevel = "l1";
        window.location.href = "Admin?Username=" + UserID + '&Userlevel=' + Userlevel;
    };
    $scope.RedirectToVendor = function () {

        var UserID = "admin";
        var Userlevel = "l1";
        window.location.href = "AddVendorDetails";
    };
    $scope.RedirectToReporting = function () {

        var UserID = "admin";
        var Userlevel = "l1";
        window.location.href = "AddReporting";
    };
    $scope.RedirectToEmpRegister = function () {

        var UserID = "admin";
        var Userlevel = "l1";
        window.location.href = "EmpRegister";
    };

    $scope.TS_GetsavedReporterIDdetailes = function () {

        $scope.savedReporterIDdetailes = [];
        EmployeeFactory.PostServiceCall(urlpro + '/GetSavedReporterDetailes/').then(function (response) {

            for (i = 0; i < response.data.length; ++i) {
                $scope.savedReporterIDdetailes.push(response.data[i]);
            }
        });
    };

    var Removeopacity = { opacity: ' -0.2' };
    $scope.rebindingReporterData = function (userID) {
        var ReporterID = { ReporterID: userID }
        EmployeeFactory.PostServiceCall(urlpro + '/FetchDataBasedOnReporter/', ReporterID).then(function (response) {
            debugger;
            $scope.ngReportername = response.data[0].Reportername;
            $scope.ngReporterId = response.data[0].ReporterID;
            $scope.ngReporterContactNO = response.data[0].ReporterContactNO;
            $scope.ngReporterEmail = response.data[0].ReporterEmail;
            $("#portlet-config").hide();
            $('.modal-backdrop').css(Removeopacity);
        });
    }

    $scope.TS_GetReporterID = function () {
        EmployeeFactory.PostServiceCall(urlpro + '/GetReportingID/').then(function (response) {
            debugger;
            $scope.ngReporterId = response.data;

        });
    };

}]);