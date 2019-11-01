EmployeeModule.controller("EmpRegisterController", ["$scope", "$http", "EmployeeFactory", function ($scope, $http, EmployeeFactory) {



    //var numOfDays = new Date(2012, 10, 0).getDate(); //use 0 here and the actual month
    //var days1 = new Array();
    //$scope.days = [];

    //for (var i = 0; i <= numOfDays; i++) {
    //    days1[i] = new Date(2012, 9, i + 1).getDate(); //use month-1 here 
    //    $scope.days.push(days1[i])
    //}


    //var numOfDays = new Date(2012, 4, 0).getDate(); //use 0 here and the actual month
    //$scope.days = [];
    //for (i = 0; i <= numOfDays; i++) {
    //    var d = new Date(numOfDays);
    //    $scope.days.push(d.setDate(d.getDate() + i));
    //}
    //This will give you a number from 0 - 6 which represents (Sunday - Saturday)
    //alert(days[29]);

    //year = 2018;
    //month = 3;
    //var date = new Date(year, month, 1);  
    //$scope.days = [];
    //while (date.getMonth() === month) {
    //    $scope.days.push(new Date(date));
    //    date.setDate(date.getDate() + 1);
    //}
    $scope.RedirectToEmpRegister = function () {
        debugger;

        window.location.href = "EmpRegister";
    };
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

    $scope.GetAllMonthDate = function () {
        $scope.GetMonthDate = [];
        debugger;
        EmployeeFactory.PostServiceCall(urlpro + '/GetMonthDate/').then(function (response) {
            debugger;
            for (i = 0; i < response.data.length; ++i) {
                $scope.GetMonthDate.push(response.data[i]);
            }
        });
    }

    $scope.GetAllCWRRegister = function () {
        $scope.GetAllCWRRegisterDetails = [];
        debugger;
        EmployeeFactory.PostServiceCall(urlpro + '/GetAllCWRRegisterDetails/').then(function (response) {
            debugger;
            for (i = 0; i < response.data.length; ++i) {
                $scope.GetAllCWRRegisterDetails.push(response.data[i]);
            }
        });
    }


    $scope.PickDataBasedOnDate = function () {
        debugger;
        var dateObject = $("#ui_date_picker_change_year_month").datepicker('getDate');
        var SelectDate = $.datepicker.formatDate('mm/dd/yy', dateObject);
        var selectDay = {
            SelectDate: SelectDate
        }
        EmployeeFactory.PostServiceCall(urlpro + '/GetDataBasedOnDate/', selectDay).then(function (response) {
            debugger;
            for (i = 0; i < response.data.length; ++i) {
                $scope.GetAllCWRRegisterDetails.push(response.data[i]);
            }
        });
    }

    $scope.Recheckattendance = function (CWRID) {
        debugger;
        var x = this.val();
        var action = 0;
        if ($scope.rejactedCWRID) {
            action = 0;
        }
        else {
            action = 1;
        }
        var dateObject = $("#ui_date_picker_change_year_month").datepicker('getDate');
        var SelectDate = $.datepicker.formatDate('mm/dd/yy', dateObject);
        var selectDay = {
            SelectDate: SelectDate
        }
        var rejacted = {
            CWRID: rejactedCWRID,
            Month: SelectDate
        }
        EmployeeFactory.PostServiceCall(urlpro + '/rejactedCWRID1/', rejacted).then(function (response) {
            debugger;
            for (i = 0; i < response.data.length; ++i) {
                $scope.GetAllCWRRegisterDetails.push(response.data[i]);
            }
        });
    }



    $(function () {
        $("#ui_date_picker_change_year_month").datepicker();
    });
}]);







//EmployeeModule.directive("datepicker", function () {
//    return {
//        restrict: "A",
//        require: "ngModel",
//        link: function (scope, elem, attrs, ngModelCtrl) {
//            var updateModel = function (dateText) {


//                vstartdate1 = dateText;

//                var a = $('#start_date').val().splitSavedaybydateTime
//                var b = dateText.split('/');
//                if ($('#start_date').val() != "") {
//                    if (new Date(a[2], a[1], a[0]) < new Date(b[2], b[1], b[0])) {

//                        $('#start_date').val("");

//                    }
//                    else {

//                    }
//                }
//            };
//            var options = {
//                dateFormat: 'M yy',
//                setDate: new Date(),
//                changeMonth: true,
//                changeYear: false,
//                showButtonPanel: false,
//                onClose: function (dateText, inst) {
//                    $(this).datepicker('setDate', new Date(inst.selectedYear, inst.selectedMonth, 1));
//                    //PickDataBasedOnDate(dateText);
//                    this.fireEvent && this.fireEvent('onchange') || $(this).change();
//                    vstartdate1 = dateText;
//                },
//                onSelect: function (dateText) {
//                    // this.fireEvent && this.fireEvent('onchange') || $(this).change();
//                    updateModel(dateText);
//                }
//            };
//            // jqueryfy the element
//            $(elem).datepicker(options);
//        }
//    }
//});
