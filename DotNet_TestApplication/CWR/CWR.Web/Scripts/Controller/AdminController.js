﻿EmployeeModule.controller("AdminController", ["$scope", "$http", "EmployeeFactory", '$timeout', function ($scope, $http, EmployeeFactory, $timeout) {
    $scope.IssuccessHidden = true;
    $scope.IsdangerHidden = true;
    $scope.GetState = function () {
        $scope.FetchStateDetiles = [];

        EmployeeFactory.PostServiceCall(urlpro + '/GetState/').then(function (response) {
            for (i = 0; i < response.data.length; ++i) {
                $scope.FetchStateDetiles.push(response.data[i]);
            }
        });
    }

    $scope.GetPosition = function () {
        $scope.FetchPositionDetiles = [];

        EmployeeFactory.PostServiceCall(urlpro + '/GetPosition/').then(function (response) {
            for (i = 0; i < response.data.length; ++i) {
                $scope.FetchPositionDetiles.push(response.data[i]);
            }
        });
    }


    $scope.GetReporting = function () {
        $scope.FetchReportingDetiles = [];

        EmployeeFactory.PostServiceCall(urlpro + '/GetReportingDetiles/').then(function (response) {
            for (i = 0; i < response.data.length; ++i) {
                $scope.FetchReportingDetiles.push(response.data[i]);
            }
        });
    }


    $scope.GetVendor = function () {
        $scope.FetchVendorDetiles = [];

        EmployeeFactory.PostServiceCall(urlpro + '/GetVendorDetiles/').then(function (response) {
            for (i = 0; i < response.data.length; ++i) {
                $scope.FetchVendorDetiles.push(response.data[i]);
            }
        });
    }

    $scope.RedirectToURL = function () {
        debugger;
        window.location.href = "AddVendorDetails";
    };
    $scope.RedirectToEmpRegister = function () {
        debugger;
        window.location.href = "EmpRegister";
    };
    $scope.RediretToADDCWR = function () {
        window.location.href = "Admin";
    }
    $scope.RedirectToReporting = function () {
        window.location.href = "AddReporting";
    }
    $scope.SubmitData = function () {
        debugger;
        var Username = { Username: $scope.ngUsername }
        EmployeeFactory.PostServiceCall(urlpro + '/CheckUsernamesAvailability/', Username).then(function (response) {
            debugger;
            if (response.data != "True") {
                $scope.tempSaveArray = [];
                var oUsername = $scope.ngUsername;
                var oPassword = $scope.ngPassword;
                var okoneEmail = $scope.ngkoneEmail;
                var oVendor = $scope.ngVendor;
                var oPosition = $scope.ngPosition;
                var ofName = $scope.ngfName;
                var olName = $scope.nglName;
                var oDOB = $("#ui_date_picker_change_year_month").val();
                var oFatherName = $scope.ngFatherName;
                var oMobileNo = $scope.ngMobileNo;
                var oGender = $scope.ngGender;
                var oAddress = $scope.ngAddress;
                var oCityorTown = $scope.ngcityorTown;
                var oState = $scope.ngState;
                var oRemarks = $scope.ngRemarks;
                var oPersonalEmail = $scope.ngpEmail;
                var oEmergencycontactNo = $scope.ngEmergencyNo;
                var oEmployeeid = $scope.ngEmpID;
                var oJoiningDate = $("#ui_date_picker_change_year_month_Joining").val();
                var oReportingdate = $("#ui_date_picker_change_year_month_Reporting").val();
                var oEmployeerEmailAddress = $scope.ngempEmail;
                var oReporting = $scope.ngReporting;
                var CWRData = {
                    Username: oUsername,
                    Password: oPassword,
                    koneEmail: okoneEmail,
                    Reporting: oReporting,
                    Vendor: oVendor,
                    Position: oPosition,
                    FName: ofName,
                    LName: olName,
                    DOB: oDOB,
                    FatherName: oFatherName,
                    MobileNo: oMobileNo,
                    Gender: oGender,
                    Address: oAddress,
                    CityorTown: oCityorTown,
                    State: oState,
                    Remarks: oRemarks,
                    PersonalEmail: oPersonalEmail,
                    EmergencycontactNo: oEmergencycontactNo,
                    Employeeid: oEmployeeid,
                    JoiningDate: oJoiningDate,
                    Reportingdate: oReportingdate,
                    EmployeerEmailAddress: oEmployeerEmailAddress
                }
                EmployeeFactory.PostServiceCall(urlpro + '/SaveCWRData/', CWRData).then(function (response) {
                    debugger;
                    App.scrollTo();
                    $scope.IsdangerHidden = true;
                    $scope.IssuccessHidden = false;
                    $timeout(function () {
                        $scope.IssuccessHidden = true;
                        window.location.href = "Admin";
                    }, 3000);
                });
            }
            else {
                App.scrollTo();
                $scope.IsdangerHidden = false;
                $timeout(function () {
                    $scope.IsdangerHidden = true;
                }, 3000);

            }

        });
    }

    //function myFunction() {
    //    setTimeout(function () { $scope.alertsuccess = true; }, 3000);
    //}
    $scope.TS_Getsavedcwrdetailes = function () {

        $scope.savedcwrdetailes = [];
        EmployeeFactory.PostServiceCall(urlpro + '/GetSavedCWRDetailes/').then(function (response) {

            for (i = 0; i < response.data.length; ++i) {
                $scope.savedcwrdetailes.push(response.data[i]);
            }
        });
    };

    $scope.rebindingcwrdata = function (username) {
        var Requsername = { username: username }
        EmployeeFactory.PostServiceCall(urlpro + '/FetchDataBasedOnUserName/', Requsername).then(function (response) {
            debugger;
            $scope.ngUsername = response.data[0].Username;
            $scope.ngName = response.data[0].Name;
            $scope.ngJoiningDate = response.data[0].JoiningDate;
            $scope.ngFatherName = response.data[0].FatherName;
            $scope.ngDOB = response.data[0].DOB;
            $scope.ngAddress = response.data[0].Address;
            $scope.ngMobileNo = response.data[0].MobileNo;
            $scope.ngGender = response.data[0].Gender;
            $scope.ngEmail = response.data[0].Email;
            $scope.ngPostcode = response.data[0].Postcode;
            $scope.ngReporting = response.data[0].Reporting;
            $scope.ngUserLevel = response.data[0].UserLevel;
            $scope.ngPassword = response.data[0].Password;
            $scope.ngState = response.data[0].State;
            $scope.ngPosition = response.data[0].Position;

        });
    }

    $scope.SubmenuClick = function () {
        alert("Cool");
    }
    $scope.AddVendor = function () {
        alert(12);
        window.location.href = "AddVendorDetails/Index";
    }

    //$scope.AddCWR = function () {
    //    alert($scope.data);
    //    window.location.href = "Admin?username=" + UserID + '&Userlevel=' + Userlevel;
    //}

}]);



