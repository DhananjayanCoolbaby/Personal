var EmployeeModule = angular.module('EmployeeModule', []);
function CompLibrary() {
    return {
        init: init
    }
    function init(dependencies, controller) {
        dependencies.push('$timeout');
        dependencies.push(controller);
        angularApp.controller('MainCtrl', dependencies);
    }
}
var compX = CompLibrary();
compX.init(deps, _controller);
function _controller($timeout) {
    var ViewModel = this;
    ViewModel.search = "Name";
    ViewModel.quantity = 1;

    for (var i = 0; i < 4; i++) {
        (function (i) {
            $timeout(function () {
                ViewModel.quantity++;
            }, i * 2000);
        })(i); // Pass in i here
    }

}