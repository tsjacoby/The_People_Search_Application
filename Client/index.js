// Constants.
let app = angular.module('peopleSearchApp', []);
let serverURL = "https://localhost:5001/";
let searchDelayInMS = 4000;

// Function that searches for people by name based on the given search text. Returns a promise containing the search results.
let searchByName = (searchText) => {
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

// Controller.
app.controller('peopleSearchController', ($scope, $timeout) => {
	// Function for setting whether or not the application is currently searching.
	let setIsSearching = (isSearching) => {
		$scope.isSearching = isSearching;
		
		// Disables keyboard input when searching so that users can't tab around the page when search
		// is in progress.
		document.onkeydown = (e) => {
			return !isSearching;
		};
	};
	
    $scope.searchText = "Bob";
	$scope.searchFailed = false;
	$scope.search = () => {
		setIsSearching(true);
		$timeout(() => {
			searchByName($scope.searchText).then((searchResults) => {
				$scope.searchResults = searchResults;
				setIsSearching(false);
				$scope.searchFailed = false;
				$scope.$apply();
			}).catch((reason) => {
				setIsSearching(false);
				$scope.searchFailed = true;
				$scope.$apply();
			});
		}, searchDelayInMS);
	};
});