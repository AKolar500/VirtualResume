var $ = function (id) {
    return document.getElementById(id);
}

var random_number = function ( min, max, digits ) {
    // If digits is not a number, set it to zero
    // Otherwise, make it a whole number
    digits = isNaN(digits) ? 0 : parseInt(digits);

    // Make sure digits is between 0 and 16
    if ( digits < 0 ) {
        digits = 0;
    } else if ( digits > 16 ) {
        digits = 16;
    }
    
    if ( digits == 0 ) {
        // Return an integer
        return Math.floor( Math.random() * ( max - min + 1 ) ) + min;
    } else {
        // Return a decimal with the specified number of digits
        var rand = Math.random() * ( max - min ) + min;
        return parseFloat( rand.toFixed(digits) );
    }
}

var calculate_click = function () {
    var investment = parseFloat( $("investment").value );
    var annualRate = parseFloat( $("rate").value );
    var years = parseInt( $("years").value );

	$("futureValue").value = "";
	
	if (isNaN(investment) || investment <= 0) {
		alert("Investment must be a valid number\nand greater than zero.");
	} else if(isNaN(annualRate) || annualRate <= 0) {
		alert("Annual rate must be a valid number\nand greater than zero.");
	} else if(isNaN(years) || years <= 0) {
		alert("Years must be a valid number\nand greater than zero.");
	} else {
		annualRate = annualRate / 100;
		var futureValue = investment;

		for ( i = 1; i <= years; i++ ) {
			futureValue = futureValue *
				(1 + annualRate);
		}
		$("futureValue").value = futureValue.toFixed(2);
	}
}

window.onload = function () {
    $("calculate").onclick = calculate_click;
    $("investment").focus();
}
