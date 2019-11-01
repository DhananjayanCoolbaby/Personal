EmployeeModule.controller("AddVendorDetails", ["$scope", "$http", "EmployeeFactory", '$timeout', function ($scope, $http, EmployeeFactory, $timeout) {
    $scope.successHidden = true;
    $scope.SubmitData = function () {
        debugger;
        var oVendorID = $scope.ngVendorId;
        var oVendorname = $scope.ngVendorname;       
        var oVendorContactNO = $scope.ngVendorContactNO;
        var oVendorEmail = $scope.ngVendorEmail;
        var VendorData = {
            VendorID: oVendorID,
            Vendorname: oVendorname,            
            VendorContactNO: oVendorContactNO,
            VendorEmail: oVendorEmail
        }
        EmployeeFactory.PostServiceCall(urlpro + '/SaveVendorData/', VendorData).then(function (response) {
            $scope.successHidden = false;
            $timeout(function () {
                $scope.successHidden = true;
                window.location.href = "AddVendorDetails";
            }, 3000);
        });
    }

    $scope.RedirectToADDCWR = function () {
        debugger;
        var UserID = "admin";
        var Userlevel = "l1";
        window.location.href = "Admin?Username=" + UserID + '&Userlevel=' + Userlevel;
    };
    $scope.RedirectToVendor = function () {
        debugger;
        var UserID = "admin";
        var Userlevel = "l1";
        window.location.href = "AddVendorDetails";
    };
    $scope.RedirectToReporting = function () {
        debugger;
        var UserID = "admin";
        var Userlevel = "l1";
        window.location.href = "AddReporting";
    };
    $scope.RedirectToEmpRegister = function () {
        debugger;
        window.location.href = "EmpRegister";
    };
    $scope.TS_GetsavedVendordetailes = function () {

        $scope.savedVendordetailes = [];
        EmployeeFactory.PostServiceCall(urlpro + '/GetSavedVendorDetailes/').then(function (response) {

            for (i = 0; i < response.data.length; ++i) {
                $scope.savedVendordetailes.push(response.data[i]);
            }
        });
    };

    var Removeopacity = { opacity: ' -0.2' };
    $scope.rebindingVendorData = function (userID) {
        var VendorID = { VendorID: userID }
        EmployeeFactory.PostServiceCall(urlpro + '/FetchDataBasedOnVendorID/', VendorID).then(function (response) {
            debugger;
            $scope.ngVendorname = response.data[0].Vendorname;
            $scope.ngVendorId = response.data[0].VendorID;
            $scope.ngVendorContactNO = response.data[0].VendorContactNO;
            $scope.ngVendorEmail = response.data[0].VendorEmail;
            $("#portlet-config").hide();
            $('.modal-backdrop').css(Removeopacity);
        });
    }

    $scope.TS_GetVendorID = function () {        
        EmployeeFactory.PostServiceCall(urlpro + '/GetGetVendorID/').then(function (response) {
           
                $scope.ngVendorId = response.data;
            
        });
    };

}]);