let app = angular.module('peopleSearchApp', []);
let serverURL = "https://localhost:5001/";

let searchByText = (searchText) => {
	if (searchText.length === 0) {
		return Promise.resolve([]);
	}
	
	let requestURL = serverURL + "api/person/searchByName(" + searchText + ")";
	let requestPromise = new Promise(function(resolve, reject) {
		let xhttp = new XMLHttpRequest();
		xhttp.onreadystatechange = function() {
			if (this.readyState == 4) {
				if (this.status == 200) {
					let searchResults = JSON.parse(this.responseText);
					resolve(searchResults);
				} else {
					reject(new Error("Network request failed."));
				}
			}
		};
		xhttp.open("GET", requestURL, true);
		xhttp.send();
	});

	return requestPromise;
};

app.controller('peopleSearchController', ($scope, $timeout) => {
    $scope.searchText = "John";
	$scope.searchFailed = false;
	$scope.search = () => {
		$scope.isSearching = true;
		searchByText($scope.searchText).then((searchResults) => {
			$scope.searchResults = searchResults;
			$scope.isSearching = false;
			$scope.searchFailed = false;
			$scope.$apply();
		}).catch((reason) => {
			$scope.isSearching = false;
			$scope.searchFailed = true;
			$scope.$apply();
		});
	};
});