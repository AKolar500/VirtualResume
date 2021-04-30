/*Alex Kolar
5/28/2013
CIS166AA Section 15309
*/
//Yes, this is basically copied and pasted from my completed Sales_Tax exercise.

var $ = function (id) {
    return document.getElementById(id); 
}

//this runs when the button named calculate is clicked
var calculate_click = function () {
	//initiate variables
	var length = parseFloat( $("length").value );
	var width = parseFloat( $("width").value );
	if ( isNaN(length) || isNaN(width) ) {
		alert("Please enter positive numbers.");
	}
	else {
		//calculate results
		var area = length * width;
		area = parseFloat( area.toFixed(2) );
		var perimeter = 2 * (length + width);
		perimeter = parseFloat( perimeter.toFixed(2) );
		//display results
		$("area").value = area;
		$("perimeter").value = perimeter;
	}
}

//this runs when the application is loaded
window.onload = function () {
	//call the calculate_click function
	$("calculate").onclick = calculate_click;
}