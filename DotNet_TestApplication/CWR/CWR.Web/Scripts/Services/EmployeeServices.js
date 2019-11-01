EmployeeModule.factory('EmployeeFactory', ["$http", "$q", function ($http, $q) {
    return {
        GetServiceCall: function (url) {

            var deferred = $q.defer();
            $http({ method: 'GET', url: url }).success(function (data, status, headers, config) {
                deferred.resolve(data);
            }).error(function (data, status, headers, config) {
                deferred.reject(status);
            });
            return deferred.promise;
        },

        PostServiceCall: function (url, parameter) {
            var deferred = $q.defer();
            $http({
                method: 'POST',
                url: url,
                data: parameter
            }).then(function (data, status, headers, config) {
                deferred.resolve(data);
            }, function (error) {

            });
            return deferred.promise;
        },

        //ConvertToDate: function (value) {
        //    var pattern = /Date\(([^)]+)\)/;
        //    var results = pattern.exec(value);
        //    var dt = new Date(parseFloat(results[1]));
        //    return dt.getDate() + "/" + (dt.getMonth() + 1) + "/" + dt.getFullYear();
        //},
        /*To initialise datepicker in from and to txt box*/
        //InitialiseDatePicker: function () {
        //    alert(12);
        //    $('#start_date').datepicker({
                
        //    });
        //    //To Prevent calendar textbox readonly
        //    $('#start_date').keypress(function (event) {
        //        event.preventDefault();
        //    });
        //    //To Prevent calendar textbox readonly
        //    $('start_date').keydown(function (event) {
        //        event.preventDefault();
        //    });
        //}

    };
}]);