EmployeeModule.directive("datepicker1", function () {
    return {
        restrict: "A",
        require: "ngModel",
        link: function (scope, elem, attrs, ngModelCtrl) {
            var updateModel = function (dateText) {
            };
            var options = {
                changeMonth: true,
                changeYear: true,

                dateFormat: "dd/mm/yy",
                //onClose: function (dateText, inst) {
                //    $(this).datepicker('setDate', new Date(inst.selectedYear, inst.selectedMonth, 1));

                //},
                // handle jquery date change
                onSelect: function (dateText) {
                    updateModel(dateText);
                }
            };
            // jqueryfy the element
            $(elem).datepicker(options);
        }
    }
});
EmployeeModule.directive("datepicker", function () {
    return {
        restrict: "A",
        require: "ngModel",
        link: function (scope, elem, attrs, ngModelCtrl) {
            var updateModel = function (dateText) {
            };

            var options = {
                changeMonth: true,
                changeYear: true,
                dateFormat: "dd/mm/yy",
                //onClose: function (dateText, inst) {
                //    $(this).datepicker('setDate', new Date(inst.selectedYear, inst.selectedMonth, 1));

                //},
                // handle jquery date change
                onSelect: function (dateText) {

                    updateModel(dateText);

                }
            };
            $(elem).datepicker(options);
        }
    }
});
EmployeeModule.directive('numbersOnly', function () {
    return {
        require: 'ngModel',
        link: function (scope, element, attr, ngModelCtrl) {
            function fromUser(text) {
                if (text) {
                    var transformedInput = text.replace(/[^0-9-]/g, '');
                    if (transformedInput !== text) {
                        ngModelCtrl.$setViewValue(transformedInput);
                        ngModelCtrl.$render();
                    }
                    return transformedInput;
                }
                return undefined;
            }
            ngModelCtrl.$parsers.push(fromUser);
        }
    };
});
EmployeeModule.directive("datepicker2", function () {
    return {
        restrict: "A",
        require: "ngModel",
        link: function (scope, elem, attrs, ngModelCtrl) {
            var updateModel = function (dateText) {
            };
            var options = {
                changeMonth: true,
                changeYear: true,
                dateFormat: "dd/mm/yy",
                //onClose: function (dateText, inst) {
                //    $(this).datepicker('setDate', new Date(inst.selectedYear, inst.selectedMonth, 1));

                //},
                // handle jquery date change
                onSelect: function (dateText) {
                    updateModel(dateText);
                }
            };
            // jqueryfy the element
            $(elem).datepicker(options);
        }
    }
});



