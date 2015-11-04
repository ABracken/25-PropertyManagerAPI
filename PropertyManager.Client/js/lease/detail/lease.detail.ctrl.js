angular.module('app').controller('LeaseDetailController', function ($scope, $stateParams, Lease, $state) {

    if ($stateParams.id) {
        $scope.lease = Lease.get({ id: $stateParams.id });
    }
    else {
        $scope.lease = new Lease();
    }

    $scope.saveLease = function () {
        if ($scope.lease.LeaseId) {
            $scope.lease.$update(function () {
                $state.go('lease.grid');
            });
        }
        else {
            $scope.lease.$save(function () {
                $state.go('lease.grid');
            });
        }
    }
});