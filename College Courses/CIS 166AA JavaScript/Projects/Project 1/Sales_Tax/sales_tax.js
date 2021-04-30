/*Alex Kolar
5/28/2013
CIS166AA Section 15309
*/

var $ = function (id) {
    return document.getElementById(id); 
}

//this runs when the button named calculate is clicked
var calculate_click = function () {
	//alert ("This is the calculate_click event handler.");
	//initiate variables
	var subtotal = parseFloat( $("subtotal").value );
	var taxRate = parseFloat( $("taxRate").value );
	if ( isNaN(subtotal) || isNaN(taxRate) ) {
		alert("Please check your entries for validity.");
	}
	else {
		//calculate results
		var salesTax = subtotal * (taxRate / 100);
		salesTax = parseFloat( salesTax.toFixed(2) );
		var total = subtotal + salesTax;
		//display results
		$("salesTax").value = salesTax;
		$("total").value = total.toFixed(2);
	}
}

//this runs when the application is loaded
window.onload = function () {
	//alert ("This is the window.onload event handler.");
	//call the calculate_click function
	$("calculate").onclick = calculate_click;
}