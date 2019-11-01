


EmployeeModule.controller("TimeSheetController", ["$scope", "$http", "EmployeeFactory", function ($scope, $http, EmployeeFactory) {
    $scope.FetchDateDetailsBasedOnassociateId = function () {
        $scope.FetchDateDetails = [];
        $scope.ngassociateId = associateId;
        $scope.FetchDateDetails.length = 0;
        var CWRID = { CWRID: associateId }
      
        EmployeeFactory.PostServiceCall(urlpro + '/FetchDateDetails/', CWRID).then(function (response) {
            debugger;
        //EmployeeFactory.PostServiceCall(urlpro + '/FetchDateDetails/', UserName).then(function (response) {
            for (i = 0; i < response.data.length; ++i) {
                $scope.FetchDateDetails.push(response.data[i]);
                //$scope.ddlSelectVal = $scope.FetchDateDetails[i].ProjectHoursWorked;
            }
        });
    }
    

    $scope.FetchLegendDetails = [];
    EmployeeFactory.PostServiceCall(urlpro + '/FetchLegendDetails/').then(function (response) {
        for (i = 0; i < response.data.length; ++i) {
            $scope.FetchLegendDetails.push(response.data[i]);
        }
    });
    var CWRID = { CWRID: associateId }
    $scope.TS_GetSavedTimeSheetDetailes = function () {
        $scope.SavedTimeSheetDetailes = [];
        EmployeeFactory.PostServiceCall(urlpro + '/GetSavedTimeSheetDetailes/', CWRID).then(function (response) {

            for (i = 0; i < response.data.length; ++i) {
                $scope.SavedTimeSheetDetailes.push(response.data[i]);
            }
        });
    };
    
    $scope.DisableSubmitButtion = $scope.GetReuestID;


    var pocvalListsave = $scope.Poclist;

    $scope.SubmitTimeSheet = function () {
        
        $scope.tempSaveArray = [];
        var lentextbox = $scope.FetchDateDetails.length;
        for (var i = 0; i < lentextbox; i++) {
            var strval = $scope.FetchDateDetails[i].Date;
            var txtboxval = $('#timeval_' + strval).val();
            var dateval = $('#date_' + strval).data("date");
            var TimeSheetID = $('#date_' + strval).data("timesheetperiodid");
            var tsComents = $scope.ngComments;
            var timeSheetdata = {
                DateWorked: dateval,
                ProjectHoursWorked: txtboxval,
                TimesheetPeriodid: TimeSheetID,
                Comments: tsComents
            }
            $scope.tempSaveArray.push(timeSheetdata);
        }
        var TimeSheetarray = $scope.tempSaveArray;
        EmployeeFactory.PostServiceCall(urlpro + '/SaveTimeSheetDetails/', TimeSheetarray).then(function (response) {
        });


    }
    $scope.TimeList = [];
    $scope.SaveTime = function (date) {

        var txtboxval = $('#timeval_' + date).val();

        var dateval = $('#date_' + date).data("date");
        var TimeSheetID = $('#date_' + date).data("timesheetperiodid");

        // var date = dateval.split("-");
        var TimeSavedata = {
            Date: dateval,
            ProjectHoursWorked: txtboxval,
            TimesheetPeriodid: TimeSheetID
        }
        EmployeeFactory.PostServiceCall(urlpro + '/SavedaybydateTime/', TimeSavedata).then(function (response) {

        });
    }

    $scope.RebindingTimeSheetData = function (RequestId) {
        
        var ReqID = { RequestId: RequestId }

        EmployeeFactory.PostServiceCall(urlpro + '/FetchDataBasedOnRequestId/', ReqID).then(function (response) {

            $scope.FetchDateDetails.length = 0;
            debugger;
            for (i = 0; i < response.data.length; ++i) {

                $scope.FetchDateDetails.push(response.data[i]);

            }
        });
    }

    $scope.PickDataBasedOnDate = function (date) {
       
        var ReqDate = { Date: date }
        EmployeeFactory.PostServiceCall(urlpro + '/FetchDataBasedOnDate/', ReqDate).then(function (response) {
            debugger;
            $scope.FetchDateDetails.length = 0;
            for (i = 0; i < response.data.length; ++i) {
                debugger;
                $scope.FetchDateDetails.push(response.data[i]);

            }
        });
    }


    $(function () {
        $("#start_date").datepicker();
    });

   
}]);





EmployeeModule.directive("datepicker", function () {
    return {
        restrict: "A",
        require: "ngModel",
        link: function (scope, elem, attrs, ngModelCtrl) {
            var updateModel = function (dateText) {


                vstartdate1 = dateText;

                var a = $('#start_date').val().splitSavedaybydateTime
                var b = dateText.split('/');
                if ($('#start_date').val() != "") {
                    if (new Date(a[2], a[1], a[0]) < new Date(b[2], b[1], b[0])) {

                        $('#start_date').val("");

                    }
                    else {

                    }
                }
            };
            var options = {
                dateFormat: 'M yy',
                changeMonth: true,
                changeYear: false,
                showButtonPanel: false,
                onClose: function (dateText, inst) {
                    $(this).datepicker('setDate', new Date(inst.selectedYear, inst.selectedMonth, 1));
                    //PickDataBasedOnDate(dateText);
                    this.fireEvent && this.fireEvent('onchange') || $(this).change();
                    vstartdate1 = dateText;
                },
                onSelect: function (dateText) {
                   // this.fireEvent && this.fireEvent('onchange') || $(this).change();
                    updateModel(dateText);
                }
            };
            // jqueryfy the element
            $(elem).datepicker(options);
        }
    }
});








